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
            btnRegistrarCliente.MouseEnter += Boton_MouseEnter;
            btnEmitirCarnet.MouseEnter += Boton_MouseEnter;
            btnExit.MouseEnter += Boton_MouseEnter;
            btnInscribirAct.MouseEnter += Boton_MouseEnter;
            btnPagarCuota.MouseEnter += Boton_MouseEnter;
        }

        internal string? rol;
        internal string? usuario;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario;           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();
            this.Hide();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {

        }

        private void btnInscribirAct_Click(object sender, EventArgs e)
        {

        }

        private void Boton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.Focus();
            }
        }
    }
}
