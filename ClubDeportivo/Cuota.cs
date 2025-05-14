using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    public class Cuota
    {
        private long id;
        private Socio socio;
        private DateTime fechaVencimiento;
        private double monto;
        private string medioPago;
        private int cuotasTarjeta;

        public Cuota() { }
        public Cuota(long id,  Socio socio, DateTime fechaVencimiento, double monto, string medioPago, int cuotasTarjeta)
        {
            this.Id = id;
            this.Socio = socio;
            this.FechaVencimiento = fechaVencimiento;
            this.Monto = monto;
            this.MedioPago = medioPago;
            this.CuotasTarjeta = cuotasTarjeta;
        }
        public long Id { get => id; set => id = value; }
        public Socio Socio { get => socio; set => socio = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public double Monto { get => monto; set => monto = value; }
        public string MedioPago { get => medioPago; set => medioPago = value; }
        public int CuotasTarjeta { get => cuotasTarjeta; set => cuotasTarjeta = value; }

        public bool RegistrarCuota() { return true; }
        public bool ActualizarCuota() { return true; }
        public DateTime CalcularVencimiento() { return FechaVencimiento; }
    }
}
