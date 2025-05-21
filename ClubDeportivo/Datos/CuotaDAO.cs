using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
