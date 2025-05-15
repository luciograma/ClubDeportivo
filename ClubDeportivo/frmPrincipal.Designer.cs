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
            btnRegistrarCliente = new Button();
            btnInscribirAct = new Button();
            btnPagarCuota = new Button();
            btnEmitirCarnet = new Button();
            btnExit = new Button();
            lblIngreso = new Label();
            SuspendLayout();
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.BackColor = Color.MediumSlateBlue;
            btnRegistrarCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarCliente.ForeColor = SystemColors.ButtonFace;
            btnRegistrarCliente.Location = new Point(94, 116);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(232, 79);
            btnRegistrarCliente.TabIndex = 0;
            btnRegistrarCliente.Text = "Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnInscribirAct
            // 
            btnInscribirAct.BackColor = Color.Silver;
            btnInscribirAct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInscribirAct.ForeColor = SystemColors.ButtonFace;
            btnInscribirAct.Location = new Point(428, 116);
            btnInscribirAct.Name = "btnInscribirAct";
            btnInscribirAct.Size = new Size(232, 79);
            btnInscribirAct.TabIndex = 1;
            btnInscribirAct.Text = "Inscribir Actividad";
            btnInscribirAct.UseVisualStyleBackColor = false;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.BackColor = Color.Silver;
            btnPagarCuota.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagarCuota.ForeColor = SystemColors.ButtonFace;
            btnPagarCuota.Location = new Point(94, 272);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(232, 79);
            btnPagarCuota.TabIndex = 2;
            btnPagarCuota.Text = "Pagar Cuota";
            btnPagarCuota.UseVisualStyleBackColor = false;
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.BackColor = Color.SlateBlue;
            btnEmitirCarnet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmitirCarnet.ForeColor = SystemColors.ButtonFace;
            btnEmitirCarnet.Location = new Point(428, 272);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new Size(232, 79);
            btnEmitirCarnet.TabIndex = 3;
            btnEmitirCarnet.Text = "Emitir Carnet";
            btnEmitirCarnet.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(672, 24);
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
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIngreso);
            Controls.Add(btnExit);
            Controls.Add(btnEmitirCarnet);
            Controls.Add(btnPagarCuota);
            Controls.Add(btnInscribirAct);
            Controls.Add(btnRegistrarCliente);
            Name = "frmPrincipal";
            Text = "Ventana Principal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarCliente;
        private Button btnInscribirAct;
        private Button btnPagarCuota;
        private Button btnEmitirCarnet;
        private Button btnExit;
        private Label lblIngreso;
    }
}