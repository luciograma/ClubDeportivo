using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using System.Drawing.Printing;

namespace ClubDeportivo
{
    public partial class frmInscripcionActividad : Form
    {
        public frmInscripcionActividad()
        {
            InitializeComponent();
        }

        private void frmInscripcionActividad_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener la lista de actividades desde la BD
                List<Actividad> lista = Actividad.ObtenerActividades();

                lista.Insert(0, new Actividad { Id = 0, Nombre = "--Seleccione una actividad--" });

                cmbActividades.DataSource = lista;

                cmbActividades.DisplayMember = "Nombre";

                cmbActividades.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las actividades: " + ex.Message);
            }
        }

        private void cmbActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbActividades.SelectedItem != null)
            {
                btnPagarAct.Enabled = true;
                Actividad actividadSeleccionada = (Actividad)cmbActividades.SelectedItem;

                if (actividadSeleccionada.Precio != null)
                {
                    txtMontoAct.Text = actividadSeleccionada.Precio.ToString("F2");
                }
                else
                {
                    txtMontoAct.Text = "0.00";
                }
                bool hayCupo = new ActividadDAO().HayCupoDisponible((int)actividadSeleccionada.Id);

                lblCupo.Text = $"Cupo total: {actividadSeleccionada.Cupo} - {(hayCupo ? "Hay cupo disponible" : "No hay cupo")}";
                lblCupo.ForeColor = hayCupo ? Color.White : Color.Red;
                lblCupo.Visible = true;
                btnPagarAct.Enabled = hayCupo ? true : false;
            }
            else
            {
                lblCupo.Text = "";
                lblCupo.Visible = false;
                btnPagarAct.Enabled = false;
            }
        }

        private void btnPagarAct_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;


            // Validación de DNI
            if (!int.TryParse(txtDniNoSocio.Text, out int dniNoSocio))
            {
                MostrarError("Ingrese un DNI válido.");
                return;
            }

            // Buscar cliente
            NoSocio noSocio = new NoSocioDAO().ObtenerNoSocioPorDni(dniNoSocio);
            if (noSocio == null)
            {
                MostrarError("No existen registro para ese DNI, por favor complete el alta del cliente y pruebe nuevamente.");
                return;
            }

            Actividad actividad = cmbActividades.SelectedItem as Actividad;
            if (actividad == null || actividad.Id == 0)
            {
                MostrarError("Debe seleccionar una actividad válida.");
                return;
            }
            //valido si hay cupo disponible
            if (!new ActividadDAO().HayCupoDisponible((int)actividad.Id))
            {
                MostrarError("No hay cupo disponible para esta actividad.");
                return;
            }


            // Crear pago/inscripcion
            PagoActividad pagoActividad = new PagoActividad
            {
                NoSocioId = noSocio.IdNoSocio,
                ActividadId = actividad.Id,
                FechaDePago = DateTime.Now
            };

            // Inscripción 
            string resultado = pagoActividad.InscribirActividad();
            if (resultado == "OK")
            {
                MessageBox.Show("Se realizó con éxito la inscripción", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mensaje para imprimir comprobante
                DialogResult impresion = MessageBox.Show(
                    "¿Desea imprimir el comprobante de inscripción?",
                    "Comprobante",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
        );

                if (impresion == DialogResult.Yes)
                {
                    GenerarComprobante(noSocio, actividad);
                }
                else
                {
                    LimpiarFormulario();
                }
            }
            else
            {
                MostrarError("Hubo un error al realizar la inscripción: " + resultado);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDniNoSocio.Text))
            {
                MostrarError("Debe ingresar el número de no socio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMontoAct.Text) || txtMontoAct.Text == "0.00")
            {
                MostrarError("Debe ingresar un monto válido.");
                return false;
            }

            if (cmbActividades.SelectedIndex < 0)
            {
                MostrarError("Debe seleccionar una actividad.");
                return false;
            }

            return true;
        }


        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarComprobante(NoSocio noSocio, Actividad actividad)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += (sender, e) => ImprimirComprobante(e, noSocio, actividad);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = doc;

            //limpiar formulario
            preview.FormClosed += (s, e) => LimpiarFormulario();
            preview.ShowDialog();
        }

        private void ImprimirComprobante(PrintPageEventArgs e, NoSocio noSocio, Actividad actividad)
        {

            string nombreSistema = "CLUB DEPORTIVO";
            string cliente = $"{noSocio.Apellido}, {noSocio.Nombre}";
            string actividadNombre = actividad.Nombre;
            string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            string monto = $"${actividad.Precio:N2}";

            Font fuenteTicket = new Font("Courier New", 10, FontStyle.Regular);
            Font fuenteTitulo = new Font("Courier New", 12, FontStyle.Bold);
            Font fuenteSistema = new Font("Courier New", 14, FontStyle.Bold);

            int y = 20;
            int espacio = 18;
            int anchoPagina = e.PageBounds.Width;

            // Centrar texto
            void DrawCentered(string texto, Font fuente, int yPos)
            {
                SizeF size = e.Graphics.MeasureString(texto, fuente);
                float x = (anchoPagina - size.Width) / 2;
                e.Graphics.DrawString(texto, fuente, Brushes.Black, x, yPos);
            }

            // Imprimir encabezado
            DrawCentered(nombreSistema, fuenteSistema, y);
            y += espacio * 2;

            DrawCentered("COMPROBANTE DE INSCRIPCIÓN", fuenteTitulo, y);
            y += espacio * 2;

            // Imprimir datos en columnas
            e.Graphics.DrawString($"Cliente: {cliente}", fuenteTicket, Brushes.Black, 20, y); y += espacio;
            e.Graphics.DrawString($"Actividad: {actividadNombre}", fuenteTicket, Brushes.Black, 20, y); y += espacio;
            e.Graphics.DrawString($"Fecha: {fecha}", fuenteTicket, Brushes.Black, 20, y); y += espacio;

            e.Graphics.DrawString("------------------------------------", fuenteTicket, Brushes.Black, 20, y);
            y += espacio;

            string labelMonto = "Monto abonado:";
            string valorMonto = monto;

            SizeF sizeLabel = e.Graphics.MeasureString(labelMonto, fuenteTicket);
            SizeF sizeValor = e.Graphics.MeasureString(valorMonto, fuenteTicket);

            float posLabel = 20;
            float posValor = anchoPagina - sizeValor.Width - 20;

            e.Graphics.DrawString(labelMonto, fuenteTicket, Brushes.Black, posLabel, y);
            e.Graphics.DrawString(valorMonto, fuenteTicket, Brushes.Black, posValor, y);

            y += espacio * 2;

            DrawCentered("¡Gracias por su inscripción!", fuenteTicket, y);
        }

        private void LimpiarFormulario()
        {
            txtDniNoSocio.Clear();
            txtMontoAct.Clear();
            cmbActividades.SelectedIndex = 0;
            lblCupo.Text = "";
            lblCupo.Visible = false;
            btnPagarAct.Enabled = false;
        }

    }
}
