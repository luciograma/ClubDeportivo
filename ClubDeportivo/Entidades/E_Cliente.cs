using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public abstract class E_Cliente
    {
        private long id;
        private string nombre;
        private string apellido;
        private long dni;
        private string email;
        public E_Cliente() { }

        public E_Cliente(long id, string nombre, string apellido, long dni, string email)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;          
            Email = email;
        }

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public long Dni { get => dni; set => dni = value; }
        public string Email { get => email; set => email = value; }

        public abstract void RegistrarCliente();

    }
}
