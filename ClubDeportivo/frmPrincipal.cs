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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            RegistrarBoton(btnRegistrarCliente);
            RegistrarBoton(btnListarVencimientos);
            RegistrarBoton(btnExit);
            RegistrarBoton(btnInscribirActividad);
            RegistrarBoton(btnPagarCuota);
        }

        internal string? rol;
        internal string? usuario;
        Dictionary<Button, Color> coloresOriginales = new Dictionary<Button, Color>();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {}

        private void RegistrarBoton(Button boton)
        {
            coloresOriginales[boton] = boton.BackColor;
            boton.MouseEnter += Boton_MouseEnter;
            boton.MouseLeave += Boton_MouseLeave;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.StartPosition = FormStartPosition.CenterParent;
            registro.Show();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            frmCuota cuotaPopUp = new frmCuota();
            cuotaPopUp.StartPosition = FormStartPosition.CenterParent;
            cuotaPopUp.Show();
        }

        private void btnInscribirAct_Click(object sender, EventArgs e)
        {
            // Funcionalidad pendiente
        }

        private void btnEmitirCarnet_Click(object sender, EventArgs e)
        {
            // Funcionalidad pendiente (en realidad: listar vencimientos)
        }

        private void Boton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.LightGray; // o cualquier color que prefieras
                btn.Focus();
            }
        }

        private void Boton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && coloresOriginales.ContainsKey(btn))
            {
                btn.BackColor = coloresOriginales[btn];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
