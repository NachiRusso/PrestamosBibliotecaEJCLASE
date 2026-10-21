using PrestamosBiblioteca.Controladora;
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
    public partial class FrmConsultaPrestamos : Form
    {
        private readonly PrestamoControladora _prestamoControladora = new PrestamoControladora();

        public FrmConsultaPrestamos()
        {
            InitializeComponent();
            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpHasta.Value = DateTime.Today;
            CargarPrestamos();
        }

        private void CargarPrestamos()
        {
            try
            {
                DateTime? desde = dtpDesde.Value;
                DateTime? hasta = dtpHasta.Value;
                string filtroAlumno = txtAlumnoFiltro.Text.Trim();

                var lista = _prestamoControladora.Listar(desde, hasta, filtroAlumno);

                dgvPrestamos.DataSource = null;
                dgvPrestamos.DataSource = lista.Select(p => new
                {
                    p.Id,
                    p.Numero,
                    Fecha = p.Fecha.ToShortDateString(),
                    Alumno = p.AlumnoNombre,
                    Documento = p.AlumnoDocumento,
                    DevoluciónPrevista = p.FechaDevolucionPrevista.ToShortDateString(),
                    CantidadItems = p.CantidadItems
                }).ToList();

                dgvDetalleHistorico.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar préstamos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvPrestamos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                dynamic selectedRow = dgvPrestamos.SelectedRows[0].DataBoundItem;
                if (selectedRow != null)
                {
                    int prestamoId = selectedRow.Id;
                    CargarDetalle(prestamoId);
                }
            }
        }

        private void CargarDetalle(int prestamoId)
        {
            try
            {
                var detalles = _prestamoControladora.ObtenerDetallesPorPrestamoId(prestamoId);
                dgvDetalleHistorico.DataSource = detalles.Select(d => new
                {
                    d.LibroId,
                    TituloHistorico = d.TituloHistorico,
                    CantidadPrestada = d.Cantidad
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener detalles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            CargarPrestamos();
        }
    }
}
