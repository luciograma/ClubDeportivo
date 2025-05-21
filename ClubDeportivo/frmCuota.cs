using ClubDeportivo.Entidades;
using Org.BouncyCastle.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmCuota : Form
    {
        public frmCuota()
        {
            InitializeComponent();
        }

        private void formCuota_Load(object sender, EventArgs e)
        {
            selectMDPago_SelectedIndexChanged(null, null);
        }

        private void txtTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCampos_Click(object sender, EventArgs e)
        {

        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            // Validación de número de socio
            if (!int.TryParse(txtNroSocio.Text, out int nroSocio))
            {
                MostrarError("Ingrese un número de socio válido.");
                return;
            }

            // Validación de monto
            if (!double.TryParse(txtMontoCuota.Text, out double monto))
            {
                MostrarError("Ingrese un monto válido.");
                return;
            }

            // Determinar si el medio de pago es tarjeta y validar cuotas
            int cuotas = 0;
            bool esTarjeta = selectMDPago.Text.Equals("Tarjeta de Credito", StringComparison.OrdinalIgnoreCase);
            if (esTarjeta)
            {
                if (!int.TryParse(txtCantCuotas.Text, out cuotas))
                {
                    MostrarError("Ingrese una cantidad de cuotas válida.");
                    return;
                }
            }

            // Buscar socio
            Socio socio = new Socio().ObtenerSocioPorId(nroSocio);
            if (socio == null)
            {
                MostrarError("No existe ese Nro. de Socio, por favor ingrese uno correcto.");
                return;
            }

            // Crear cuota
            Cuota cuota = new Cuota
            {
                Socio = socio,
                Monto = monto,
                MedioPago = selectMDPago.Text,
                CuotasTarjeta = cuotas,
                FechaVencimiento = DateTime.Now.AddMonths(1)
            };

            // Registrar cuota
            bool resultado = cuota.RegistrarCuota();
            if (resultado)
            {
                MessageBox.Show("Se almacenó con éxito la cuota.", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MostrarError("Hubo un error al registrar el pago: " + resultado);
            }
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNroSocio.Text) ||
                string.IsNullOrWhiteSpace(txtMontoCuota.Text) ||
                string.IsNullOrWhiteSpace(selectMDPago.Text))
            {
                MostrarError("Debe completar todos los campos requeridos (*)");
                return false;
            }

            if (selectMDPago.Text == "Tarjeta de crédito")
            {
                if (string.IsNullOrWhiteSpace(txtCantCuotas.Text))
                {
                    MostrarError("Debe ingresar la cantidad de cuotas.");
                    return false;
                }
            }

            return true;
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void selectMDPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            string medioPago = selectMDPago.Text.Trim().ToLower();
            bool esTarjeta = medioPago.Contains("tarjeta");


            txtCantCuotas.Enabled = esTarjeta;

            if (!esTarjeta)
            {
                txtCantCuotas.Clear();
            }
        }


    }
}
