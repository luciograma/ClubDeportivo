using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace ClubDeportivo.Datos
{
    internal class ActividadDAO
    {
        public List<Actividad> GetActividadesLista()
        {
            List<Actividad> lista = new List<Actividad>();

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                using (MySqlCommand comando = new MySqlCommand("GetActividades", sqlCon))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    sqlCon.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Actividad actividad = new Actividad()
                            {
                                Id = reader.GetInt32("idActividad"),
                                Nombre = reader.GetString("nombre"),
                                Precio = reader.GetDouble("precio"),
                                Cupo = reader.GetInt32("cupo")
                            };

                            lista.Add(actividad);
                        }
                    }
                }
            }

            return lista;
        }

        public bool HayCupoDisponible(int actividadId)
        {
            bool hayCupo = false;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand cmd = new MySqlCommand("HayCupoDisponible", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_idActividad", actividadId);
                MySqlParameter outputParam = new MySqlParameter("p_hayCupo", MySqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                sqlCon.Open();
                cmd.ExecuteNonQuery();

                hayCupo = !(outputParam.Value is DBNull) && Convert.ToBoolean(outputParam.Value);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar cupo: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return hayCupo;
        }
    }
}
