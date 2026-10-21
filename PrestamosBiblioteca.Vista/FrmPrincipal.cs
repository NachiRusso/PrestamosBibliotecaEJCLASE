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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnGestionLibros_Click(object sender, EventArgs e)
        {
            var form = new FrmLibros();
            form.ShowDialog();
        }

        private void BtnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            var form = new FrmNuevoPrestamo();
            form.ShowDialog();
        }

        private void BtnConsultaPrestamos_Click(object sender, EventArgs e)
        {
            var form = new FrmConsultaPrestamos();
            form.ShowDialog();
        }
    }
}