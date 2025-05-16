using System.Data;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    internal class UsuarioDAO
    {
        // creamos un metodo que retorne una tabla con la informacion
        public DataTable Log_Usuario(string nombreUsuario, string passwordUsuario)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                
                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = nombreUsuario;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = passwordUsuario;

                // abrimos la conexion
                try {
                    sqlCon.Open();
                } catch (Exception ex) {
                    MessageBox.Show("Error al abrir la conexión: " + ex.Message);
                    return null;
                }
                resultado = comando.ExecuteReader(); // almacenamos el resulatdo en la variable
                tabla.Load(resultado); // cargamos la tabla con el  resultado
                return tabla;
                // de esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL
            }
            catch (Exception ex)
            {
                throw;
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
                ;
            }
        }

    }
}
