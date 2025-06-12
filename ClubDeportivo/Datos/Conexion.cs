using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    internal class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        {

            bool correcto = false;
            int mensaje;

            //variables para recibir datos desde el teclado
            //============================
            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";

            while (correcto != true)
            {
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese servidor", "BASE DE DATOS INSTALACIÓN MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese puerto", "BASE DE DATOS INSTALACIÓN MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese usuario", "BASE DE DATOS INSTALACIÓN MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese clave", "BASE DE DATOS INSTALACIÓN MySQL");

                mensaje = (int)MessageBox.Show("Su ingreso: SERVIDOR = " + T_servidor + " - PUERTO = "
                                                + T_puerto + " - USUARIO = " + T_usuario +
                                                " - CLAVE = " + T_clave, "AVISO DEL SISTEMA",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje != 6) // correspnde al SI
                {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
            }

            this.baseDatos = "Proyecto";
            this.servidor = T_servidor;
            this.puerto = T_puerto;
            this.usuario = T_usuario;
            this.clave = T_clave;
        }

        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }


    }
}
