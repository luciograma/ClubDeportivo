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
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.btnInscribirActividad = new System.Windows.Forms.Button();
            this.btnPagarCuota = new System.Windows.Forms.Button();
            this.btnListarVencimientos = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(94, 116);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(232, 79);
            this.btnRegistrarCliente.TabIndex = 0;
            this.btnRegistrarCliente.Text = "Registrar Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // btnInscribirActividad
            // 
            this.btnInscribirActividad.BackColor = System.Drawing.Color.Silver;
            this.btnInscribirActividad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInscribirActividad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInscribirActividad.Location = new System.Drawing.Point(428, 116);
            this.btnInscribirActividad.Name = "btnInscribirActividad";
            this.btnInscribirActividad.Size = new System.Drawing.Size(232, 79);
            this.btnInscribirActividad.TabIndex = 1;
            this.btnInscribirActividad.Text = "Inscribir Actividad";
            this.btnInscribirActividad.UseVisualStyleBackColor = false;
            this.btnInscribirActividad.Enabled = false;
            // 
            // btnPagarCuota
            // 
            this.btnPagarCuota.BackColor = System.Drawing.Color.Silver;
            this.btnPagarCuota.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPagarCuota.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPagarCuota.Location = new System.Drawing.Point(94, 272);
            this.btnPagarCuota.Name = "btnPagarCuota";
            this.btnPagarCuota.Size = new System.Drawing.Size(232, 79);
            this.btnPagarCuota.TabIndex = 2;
            this.btnPagarCuota.Text = "Pagar Cuota";
            this.btnPagarCuota.UseVisualStyleBackColor = false;
            this.btnPagarCuota.Enabled = false;
            // 
            // btnListarVencimientos
            // 
            this.btnListarVencimientos.BackColor = System.Drawing.Color.SlateBlue;
            this.btnListarVencimientos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListarVencimientos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListarVencimientos.Location = new System.Drawing.Point(428, 272);
            this.btnListarVencimientos.Name = "btnListarVencimientos";
            this.btnListarVencimientos.Size = new System.Drawing.Size(232, 79);
            this.btnListarVencimientos.TabIndex = 3;
            this.btnListarVencimientos.Text = "Listar Vencimientos";
            this.btnListarVencimientos.UseVisualStyleBackColor = false;
            this.btnListarVencimientos.Enabled = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(672, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(94, 24);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(0, 20);
            this.lblIngreso.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnListarVencimientos);
            this.Controls.Add(this.btnPagarCuota);
            this.Controls.Add(this.btnInscribirActividad);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Name = "frmPrincipal";
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Button btnInscribirActividad;
        private System.Windows.Forms.Button btnPagarCuota;
        private System.Windows.Forms.Button btnListarVencimientos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblIngreso;
    }
}