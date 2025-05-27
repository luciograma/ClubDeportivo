using ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class PagoActividad
    {
        private long id;
        private long noSocioId;
        private long actividadId;
        private DateTime fechaDePago;

        public PagoActividad() { }
        public PagoActividad(long id, long noSocioId, long actividadId, DateTime fechaDePago)
        {
            Id = id;
            NoSocioId = noSocioId;
            ActividadId = actividadId;
            FechaDePago = fechaDePago;
        }

        public long Id { get { return id; } set { id = value; } }
        public long NoSocioId { get { return noSocioId; } set { noSocioId = value; } }
        public long ActividadId { get { return actividadId; } set { actividadId = value; } }
        public DateTime FechaDePago { get { return fechaDePago; } set { fechaDePago = value; } }

        public bool InscribirActividad()
        {
            PagoActividadDAO dao = new PagoActividadDAO();
            string resultado = dao.InscribirActividad(this);

            if (resultado == "OK")
                return true;
            else
            {
                MessageBox.Show("Error al registrar pago de actividad: " + resultado, "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }
    }
}
