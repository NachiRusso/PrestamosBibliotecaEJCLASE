using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosBiblioteca.Modelo.Entidades
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string AlumnoNombre { get; set; } = string.Empty;
        public string AlumnoDocumento { get; set; } = string.Empty;
        public DateTime FechaDevolucionPrevista { get; set; }
        public int CantidadItems { get; set; }

        public List<PrestamoDetalle> Detalles { get; set; } = new();
    }
}
