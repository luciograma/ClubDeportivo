using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmInscripcionActividad : Form
    {
        public frmInscripcionActividad()
        {
            InitializeComponent();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click_1(object sender, EventArgs e)
        //{

        //}

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

            // Validación de número de cliente
            if (!int.TryParse(txtNroNoSocio.Text, out int nroNoSocio))
            {
                MostrarError("Ingrese un número de cliente válido.");
                return;
            }


            // Buscar cliente
            NoSocio noSocio = new NoSocioDAO().ObtenerNoSocioPorId(nroNoSocio);
            if (noSocio == null)
            {
                MostrarError("No existe ese Nro. de Cliente, por favor ingrese uno correcto.");
                return;
            }

            object selected = cmbActividades.SelectedValue;
            if (selected == null || !int.TryParse(selected.ToString(), out int actividadId) || actividadId == 0)
            {
                MostrarError("Debe seleccionar una actividad válida.");
                return;
            }
            //valido si hay cupo disponible
            if (!new ActividadDAO().HayCupoDisponible(actividadId))
            {
                MostrarError("No hay cupo disponible para esta actividad.");
                return;
            }


            // Crear pago/inscripcion
            PagoActividad pagoActividad = new PagoActividad
            {
                NoSocioId = nroNoSocio,
                ActividadId = actividadId,
                FechaDePago = DateTime.Now
            };

            // Inscripción 
            bool resultado = pagoActividad.InscribirActividad();
            if (resultado)
            {
                MessageBox.Show("Se almacenó con éxito el pago.", "AVISO DEL SISTEMA",
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
            if (string.IsNullOrWhiteSpace(txtNroNoSocio.Text))
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
    }
}
