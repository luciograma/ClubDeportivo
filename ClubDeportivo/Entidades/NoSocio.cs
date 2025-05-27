using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        public long IdNoSocio { get => idNoSocio; set => idNoSocio = value; }

        public override string RegistrarCliente()
        {
            NoSocioDAO dao = new NoSocioDAO();
            return dao.Alta_NoSocio(this);
        }

    }
}
