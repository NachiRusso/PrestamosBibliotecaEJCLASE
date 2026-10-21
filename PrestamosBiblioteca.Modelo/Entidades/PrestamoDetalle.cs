using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosBiblioteca.Modelo.Entidades
{
    public class PrestamoDetalle
    {
        public int Id { get; set; }
        public int PrestamoId { get; set; }
        public Prestamo Prestamo { get; set; } = null!;
        public int LibroId { get; set; }
        public Libro Libro { get; set; } = null!;
        public string TituloHistorico { get; set; } = string.Empty;
        public int Cantidad { get; set; }
    }
}
