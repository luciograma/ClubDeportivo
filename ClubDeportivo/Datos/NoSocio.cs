using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class NoSocio
    {
        public string Nuevo_NoSocio(E_NoSocio noSocio)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoPos",
                sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("nombre", MySqlDbType.VarChar).Value =
                noSocio.Nombre;
                comando.Parameters.Add("apellido", MySqlDbType.VarChar).Value =
                noSocio.Apellido;
                comando.Parameters.Add("dni", MySqlDbType.VarChar).Value =
                noSocio.Dni;
                comando.Parameters.Add("email", MySqlDbType.Int32).Value =
                noSocio.Email;
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
