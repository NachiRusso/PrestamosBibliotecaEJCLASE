namespace PrestamosBiblioteca.Vista
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Aquí se reemplaza Form1 por el formulario principal de tu proyecto
            Application.Run(new FrmPrincipal());
        }
    }
}