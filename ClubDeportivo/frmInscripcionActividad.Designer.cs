namespace ClubDeportivo
{
    partial class frmInscripcionActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcionActividad));
            pictureBox1 = new PictureBox();
            txtTitulo = new Label();
            cmbActividades = new ComboBox();
            txtDniNoSocio = new TextBox();
            lblActividad = new Label();
            lblDniNoSocio = new Label();
            btnPagarAct = new Button();
            btnVolver = new Button();
            txtMontoAct = new TextBox();
            label1 = new Label();
            lblCupo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(508, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = SystemColors.ButtonHighlight;
            txtTitulo.Location = new Point(75, 60);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(354, 38);
            txtTitulo.TabIndex = 12;
            txtTitulo.Text = "INSCRIPCIÓN ACTIVIDAD";
            // 
            // cmbActividades
            // 
            cmbActividades.FormattingEnabled = true;
            cmbActividades.Location = new Point(215, 130);
            cmbActividades.Name = "cmbActividades";
            cmbActividades.Size = new Size(233, 28);
            cmbActividades.TabIndex = 13;
            cmbActividades.SelectedIndexChanged += cmbActividades_SelectedIndexChanged;
            // 
            // txtDniNoSocio
            // 
            txtDniNoSocio.Location = new Point(214, 195);
            txtDniNoSocio.Name = "txtDniNoSocio";
            txtDniNoSocio.Size = new Size(158, 27);
            txtDniNoSocio.TabIndex = 14;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActividad.ForeColor = SystemColors.ButtonHighlight;
            lblActividad.Location = new Point(75, 138);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(75, 20);
            lblActividad.TabIndex = 17;
            lblActividad.Text = "Actividad";
            // 
            // lblDniNoSocio
            // 
            lblDniNoSocio.AutoSize = true;
            lblDniNoSocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDniNoSocio.ForeColor = SystemColors.ButtonHighlight;
            lblDniNoSocio.Location = new Point(75, 202);
            lblDniNoSocio.Name = "lblDniNoSocio";
            lblDniNoSocio.Size = new Size(92, 20);
            lblDniNoSocio.TabIndex = 18;
            lblDniNoSocio.Text = "Nro. DNI";
            // 
            // btnPagarAct
            // 
            btnPagarAct.BackColor = Color.SlateBlue;
            btnPagarAct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagarAct.ForeColor = SystemColors.ButtonHighlight;
            btnPagarAct.Location = new Point(215, 397);
            btnPagarAct.Name = "btnPagarAct";
            btnPagarAct.Size = new Size(172, 43);
            btnPagarAct.TabIndex = 19;
            btnPagarAct.Text = "PAGAR";
            btnPagarAct.UseVisualStyleBackColor = false;
            btnPagarAct.Click += btnPagarAct_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Silver;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.ButtonHighlight;
            btnVolver.Location = new Point(450, 397);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(172, 43);
            btnVolver.TabIndex = 20;
            btnVolver.TabStop = false;
            btnVolver.Text = "VOLVER";
            btnVolver.UseCompatibleTextRendering = true;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtMontoAct
            // 
            txtMontoAct.Location = new Point(214, 256);
            txtMontoAct.Name = "txtMontoAct";
            txtMontoAct.ReadOnly = true;
            txtMontoAct.Size = new Size(158, 27);
            txtMontoAct.TabIndex = 21;
            txtMontoAct.Enabled = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(75, 263);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 22;
            label1.Text = "Monto";
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCupo.ForeColor = SystemColors.ButtonHighlight;
            lblCupo.Location = new Point(214, 319);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(0, 20);
            lblCupo.TabIndex = 23;
            // 
            // frmInscripcionActividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(880, 497);
            Controls.Add(lblCupo);
            Controls.Add(label1);
            Controls.Add(txtMontoAct);
            Controls.Add(btnVolver);
            Controls.Add(btnPagarAct);
            Controls.Add(lblDniNoSocio);
            Controls.Add(lblActividad);
            Controls.Add(txtDniNoSocio);
            Controls.Add(cmbActividades);
            Controls.Add(txtTitulo);
            Controls.Add(pictureBox1);
            Name = "frmInscripcionActividad";
            Text = "frmInscripciónActividad";
            Load += frmInscripcionActividad_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label txtTitulo;
        private ComboBox cmbActividades;
        private TextBox txtDniNoSocio;
        private Label lblActividad;
        private Label lblDniNoSocio;
        private Button btnPagarAct;
        private Button btnVolver;
        private TextBox txtMontoAct;
        private Label label1;
        private Label lblCupo;
    }
}