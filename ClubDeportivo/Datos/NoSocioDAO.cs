using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace ClubDeportivo.Datos
{
    internal class NoSocioDAO
    {
        public string Alta_NoSocio(NoSocio noSocio)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("AltaNoSocio",sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("nombre", MySqlDbType.VarChar).Value =  noSocio.Nombre;
                comando.Parameters.Add("apellido", MySqlDbType.VarChar).Value = noSocio.Apellido;
                comando.Parameters.Add("dni", MySqlDbType.Int32).Value =  noSocio.Dni;
                comando.Parameters.Add("email", MySqlDbType.VarChar).Value = noSocio.Email;
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
                ;
            }
            return salida;
        }
    }
}
