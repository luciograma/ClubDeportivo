using ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class NoSocio: Cliente
    {
        private long idNoSocio;
        public NoSocio() { }

        public NoSocio(long idNoSocio) 
        {
            this.idNoSocio = idNoSocio;
        }
        public bool InscribirActividad()
        {
            return true;
        }
        public override string RegistrarCliente()
        {
            NoSocioDAO dao = new NoSocioDAO();
            return dao.Alta_NoSocio(this);
        }

    }
}
