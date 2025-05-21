namespace ClubDeportivo
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtEmail = new TextBox();
            btnRegistrar = new Button();
            tltRegistro = new Label();
            pictureBox1 = new PictureBox();
            btnVolver = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            lblEmail = new Label();
            lblCampos = new Label();
            checkSocio = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(428, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(271, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(428, 170);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(271, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(428, 282);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(105, 27);
            txtDNI.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(428, 224);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 27);
            txtEmail.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.SlateBlue;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistrar.Location = new Point(343, 370);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(172, 43);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tltRegistro
            // 
            tltRegistro.AutoSize = true;
            tltRegistro.BackColor = Color.Transparent;
            tltRegistro.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tltRegistro.ForeColor = SystemColors.ButtonHighlight;
            tltRegistro.Location = new Point(382, 41);
            tltRegistro.Name = "tltRegistro";
            tltRegistro.Size = new Size(335, 41);
            tltRegistro.TabIndex = 7;
            tltRegistro.Text = "REGISTRO DE CLIENTE";
            tltRegistro.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Silver;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.ButtonHighlight;
            btnVolver.Location = new Point(568, 370);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(172, 43);
            btnVolver.TabIndex = 6;
            btnVolver.TabStop = false;
            btnVolver.Text = "VOLVER";
            btnVolver.UseCompatibleTextRendering = true;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(333, 121);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = SystemColors.ButtonHighlight;
            lblApellido.Location = new Point(333, 177);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 20);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDNI.ForeColor = SystemColors.ButtonHighlight;
            lblDNI.Location = new Point(364, 285);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(48, 20);
            lblDNI.TabIndex = 11;
            lblDNI.Text = "D.N.I.";
            lblDNI.Click += label1_Click_1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ButtonHighlight;
            lblEmail.Location = new Point(347, 231);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "E-mail";
            lblEmail.Click += label2_Click;
            // 
            // lblCampos
            // 
            lblCampos.AutoSize = true;
            lblCampos.ForeColor = SystemColors.ButtonHighlight;
            lblCampos.Location = new Point(428, 326);
            lblCampos.Name = "lblCampos";
            lblCampos.Size = new Size(243, 20);
            lblCampos.TabIndex = 12;
            lblCampos.Text = "Todos los campos son obligatorios.";
            // 
            // checkSocio
            // 
            checkSocio.AutoSize = true;
            checkSocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkSocio.ForeColor = SystemColors.ButtonHighlight;
            checkSocio.Location = new Point(617, 285);
            checkSocio.Name = "checkSocio";
            checkSocio.Size = new Size(68, 24);
            checkSocio.TabIndex = 4;
            checkSocio.Text = "Socio";
            checkSocio.UseVisualStyleBackColor = true;
            checkSocio.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(checkSocio);
            Controls.Add(lblCampos);
            Controls.Add(lblEmail);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox1);
            Controls.Add(tltRegistro);
            Controls.Add(btnRegistrar);
            Controls.Add(txtEmail);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "frmRegistro";
            Text = "REGISTRO DE CLIENTE";
            Load += frmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtEmail;
        private Button btnRegistrar;
        private Label tltRegistro;
        private PictureBox pictureBox1;
        private Button btnVolver;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Label lblEmail;
        private Label lblCampos;
        private CheckBox checkSocio;
    }
}