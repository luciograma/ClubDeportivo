using ClubDeportivo.Datos;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClubDeportivo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnIngresar.MouseEnter += Boton_MouseEnter;
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando llega el foco */
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando se va el foco */
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.UsuarioDAO dato = new Datos.UsuarioDAO(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usuario(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // ____ quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE ___
                // _____ informamos con un mensaje al usuario _____
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*
                __________________________________________________________
                ___________________
                una vez que tenemos la conexion establecida PASAMOS al
                formulario PRINCIPAL
                Se debe "Instanciar" un objeto de la clase formulario
                principal
                ___________________________________________________________________________
                _______ */
                frmPrincipal Principal = new frmPrincipal();
                /*
                _________________________________________________________
                ___________
                * la siguiente linea permite tomar el dominio de la
                primera columna
                * de la primera fila del resultado de la ejecucion de la
                query
                *
                ________________________________________________________
                ____________ */
                // Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                Principal.usuario = Convert.ToString(txtUsuario.Text);
                Principal.Show(); // se llama al formulario principal
                this.Hide(); // se oculta el formulario del login
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }

        private void Boton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.Focus();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
