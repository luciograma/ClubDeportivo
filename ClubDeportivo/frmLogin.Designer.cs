namespace ClubDeportivo
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            imageLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imageLogin).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.MediumSlateBlue;
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 64);
            btnIngresar.Location = new Point(455, 294);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(250, 60);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += new EventHandler(btnIngresar_Click);
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9F);
            txtUsuario.Location = new Point(456, 101);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(249, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "USUARIO";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(456, 168);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(249, 27);
            txtPass.TabIndex = 4;
            txtPass.Text = "CONTRASEÑA";
            // 
            // imageLogin
            // 
            imageLogin.Image = (Image)resources.GetObject("imageLogin.Image");
            imageLogin.Location = new Point(74, 61);
            imageLogin.Name = "imageLogin";
            imageLogin.Size = new Size(267, 293);
            imageLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            imageLogin.TabIndex = 5;
            imageLogin.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(imageLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "frmLogin";
            Text = "formLogin2";
            Load += formLogin_Load;
            ((System.ComponentModel.ISupportInitialize)imageLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private PictureBox imageLogin;
    }
}