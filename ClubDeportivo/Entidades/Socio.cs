using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ClubDeportivo.Entidades
{
    public class Socio : Cliente
    {
        private long idSocio;
        private DateTime fechaEmisionCarnet;
        private DateTime fechaAptoFisico;

        public Socio() { }

        public Socio(long idSocio, string nombre, string apellido, long dni, string email, DateTime fechaEmisionCarnet, DateTime fechaAptoFisico) : base(nombre, apellido, dni, email)
        {
            IdSocio = idSocio;
            FechaEmisionCarnet = fechaEmisionCarnet;
            this.fechaAptoFisico = fechaAptoFisico;
        }

        public long IdSocio { get => idSocio; set => idSocio = value; }
        public DateTime FechaEmisionCarnet { get => fechaEmisionCarnet; set => fechaEmisionCarnet = value; }
        public DateTime FechaAptoFisico { get => fechaAptoFisico; set => fechaAptoFisico = value; }
        public override string RegistrarCliente()
        {
            //Emito fecha de carnet
            this.EmitirCarnet();

            //Intento persistir el socio en la base de datos
            SocioDAO dao = new SocioDAO();
            string resultado = dao.Alta_Socio(this);

            return resultado;
        }

        public bool BajaSocio() {
            return true;
        }

        public void EmitirCarnet() {
            this.FechaEmisionCarnet = DateTime.Now; ;
        }

        public bool AbonarCuota() {
            return true; 
        }

        public override string ToString() {
            return "[nroSocio: " + idSocio + ", fechaEmisionCarnet: " + fechaEmisionCarnet + "]";
        }
    }
}
