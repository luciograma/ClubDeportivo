using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public abstract class Cliente
    {
        private string nombre;
        private string apellido;
        private long dni;
        private string email;
        public Cliente() { }

        public Cliente(string nombre, string apellido, long dni, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;          
            Email = email;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public long Dni { get => dni; set => dni = value; }
        public string Email { get => email; set => email = value; }

        public abstract string RegistrarCliente();

    }
}
