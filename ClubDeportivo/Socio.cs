using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ClubDeportivo
{
    public class Socio : Persona
    {
        private long nroSocio;
        private DateTime fechaEmisionCarnet;

        public Socio() { }

        public Socio(string nombre, string apellido, long dni, string direccion, string email, string telefono, long nroSocio, DateTime fechaEmisionCarnet) : base(nombre, apellido, dni, direccion, email, telefono)
        {
            this.NroSocio = nroSocio;
            this.FechaEmisionCarnet = fechaEmisionCarnet;
        }

        public long NroSocio { get => nroSocio; set => nroSocio = value; }
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

        public override void RegistrarPersona(){
            this.AltaSocio();
        }

        public override string ToString() {
            return "[nroSocio: " + nroSocio + ", fechaEmisionCarnet: " + fechaEmisionCarnet + "]";
        }
    }
}
