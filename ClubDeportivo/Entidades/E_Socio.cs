using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ClubDeportivo.Entidades
{
    public class E_Socio : E_Cliente
    {
        private long idSocio;
        private DateTime fechaEmisionCarnet;

        public E_Socio() { }

        public E_Socio(long idSocio, string nombre, string apellido, long dni, string email, long nroSocio, DateTime fechaEmisionCarnet) : base(idSocio, nombre, apellido, dni, email)
        {
            IdSocio = idSocio;
            FechaEmisionCarnet = fechaEmisionCarnet;
        }

        public long IdSocio { get => idSocio; set => idSocio = value; }
        public DateTime FechaEmisionCarnet { get => fechaEmisionCarnet; set => fechaEmisionCarnet = value; }

        public bool AltaSocio() {
            return true;
        }

        public bool BajaSocio() {
            return true;
        }

        public bool EmitirCarnet() {
            return true;
        }

        public bool AbonarCuota() {
            return true; 
        }

        public override void RegistrarCliente(){
            AltaSocio();
        }

        public override string ToString() {
            return "[nroSocio: " + idSocio + ", fechaEmisionCarnet: " + fechaEmisionCarnet + "]";
        }
    }
}
