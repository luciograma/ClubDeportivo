using ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class Cuota
    {
        private long idCuota;
        private Socio socio;
        private DateTime fechaVencimiento;
        private double monto;
        private string medioPago;
        private int cuotasTarjeta;

        public Cuota() { }
        public Cuota(long id,  Socio socio, DateTime fechaVencimiento, double monto, string medioPago, int cuotasTarjeta)
        {
            Id = id;
            Socio = socio;
            FechaVencimiento = fechaVencimiento;
            Monto = monto;
            MedioPago = medioPago;
            CuotasTarjeta = cuotasTarjeta;
        }
        public long Id { get => idCuota; set => idCuota = value; }
        public Socio Socio { get => socio; set => socio = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public double Monto { get => monto; set => monto = value; }
        public string MedioPago { get => medioPago; set => medioPago = value; }
        public int CuotasTarjeta { get => cuotasTarjeta; set => cuotasTarjeta = value; }

        public bool RegistrarCuota()
        {
            CuotaDAO dao = new CuotaDAO();
            string resultado = dao.RegistrarCuota(this);
            
            if (resultado == "OK")
                return true;
            else
            {
                MessageBox.Show("Error al registrar cuota: " + resultado, "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ActualizarCuota() { return true; }
        public DateTime CalcularVencimiento() { return FechaVencimiento; }
    }
}
