using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class Actividad
    {
        private long id;
        private string nombre;
        private double precio;
        private long cupo;
        private string horario;

        public Actividad() { }

        public Actividad(long id, string nombre, double precio, long cupo, string horario)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.cupo = cupo;
            this.horario = horario;
        }

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public long Cupo { get => cupo; set => cupo = value; }
        public string Horario { get => horario; set => horario = value; }

        public bool CrearActividad()
        { return true; }
        public bool ActualizarActividad()
        { return true; }
        public bool VerificarCupo()
        { return true; }
    }
}
