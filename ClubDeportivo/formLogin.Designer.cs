using ClubDeportivo.Datos;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

namespace ClubDeportivo
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            textUsuario = new TextBox();
            textPassword = new TextBox();
            btnIngresar = new Button();
            imagenLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imagenLogin).BeginInit();
            SuspendLayout();
            // 
            // textUsuario
            // 
            textUsuario.ForeColor = SystemColors.GrayText;
            textUsuario.Location = new Point(414, 112);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(216, 27);
            textUsuario.TabIndex = 0;
            textUsuario.Text = "USUARIO";
            // 
            // textPassword
            // 
            textPassword.ForeColor = SystemColors.GrayText;
            textPassword.Location = new Point(414, 187);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(216, 27);
            textPassword.TabIndex = 1;
            textPassword.Text = "CONTRASEÑA";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.RoyalBlue;
            btnIngresar.FlatAppearance.BorderColor = Color.LightGray;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(414, 285);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(216, 66);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // imagenLogin
            // 
            imagenLogin.AccessibleDescription = "Imagen Login";
            imagenLogin.BackColor = SystemColors.ControlDark;
            imagenLogin.BackgroundImageLayout = ImageLayout.Stretch;
            imagenLogin.Image = (Image)resources.GetObject("imagenLogin.Image");
            imagenLogin.Location = new Point(95, 94);
            imagenLogin.Name = "imagenLogin";
            imagenLogin.Size = new Size(228, 257);
            imagenLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenLogin.TabIndex = 3;
            imagenLogin.TabStop = false;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(imagenLogin);
            Controls.Add(btnIngresar);
            Controls.Add(textPassword);
            Controls.Add(textUsuario);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)imagenLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsuario;
        private TextBox textPassword;
        private Button btnIngresar;
        private PictureBox imagenLogin;
         
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.Usuario dato = new Datos.Usuario(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usuario(textUsuario.Text, textPassword.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }

    }
}
