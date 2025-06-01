namespace ClubDeportivo
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            btnRegistrarCliente = new Button();
            btnInscribirActividad = new Button();
            btnPagarCuota = new Button();
            btnListarVencimientos = new Button();
            btnExit = new Button();
            lblIngreso = new Label();
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            lblSubtitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.BackColor = Color.MediumSlateBlue;
            btnRegistrarCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnRegistrarCliente.ForeColor = SystemColors.ButtonFace;
            btnRegistrarCliente.Location = new Point(50, 83);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(232, 79);
            btnRegistrarCliente.TabIndex = 0;
            btnRegistrarCliente.Text = "Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnInscribirActividad
            // 
            btnInscribirActividad.BackColor = Color.Silver;
            btnInscribirActividad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnInscribirActividad.ForeColor = SystemColors.ButtonFace;
            btnInscribirActividad.Location = new Point(50, 423);
            btnInscribirActividad.Name = "btnInscribirActividad";
            btnInscribirActividad.Size = new Size(232, 79);
            btnInscribirActividad.TabIndex = 1;
            btnInscribirActividad.Text = "Inscribir Actividad";
            btnInscribirActividad.UseVisualStyleBackColor = false;
            btnInscribirActividad.Click += btnInscribirActividad_click;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.BackColor = Color.Silver;
            btnPagarCuota.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPagarCuota.ForeColor = SystemColors.ButtonFace;
            btnPagarCuota.Location = new Point(50, 194);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(232, 79);
            btnPagarCuota.TabIndex = 2;
            btnPagarCuota.Text = "Pagar Cuota";
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnListarVencimientos
            // 
            btnListarVencimientos.BackColor = Color.SlateBlue;
            btnListarVencimientos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnListarVencimientos.ForeColor = SystemColors.ButtonFace;
            btnListarVencimientos.Location = new Point(50, 309);
            btnListarVencimientos.Name = "btnListarVencimientos";
            btnListarVencimientos.Size = new Size(232, 79);
            btnListarVencimientos.TabIndex = 3;
            btnListarVencimientos.Text = "Listar Vencimientos";
            btnListarVencimientos.UseVisualStyleBackColor = false;
            btnListarVencimientos.Click += btnListarVencimientos_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(807, 493);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 31);
            btnExit.TabIndex = 4;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(94, 24);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(0, 20);
            lblIngreso.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.SlateBlue;
            lblTitulo.Location = new Point(466, 48);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(269, 41);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "CLUB DEPORTIVO";
            lblTitulo.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(444, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(520, 99);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(157, 20);
            lblSubtitulo.TabIndex = 8;
            lblSubtitulo.Text = "Gestión administrativa";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(945, 547);
            Controls.Add(lblSubtitulo);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Controls.Add(lblIngreso);
            Controls.Add(btnExit);
            Controls.Add(btnListarVencimientos);
            Controls.Add(btnPagarCuota);
            Controls.Add(btnInscribirActividad);
            Controls.Add(btnRegistrarCliente);
            Name = "frmPrincipal";
            Text = "Ventana Principal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Button btnInscribirActividad;
        private System.Windows.Forms.Button btnPagarCuota;
        private System.Windows.Forms.Button btnListarVencimientos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblIngreso;
        private Label lblTitulo;
        private PictureBox pictureBox1;
        private Label lblSubtitulo;
    }
}