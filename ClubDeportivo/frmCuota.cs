using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using System.Drawing.Printing;

namespace ClubDeportivo
{
    public partial class frmCuota : Form
    {

        private Socio? socio;
        public bool PagoRegistrado { get; private set; } = false;


        public frmCuota()
        {
            InitializeComponent();
        }

        public frmCuota(Socio socio)
        {
            InitializeComponent();
            this.socio = socio;
        }

        private void formCuota_Load(object sender, EventArgs e)
        {
            if (socio != null)
            {
                txtNroSocio.Text = socio.IdSocio.ToString();
                txtNroSocio.Enabled = false;
                lblNroSocio.Visible = false;
            }

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
            long idSocio;

            if (this.socio != null)
            {
                idSocio = this.socio.IdSocio;
            }
            else if (!long.TryParse(txtNroSocio.Text, out idSocio))
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
            if (esTarjeta && !int.TryParse(txtCantCuotas.Text, out cuotas))
            {
                MostrarError("Ingrese una cantidad de cuotas válida.");
                return;
            }

            // Buscar socio
            Socio socio;
            if (this.socio == null)
            {
                try
                {
                    socio = new SocioDAO().ObtenerSocioPorId(idSocio);
                    if (socio == null)
                    {
                        MostrarError("No existe ese Nro. de Socio, por favor ingrese uno correcto.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MostrarError("Error al buscar socio: " + ex.Message);
                    return;
                }
            }
            else
            {
                socio = this.socio;
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
                this.PagoRegistrado = true;
                MessageBox.Show("Se almacenó con éxito la cuota.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                EmitirCarnet(socio, cuota);
                this.Close();
            }
            else
            {
                MostrarError("Hubo un error al registrar el pago.");
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

        private void EmitirCarnet(Socio socio, Cuota cuota)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += (sender, e) => ImprimirCarnet(e, socio, cuota);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = doc;

            preview.ShowDialog();
        }

        private void ImprimirCarnet(PrintPageEventArgs e, Socio socio, Cuota cuota)
        {
            string nombreSistema = "CLUB DEPORTIVO";
            string titulo = "CARNET DE SOCIO";

            string cliente = $"{socio.Apellido}, {socio.Nombre}";
            string nroSocio = $"Nro Socio: {socio.IdSocio}";
            string fechaEmision = $"Emitido: {socio.FechaEmisionCarnet:dd/MM/yyyy}";
            string vencimiento = $"Válido hasta: {cuota.FechaVencimiento:dd/MM/yyyy}";
            string monto = $"Monto: ${cuota.Monto:N2}";
            string pago = $"Pago: {cuota.MedioPago}";

            Font fuenteNormal = new Font("Courier New", 10, FontStyle.Regular);
            Font fuenteTitulo = new Font("Courier New", 12, FontStyle.Bold);
            Font fuenteSistema = new Font("Courier New", 14, FontStyle.Bold);

            int y = 20;
            int espacio = 20;
            int anchoPagina = e.PageBounds.Width;

            void DrawCentered(string texto, Font fuente, int yPos)
            {
                SizeF size = e.Graphics.MeasureString(texto, fuente);
                float x = (anchoPagina - size.Width) / 2;
                e.Graphics.DrawString(texto, fuente, Brushes.Black, x, yPos);
            }

            // Encabezado
            DrawCentered(nombreSistema, fuenteSistema, y); y += espacio * 2;
            DrawCentered(titulo, fuenteTitulo, y); y += espacio * 2;

            // Datos del carnet
            e.Graphics.DrawString($"Nombre: {cliente}", fuenteNormal, Brushes.Black, 20, y); y += espacio;
            e.Graphics.DrawString(nroSocio, fuenteNormal, Brushes.Black, 20, y); y += espacio;
            e.Graphics.DrawString(fechaEmision, fuenteNormal, Brushes.Black, 20, y); y += espacio;
            e.Graphics.DrawString(vencimiento, fuenteNormal, Brushes.Black, 20, y); y += espacio;
            e.Graphics.DrawString(monto, fuenteNormal, Brushes.Black, 20, y); y += espacio;
            e.Graphics.DrawString(pago, fuenteNormal, Brushes.Black, 20, y); y += espacio * 2;

            DrawCentered("¡Gracias por ser parte!", fuenteNormal, y);
        }


    }
}
