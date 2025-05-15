using ClubDeportivo.Entidades;
using MySqlX.XDevAPI;
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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDNI.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string respuesta = "";
                bool esnumero = false;

                if (checkSocio.Checked)
                {
                    // Instancio Socio
                    E_Socio socio = new E_Socio();
                    socio.Nombre = txtNombre.Text;
                    socio.Apellido = txtApellido.Text;
                    socio.Dni = Convert.ToInt32(txtDNI.Text);
                    socio.Email = txtEmail.Text;
                    socio.FechaEmisionCarnet = DateTime.Now;

                    Datos.Socio socioDatos = new Datos.Socio();
                    respuesta = socioDatos.Nuevo_Socio(socio);
                }
                else
                {
                    // Instancio NoSocio
                    E_NoSocio noSocio = new E_NoSocio();
                    noSocio.Nombre = txtNombre.Text;
                    noSocio.Apellido = txtApellido.Text;
                    noSocio.Dni = Convert.ToInt32(txtDNI.Text);
                    noSocio.Email = txtEmail.Text;

                    Datos.NoSocio noSocioDatos = new Datos.NoSocio();
                    respuesta = noSocioDatos.Nuevo_NoSocio(noSocio);
                }

                esnumero = int.TryParse(respuesta, out int codigo);

                if (esnumero)
                {
                    if (codigo == 1)
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
                    }
                }
                else
                {
                    // Por si la respuesta no es número, podés mostrar mensaje de error
                    MessageBox.Show("Error al almacenar el cliente: " + respuesta,
                    "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

    }
}
