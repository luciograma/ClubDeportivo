﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    public abstract class Cliente
    {
        private string nombre;
        private string apellido;
        private long dni;
        private string direccion;
        private string email;
        private string telefono;

        public Cliente() { }

        public Cliente(string nombre, string apellido, long dni, string direccion, string email, string telefono)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Direccion = direccion;
            this.Email = email;
            this.Telefono = telefono;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public long Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public abstract void RegistrarCliente();

    }
}
