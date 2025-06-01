using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace ClubDeportivo.Datos
{
    internal class CuotaDAO
    {
        public string RegistrarCuota(Cuota cuota)
        {
            string salida;
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();

            try
            {
                MySqlCommand comando = new MySqlCommand("RegistrarCuota", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idSocio", MySqlDbType.Int32).Value = cuota.Socio.IdSocio;
                comando.Parameters.Add("fechaVencimiento", MySqlDbType.Date).Value = cuota.FechaVencimiento;
                comando.Parameters.Add("monto", MySqlDbType.Double).Value = cuota.Monto;
                comando.Parameters.Add("medioPago", MySqlDbType.VarChar).Value = cuota.MedioPago;
                comando.Parameters.Add("cuotasTarjeta", MySqlDbType.Int32).Value = cuota.CuotasTarjeta;
                foreach (MySqlParameter param in comando.Parameters)
                {
                    Debug.WriteLine($"Param: {param.ParameterName} = {param.Value}");
                }
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = "OK";
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return salida;
        }

        public DataTable ListarVencimientos()
        {
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("ListarVencimientosDelDia", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                MySqlDataReader resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar vencimientos: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
        }


    }
}
