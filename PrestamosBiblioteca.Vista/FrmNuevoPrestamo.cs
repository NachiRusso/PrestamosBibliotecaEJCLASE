using PrestamosBiblioteca.Controladora;
using PrestamosBiblioteca.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamosBiblioteca.Vista
{
    public partial class FrmNuevoPrestamo : Form
    {
        private readonly LibroControladora _libroControladora = new LibroControladora();
        private readonly PrestamoControladora _prestamoControladora = new PrestamoControladora();
        private readonly BindingList<DetalleItemView> _lineasTemporales = new BindingList<DetalleItemView>();

        public class DetalleItemView
        {
            public int LibroId { get; set; }
            public string Codigo { get; set; } = string.Empty;
            public string Titulo { get; set; } = string.Empty;
            public string Autor { get; set; } = string.Empty;
            public int Cantidad { get; set; }
        }

        public FrmNuevoPrestamo()
        {
            InitializeComponent();
            dtpDevolucion.Value = DateTime.Today.AddDays(7);
            ConfigurarGrilla();
            CargarLibrosDisponibles();
        }

        private void ConfigurarGrilla()
        {
            dgvDetalles.DataSource = _lineasTemporales;
        }

        private void CargarLibrosDisponibles()
        {
            try
            {
                var librosDisponibles = _libroControladora.Listar().Where(l => l.Disponible).ToList();
                cmbLibros.DataSource = librosDisponibles;
                cmbLibros.DisplayMember = "Titulo";
                cmbLibros.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar catálogo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregarLinea_Click(object sender, EventArgs e)
        {
            if (cmbLibros.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un libro disponible.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var libroSel = (Libro)cmbLibros.SelectedItem;
            int cantidad = (int)numCantidad.Value;

            if (_lineasTemporales.Any(l => l.LibroId == libroSel.Id))
            {
                MessageBox.Show($"El libro '{libroSel.Titulo}' ya está incluido en la lista.", "Línea Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _lineasTemporales.Add(new DetalleItemView
            {
                LibroId = libroSel.Id,
                Codigo = libroSel.Codigo,
                Titulo = libroSel.Titulo,
                Autor = libroSel.Autor,
                Cantidad = cantidad
            });

            ActualizarTotalItems();
        }

        private void BtnQuitarLinea_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.SelectedRows.Count > 0)
            {
                var item = (DetalleItemView)dgvDetalles.SelectedRows[0].DataBoundItem;
                _lineasTemporales.Remove(item);
                ActualizarTotalItems();
            }
        }

        private void ActualizarTotalItems()
        {
            int total = _lineasTemporales.Sum(l => l.Cantidad);
            lblTotalItems.Text = $"Total Ítems: {total}";
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                var prestamo = new Prestamo
                {
                    Fecha = DateTime.Now,
                    AlumnoNombre = txtAlumnoNombre.Text.Trim(),
                    AlumnoDocumento = txtAlumnoDocumento.Text.Trim(),
                    FechaDevolucionPrevista = dtpDevolucion.Value.Date,
                    Detalles = _lineasTemporales.Select(item => new PrestamoDetalle
                    {
                        LibroId = item.LibroId,
                        Cantidad = item.Cantidad
                    }).ToList()
                };

                int numeroAsignado = _prestamoControladora.RegistrarPrestamo(prestamo);

                MessageBox.Show($"¡Préstamo N° {numeroAsignado} registrado con éxito!", "Registro Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Registrar Préstamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtAlumnoNombre.Clear();
            txtAlumnoDocumento.Clear();
            dtpDevolucion.Value = DateTime.Today.AddDays(7);
            _lineasTemporales.Clear();
            numCantidad.Value = 1;
            ActualizarTotalItems();
            CargarLibrosDisponibles();
        }
    }
}