namespace PrestamosBiblioteca.Vista
{
    partial class FrmPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGestionLibros = new System.Windows.Forms.Button();
            this.btnNuevoPrestamo = new System.Windows.Forms.Button();
            this.btnConsultaPrestamos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(130, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Biblioteca Escolar";
            // 
            // btnGestionLibros
            // 
            this.btnGestionLibros.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGestionLibros.Location = new System.Drawing.Point(100, 90);
            this.btnGestionLibros.Name = "btnGestionLibros";
            this.btnGestionLibros.Size = new System.Drawing.Size(280, 45);
            this.btnGestionLibros.TabIndex = 1;
            this.btnGestionLibros.Text = "Catálogo / ABM de Libros";
            this.btnGestionLibros.UseVisualStyleBackColor = true;
            this.btnGestionLibros.Click += new System.EventHandler(this.BtnGestionLibros_Click);
            // 
            // btnNuevoPrestamo
            // 
            this.btnNuevoPrestamo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNuevoPrestamo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoPrestamo.Location = new System.Drawing.Point(100, 150);
            this.btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            this.btnNuevoPrestamo.Size = new System.Drawing.Size(280, 45);
            this.btnNuevoPrestamo.TabIndex = 2;
            this.btnNuevoPrestamo.Text = "Registrar Nuevo Préstamo";
            this.btnNuevoPrestamo.UseVisualStyleBackColor = false;
            this.btnNuevoPrestamo.Click += new System.EventHandler(this.BtnNuevoPrestamo_Click);
            // 
            // btnConsultaPrestamos
            // 
            this.btnConsultaPrestamos.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultaPrestamos.Location = new System.Drawing.Point(100, 210);
            this.btnConsultaPrestamos.Name = "btnConsultaPrestamos";
            this.btnConsultaPrestamos.Size = new System.Drawing.Size(280, 45);
            this.btnConsultaPrestamos.TabIndex = 3;
            this.btnConsultaPrestamos.Text = "Consultar Préstamos Registrados";
            this.btnConsultaPrestamos.UseVisualStyleBackColor = true;
            this.btnConsultaPrestamos.Click += new System.EventHandler(this.BtnConsultaPrestamos_Click);
            // 
            // FrmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnGestionLibros);
            this.Controls.Add(this.btnNuevoPrestamo);
            this.Controls.Add(this.btnConsultaPrestamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Préstamos - Biblioteca Escolar";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGestionLibros;
        private System.Windows.Forms.Button btnNuevoPrestamo;
        private System.Windows.Forms.Button btnConsultaPrestamos;
    }
}