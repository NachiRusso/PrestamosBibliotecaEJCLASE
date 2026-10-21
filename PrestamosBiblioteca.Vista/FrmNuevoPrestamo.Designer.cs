namespace PrestamosBiblioteca.Vista
{
    partial class FrmNuevoPrestamo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.gbCabecera = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtAlumnoNombre = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtAlumnoDocumento = new System.Windows.Forms.TextBox();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarLinea = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnQuitarLinea = new System.Windows.Forms.Button();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.gbCabecera.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCabecera
            // 
            this.gbCabecera.Controls.Add(this.lblNombre);
            this.gbCabecera.Controls.Add(this.txtAlumnoNombre);
            this.gbCabecera.Controls.Add(this.lblDocumento);
            this.gbCabecera.Controls.Add(this.txtAlumnoDocumento);
            this.gbCabecera.Controls.Add(this.lblDevolucion);
            this.gbCabecera.Controls.Add(this.dtpDevolucion);
            this.gbCabecera.Location = new System.Drawing.Point(20, 15);
            this.gbCabecera.Name = "gbCabecera";
            this.gbCabecera.Size = new System.Drawing.Size(760, 100);
            this.gbCabecera.TabIndex = 0;
            this.gbCabecera.TabStop = false;
            this.gbCabecera.Text = "Datos del Alumno y Préstamo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Alumno:";
            // 
            // txtAlumnoNombre
            // 
            this.txtAlumnoNombre.Location = new System.Drawing.Point(125, 27);
            this.txtAlumnoNombre.Name = "txtAlumnoNombre";
            this.txtAlumnoNombre.Size = new System.Drawing.Size(230, 23);
            this.txtAlumnoNombre.TabIndex = 1;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(15, 63);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(96, 15);
            this.lblDocumento.TabIndex = 2;
            this.lblDocumento.Text = "Documento/DNI:";
            // 
            // txtAlumnoDocumento
            // 
            this.txtAlumnoDocumento.Location = new System.Drawing.Point(125, 60);
            this.txtAlumnoDocumento.Name = "txtAlumnoDocumento";
            this.txtAlumnoDocumento.Size = new System.Drawing.Size(150, 23);
            this.txtAlumnoDocumento.TabIndex = 3;
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.Location = new System.Drawing.Point(390, 30);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(112, 15);
            this.lblDevolucion.TabIndex = 4;
            this.lblDevolucion.Text = "Devolución Prevista:";
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDevolucion.Location = new System.Drawing.Point(520, 27);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(120, 23);
            this.dtpDevolucion.TabIndex = 5;
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.lblLibro);
            this.gbDetalle.Controls.Add(this.cmbLibros);
            this.gbDetalle.Controls.Add(this.lblCantidad);
            this.gbDetalle.Controls.Add(this.numCantidad);
            this.gbDetalle.Controls.Add(this.btnAgregarLinea);
            this.gbDetalle.Location = new System.Drawing.Point(20, 125);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(760, 75);
            this.gbDetalle.TabIndex = 1;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Agregar Libros al Préstamo";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(15, 30);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(95, 15);
            this.lblLibro.TabIndex = 0;
            this.lblLibro.Text = "Libro Disponible:";
            // 
            // cmbLibros
            // 
            this.cmbLibros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Location = new System.Drawing.Point(125, 27);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(330, 23);
            this.cmbLibros.TabIndex = 1;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(470, 30);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(58, 15);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(535, 28);
            this.numCantidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(60, 23);
            this.numCantidad.TabIndex = 3;
            this.numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregarLinea
            // 
            this.btnAgregarLinea.Location = new System.Drawing.Point(610, 26);
            this.btnAgregarLinea.Name = "btnAgregarLinea";
            this.btnAgregarLinea.Size = new System.Drawing.Size(120, 27);
            this.btnAgregarLinea.TabIndex = 4;
            this.btnAgregarLinea.Text = "Agregar";
            this.btnAgregarLinea.UseVisualStyleBackColor = true;
            this.btnAgregarLinea.Click += new System.EventHandler(this.BtnAgregarLinea_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(20, 215);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(760, 220);
            this.dgvDetalles.TabIndex = 2;
            // 
            // btnQuitarLinea
            // 
            this.btnQuitarLinea.Location = new System.Drawing.Point(20, 445);
            this.btnQuitarLinea.Name = "btnQuitarLinea";
            this.btnQuitarLinea.Size = new System.Drawing.Size(180, 30);
            this.btnQuitarLinea.TabIndex = 3;
            this.btnQuitarLinea.Text = "Quitar Línea Seleccionada";
            this.btnQuitarLinea.UseVisualStyleBackColor = true;
            this.btnQuitarLinea.Click += new System.EventHandler(this.BtnQuitarLinea_Click);
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalItems.Location = new System.Drawing.Point(400, 450);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(82, 15);
            this.lblTotalItems.TabIndex = 4;
            this.lblTotalItems.Text = "Total Ítems: 0";
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGrabar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGrabar.Location = new System.Drawing.Point(620, 442);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(160, 35);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar Préstamo";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // FrmNuevoPrestamo
            // 
            this.ClientSize = new System.Drawing.Size(804, 521);
            this.Controls.Add(this.gbCabecera);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnQuitarLinea);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.btnGrabar);
            this.Name = "FrmNuevoPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Nuevo Préstamo de Biblioteca";
            this.gbCabecera.ResumeLayout(false);
            this.gbCabecera.PerformLayout();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbCabecera;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtAlumnoNombre;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtAlumnoDocumento;
        private System.Windows.Forms.Label lblDevolucion;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnAgregarLinea;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnQuitarLinea;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Button btnGrabar;
    }
}