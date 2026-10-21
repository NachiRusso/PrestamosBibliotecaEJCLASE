using Microsoft.EntityFrameworkCore;
using PrestamosBiblioteca.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosBiblioteca.Modelo.Datos
{
    public class PrestamosBibliotecaDbContext : DbContext
    {
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<PrestamoDetalle> PrestamoDetalles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BibliotecaEfDb;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>().HasIndex(l => l.Codigo).IsUnique();
            modelBuilder.Entity<Prestamo>().HasIndex(p => p.Numero).IsUnique();

            modelBuilder.Entity<PrestamoDetalle>()
                .HasOne(d => d.Libro)
                .WithMany(l => l.Detalles)
                .HasForeignKey(d => d.LibroId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

