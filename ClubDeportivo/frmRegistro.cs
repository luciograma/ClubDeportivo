using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;

namespace ClubDeportivo
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            dateTimeApFisico.Enabled = checkSocio.Checked;
            lblSocioAptoFisico.Visible = checkSocio.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDNI.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtDNI.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser numérico.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string respuesta = "";

            if (checkSocio.Checked)
            {
                // Instancio Socio
                Socio socio = new Socio();
                socio.Nombre = txtNombre.Text;
                socio.Apellido = txtApellido.Text;
                socio.Dni = Convert.ToInt32(txtDNI.Text);
                socio.Email = txtEmail.Text;
                socio.FechaAptoFisico = dateTimeApFisico.Value;

                string resultado = socio.RegistrarCliente();
                if (int.TryParse(resultado, out int idSocio) && idSocio > 0)
                {
                    socio.IdSocio = idSocio;

                    // Registrado el socio disparo el formulario de pago de Cuota (si la cuota no se persiste, se elimina el socio para evitar el registro de un socio que no abonó su cuota)
                    frmCuota formCuota = new frmCuota(socio);
                    var dialogResult = formCuota.ShowDialog();

                    if (dialogResult == DialogResult.OK && formCuota.PagoRegistrado)
                    {
                        MessageBox.Show("Cliente y cuota registrados con éxito.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    else
                    {
                        new SocioDAO().EliminarSocio(idSocio);
                        MessageBox.Show("No se completó el pago. El cliente no fue registrado.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    respuesta = resultado; // ✅ para que se analice correctamente más abajo
                }
            }
            else
            {
                // Instancio NoSocioDAO
                NoSocio noSocio = new NoSocio();
                noSocio.Nombre = txtNombre.Text;
                noSocio.Apellido = txtApellido.Text;
                noSocio.Dni = Convert.ToInt32(txtDNI.Text);
                noSocio.Email = txtEmail.Text;

                respuesta = noSocio.RegistrarCliente();
            }

            if (int.TryParse(respuesta, out int codigo))
            {
                if (codigo == -1)
                {
                    MessageBox.Show("EL CLIENTE YA EXISTE", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Se almacenó con éxito con el código Nro " + respuesta,
                    "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al almacenar el cliente: " + respuesta,
                "AVISO DEL SISTEMA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void checkSocio_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeApFisico.Enabled = checkSocio.Checked;
            lblSocioAptoFisico.Visible = checkSocio.Checked;
        }

        private void dateTimeApFisico_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimeApFisico.Value;
            DateTime hoy = DateTime.Today;

            // Si la fecha seleccionada es anterior a hoy - 1 año
            if (fechaSeleccionada < hoy.AddYears(-1))
            {
                MessageBox.Show("La fecha debe ser menor a un año de antigüedad.", "Fecha no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Opcional: volver a poner la fecha de hoy
                dateTimeApFisico.Value = hoy;
            }
        }

    }
}
