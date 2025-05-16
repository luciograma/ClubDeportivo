using ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ClubDeportivo.Entidades
{
    public class Socio : Cliente
    {
        private long idSocio;
        private DateTime fechaEmisionCarnet;

        public Socio() { }

        public Socio(long idSocio, string nombre, string apellido, long dni, string email, long nroSocio, DateTime fechaEmisionCarnet) : base(nombre, apellido, dni, email)
        {
            IdSocio = idSocio;
            FechaEmisionCarnet = fechaEmisionCarnet;
        }

        public long IdSocio { get => idSocio; set => idSocio = value; }
        public DateTime FechaEmisionCarnet { get => fechaEmisionCarnet; set => fechaEmisionCarnet = value; }

        public override string RegistrarCliente()
        {
            //Emito fecha de carnet
            this.EmitirCarnet();

            //Intento persistir el socio en la base de datos
            SocioDAO dao = new SocioDAO();
            string resultado = dao.Alta_Socio(this);

            if (int.TryParse(resultado, out int idGenerado) && idGenerado > 0)
            {
                this.IdSocio = idGenerado;

                //Dejo registro de la cuota abonada por el socio
                Cuota cuotaInicial = new Cuota
                {
                    Socio = this,
                    FechaVencimiento = DateTime.Now.AddMonths(1),
                    Monto = 10000,
                    MedioPago = "efectivo",
                    CuotasTarjeta = 0
                };

                cuotaInicial.RegistrarCuota();
            }

            return resultado;
        }

        public bool BajaSocio() {
            return true;
        }

        public void EmitirCarnet() {
            this.FechaEmisionCarnet = DateTime.Now; ;
        }

        public bool AbonarCuota() {
            return true; 
        }

        public override string ToString() {
            return "[nroSocio: " + idSocio + ", fechaEmisionCarnet: " + fechaEmisionCarnet + "]";
        }
    }
}
