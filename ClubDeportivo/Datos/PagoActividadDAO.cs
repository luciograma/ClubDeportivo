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
    internal class PagoActividadDAO
    {
        public string InscribirActividad(PagoActividad pagoActividad)
        {
            string salida;
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();

            try
            {
                MySqlCommand comando = new MySqlCommand("InscribirActividad", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idNoSocio", MySqlDbType.Int32).Value = pagoActividad.NoSocioId;
                comando.Parameters.Add("idActividad", MySqlDbType.Int32).Value = pagoActividad.ActividadId;
                comando.Parameters.Add("fechaDePago", MySqlDbType.Date).Value = pagoActividad.FechaDePago;
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
