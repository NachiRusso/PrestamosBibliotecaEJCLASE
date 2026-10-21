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
using PrestamosBiblioteca.Controladora;

namespace PrestamosBiblioteca.Vista
{
    public partial class FrmLibros : Form
    {
        private readonly LibroControladora _libroControladora = new LibroControladora();
        private int? _selectedLibroId = null;

        public FrmLibros()
        {
            InitializeComponent();
            CargarLibros();
        }

        private void CargarLibros(string filtro = "")
        {
            try
            {
                var lista = _libroControladora.Listar(filtro);
                dgvLibros.DataSource = null;
                dgvLibros.DataSource = lista;

                if (dgvLibros.Columns["Detalles"] != null)
                    dgvLibros.Columns["Detalles"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar libros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                var libro = (Libro)dgvLibros.SelectedRows[0].DataBoundItem;
                if (libro != null)
                {
                    _selectedLibroId = libro.Id;
                    txtCodigo.Text = libro.Codigo;
                    txtTitulo.Text = libro.Titulo;
                    txtAutor.Text = libro.Autor;
                    chkDisponible.Checked = libro.Disponible;
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var libro = new Libro
                {
                    Id = _selectedLibroId ?? 0,
                    Codigo = txtCodigo.Text.Trim(),
                    Titulo = txtTitulo.Text.Trim(),
                    Autor = txtAutor.Text.Trim(),
                    Disponible = chkDisponible.Checked
                };

                if (_selectedLibroId.HasValue)
                {
                    _libroControladora.Modificar(libro);
                    MessageBox.Show("Libro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _libroControladora.Agregar(libro);
                    MessageBox.Show("Libro registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Limpiar();
                CargarLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!_selectedLibroId.HasValue)
            {
                MessageBox.Show("Seleccione un libro para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de eliminar este libro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _libroControladora.Eliminar(_selectedLibroId.Value);
                    MessageBox.Show("Libro eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarLibros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarLibros(txtBuscar.Text.Trim());
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            _selectedLibroId = null;
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            chkDisponible.Checked = true;
            dgvLibros.ClearSelection();
        }
    }
}