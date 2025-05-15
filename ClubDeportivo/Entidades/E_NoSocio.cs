using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_NoSocio: E_Cliente
    {
        private long idNoSocio;
        public E_NoSocio() { }

        public E_NoSocio(long idNoSocio) 
        {
            this.idNoSocio = idNoSocio;
        }
        public bool InscribirActividad()
        {
            return true;
        }
        public override void RegistrarCliente()
        {
            InscribirActividad();
        }
    }
}
