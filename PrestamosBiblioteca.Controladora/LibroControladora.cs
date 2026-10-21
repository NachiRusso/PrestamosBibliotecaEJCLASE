using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosBiblioteca.Modelo;
using PrestamosBiblioteca.Modelo.Entidades;
using PrestamosBiblioteca.Modelo.Datos;

namespace PrestamosBiblioteca.Controladora
{
    public class LibroControladora
    {
        public void Agregar(Libro libro)
        {
            if (string.IsNullOrWhiteSpace(libro.Codigo) || string.IsNullOrWhiteSpace(libro.Titulo) || string.IsNullOrWhiteSpace(libro.Autor))
                throw new ArgumentException("Código, Título y Autor son obligatorios.");

            using var db = new PrestamosBibliotecaDbContext();
            if (db.Libros.Any(l => l.Codigo == libro.Codigo))
                throw new Exception("El código ya está registrado.");

            db.Libros.Add(libro);
            db.SaveChanges();
        }

        public void Eliminar(int libroId)
        {
            using var db = new PrestamosBibliotecaDbContext();
            bool enUso = db.PrestamoDetalles.Any(d => d.LibroId == libroId);

            if (enUso)
                throw new Exception("No se puede eliminar el libro porque forma parte de préstamos registrados.");

            var libro = db.Libros.Find(libroId);
            if (libro != null)
            {
                db.Libros.Remove(libro);
                db.SaveChanges();
            }
        }

        public void Modificar(Libro libroActualizado)
        {
            if (string.IsNullOrWhiteSpace(libroActualizado.Codigo) ||
                string.IsNullOrWhiteSpace(libroActualizado.Titulo) ||
                string.IsNullOrWhiteSpace(libroActualizado.Autor))
            {
                throw new ArgumentException("Código, Título y Autor son obligatorios.");
            }

            using var db = new PrestamosBibliotecaDbContext(); // Asegúrate de usar el nombre exacto de tu DbContext

            // Verifica que el nuevo código no pertenezca a otro libro distinto
            if (db.Libros.Any(l => l.Codigo == libroActualizado.Codigo && l.Id != libroActualizado.Id))
            {
                throw new Exception("El código ya está registrado en otro libro.");
            }

            var libroBd = db.Libros.Find(libroActualizado.Id);
            if (libroBd != null)
            {
                libroBd.Codigo = libroActualizado.Codigo;
                libroBd.Titulo = libroActualizado.Titulo;
                libroBd.Autor = libroActualizado.Autor;
                libroBd.Disponible = libroActualizado.Disponible;

                db.SaveChanges();
            }
            else
            {
                throw new Exception("El libro que intenta modificar no existe en la base de datos.");
            }
        }

        public List<PrestamoDetalle> ObtenerDetallesPorPrestamoId(int prestamoId)
        {
            using var db = new PrestamosBibliotecaDbContext(); // O el nombre exacto de tu DbContext
            return db.PrestamoDetalles
                     .Where(d => d.PrestamoId == prestamoId)
                     .ToList();
        }

        public List<Libro> Listar(string filtro = "")
        {
            using var db = new PrestamosBibliotecaDbContext();
            var query = db.Libros.AsQueryable();
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                query = query.Where(l => l.Codigo.Contains(filtro) || l.Titulo.Contains(filtro) || l.Autor.Contains(filtro));
            }
            return query.ToList();
        }
    }
}

