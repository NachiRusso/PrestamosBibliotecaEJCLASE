using PrestamosBiblioteca.Modelo.Datos;
using PrestamosBiblioteca.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrestamosBiblioteca.Controladora
{
    public class PrestamoControladora
    {
        public int RegistrarPrestamo(Prestamo prestamo)
        {
            if (string.IsNullOrWhiteSpace(prestamo.AlumnoNombre) || string.IsNullOrWhiteSpace(prestamo.AlumnoDocumento))
                throw new ArgumentException("Los datos del alumno son obligatorios.");

            if (!prestamo.Detalles.Any())
                throw new Exception("El préstamo debe incluir al menos un libro.");

            if (prestamo.FechaDevolucionPrevista <= prestamo.Fecha)
                throw new Exception("La fecha de devolución debe ser posterior a la fecha del préstamo.");

            // Validar restricción de líneas duplicadas
            bool hayDuplicados = prestamo.Detalles.GroupBy(d => d.LibroId).Any(g => g.Count() > 1);
            if (hayDuplicados)
                throw new Exception("No se permite incluir el mismo libro en múltiples líneas. Sume la cantidad en una sola.");

            using var db = new PrestamosBibliotecaDbContext();
            using var transaction = db.Database.BeginTransaction();

            try
            {
                int maxNumero = db.Prestamos.Any() ? db.Prestamos.Max(p => p.Numero) : 0;
                prestamo.Numero = maxNumero + 1;
                prestamo.CantidadItems = prestamo.Detalles.Sum(d => d.Cantidad);

                foreach (var detalle in prestamo.Detalles)
                {
                    var libroBd = db.Libros.Find(detalle.LibroId);
                    if (libroBd == null || !libroBd.Disponible)
                        throw new Exception($"El libro '{detalle.LibroId}' no existe o no está disponible.");

                    // Regla de negocio central: Se copia el título para conservar el histórico
                    detalle.TituloHistorico = libroBd.Titulo;

                    // Se desvincula la entidad para evitar conflictos de tracking en el DbContext
                    detalle.Libro = null!;
                }

                db.Prestamos.Add(prestamo);
                db.SaveChanges();
                transaction.Commit();

                return prestamo.Numero;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public List<Prestamo> Listar(DateTime? desde, DateTime? hasta, string filtroAlumno)
        {
            using var db = new PrestamosBibliotecaDbContext();
            var query = db.Prestamos.AsQueryable();

            if (desde.HasValue) query = query.Where(p => p.Fecha >= desde.Value.Date);
            if (hasta.HasValue) query = query.Where(p => p.Fecha <= hasta.Value.Date);
            if (!string.IsNullOrWhiteSpace(filtroAlumno))
                query = query.Where(p => p.AlumnoNombre.Contains(filtroAlumno));

            return query.OrderByDescending(p => p.Numero).ToList();
        }
        public List<PrestamoDetalle> ObtenerDetallesPorPrestamoId(int prestamoId)
        {
            using var db = new PrestamosBibliotecaDbContext();
            return db.PrestamoDetalles
                     .Where(d => d.PrestamoId == prestamoId)
                     .ToList();
        }
    }
}

