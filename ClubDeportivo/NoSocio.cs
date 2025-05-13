using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class NoSocio: Cliente
    {
        public NoSocio() { }

        public bool InscribirActividad()
        {
            return true;
        }
        public override void RegistrarCliente()
        {
            this.InscribirActividad();
        }
    }
}
