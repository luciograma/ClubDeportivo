namespace ClubDeportivo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Creamos la conexión a la base de datos
            var conexion = Datos.Conexion.getInstancia();

            Application.Run(new frmLogin());
        }
    }
}