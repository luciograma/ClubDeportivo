namespace ClubDeportivo
{
    partial class frmCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuota));
            txtNroSocio = new TextBox();
            lblNroSocio = new Label();
            lblMonto = new Label();
            txtMontoCuota = new TextBox();
            lblMDPago = new Label();
            lblCantCuotas = new Label();
            txtCantCuotas = new TextBox();
            selectMDPago = new ComboBox();
            txtTitulo = new Label();
            picPagar = new PictureBox();
            btnPagarCuota = new Button();
            btnVolver = new Button();
            lblCampos = new Label();
            ((System.ComponentModel.ISupportInitialize)picPagar).BeginInit();
            SuspendLayout();
            // 
            // txtNroSocio
            // 
            txtNroSocio.Location = new Point(507, 139);
            txtNroSocio.Name = "txtNroSocio";
            txtNroSocio.Size = new Size(135, 27);
            txtNroSocio.TabIndex = 0;
            // 
            // lblNroSocio
            // 
            lblNroSocio.AutoSize = true;
            lblNroSocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNroSocio.ForeColor = SystemColors.ButtonHighlight;
            lblNroSocio.Location = new Point(420, 142);
            lblNroSocio.Name = "lblNroSocio";
            lblNroSocio.Size = new Size(81, 20);
            lblNroSocio.TabIndex = 1;
            lblNroSocio.Text = "Nro. Socio";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonto.ForeColor = SystemColors.ButtonHighlight;
            lblMonto.Location = new Point(445, 207);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(56, 20);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "Monto";
            // 
            // txtMontoCuota
            // 
            txtMontoCuota.Location = new Point(507, 204);
            txtMontoCuota.Name = "txtMontoCuota";
            txtMontoCuota.Size = new Size(135, 27);
            txtMontoCuota.TabIndex = 3;
            // 
            // lblMDPago
            // 
            lblMDPago.AutoSize = true;
            lblMDPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMDPago.ForeColor = SystemColors.ButtonHighlight;
            lblMDPago.Location = new Point(388, 273);
            lblMDPago.Name = "lblMDPago";
            lblMDPago.Size = new Size(113, 20);
            lblMDPago.TabIndex = 6;
            lblMDPago.Text = "Medio de Pago";
            // 
            // lblCantCuotas
            // 
            lblCantCuotas.AutoSize = true;
            lblCantCuotas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantCuotas.ForeColor = SystemColors.ButtonHighlight;
            lblCantCuotas.Location = new Point(404, 337);
            lblCantCuotas.Name = "lblCantCuotas";
            lblCantCuotas.Size = new Size(97, 20);
            lblCantCuotas.TabIndex = 8;
            lblCantCuotas.Text = "Cant. Cuotas";
            // 
            // txtCantCuotas
            // 
            txtCantCuotas.Location = new Point(507, 330);
            txtCantCuotas.Name = "txtCantCuotas";
            txtCantCuotas.Size = new Size(135, 27);
            txtCantCuotas.TabIndex = 7;
            // 
            // selectMDPago
            // 
            selectMDPago.FormattingEnabled = true;
            selectMDPago.Items.AddRange(new object[] { "Efectivo", "Transferencia", "Tarjeta de Credito" });
            selectMDPago.Location = new Point(507, 265);
            selectMDPago.Name = "selectMDPago";
            selectMDPago.Size = new Size(135, 28);
            selectMDPago.TabIndex = 9;
            selectMDPago.SelectedIndexChanged += selectMDPago_SelectedIndexChanged;
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = SystemColors.ButtonHighlight;
            txtTitulo.Location = new Point(445, 60);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(236, 38);
            txtTitulo.TabIndex = 11;
            txtTitulo.Text = "PAGO DE CUOTA";
            txtTitulo.Click += txtTitulo_Click;
            // 
            // picPagar
            // 
            picPagar.BackColor = Color.Transparent;
            picPagar.Image = (Image)resources.GetObject("picPagar.Image");
            picPagar.Location = new Point(-1, 1);
            picPagar.Name = "picPagar";
            picPagar.Size = new Size(306, 480);
            picPagar.SizeMode = PictureBoxSizeMode.StretchImage;
            picPagar.TabIndex = 12;
            picPagar.TabStop = false;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.BackColor = Color.SlateBlue;
            btnPagarCuota.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagarCuota.ForeColor = SystemColors.ButtonHighlight;
            btnPagarCuota.Location = new Point(371, 405);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(172, 43);
            btnPagarCuota.TabIndex = 13;
            btnPagarCuota.Text = "PAGAR";
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Silver;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.ButtonHighlight;
            btnVolver.Location = new Point(572, 405);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(172, 43);
            btnVolver.TabIndex = 14;
            btnVolver.TabStop = false;
            btnVolver.Text = "VOLVER";
            btnVolver.UseCompatibleTextRendering = true;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblCampos
            // 
            lblCampos.AutoSize = true;
            lblCampos.ForeColor = SystemColors.ButtonHighlight;
            lblCampos.Location = new Point(655, 337);
            lblCampos.Name = "lblCampos";
            lblCampos.Size = new Size(152, 20);
            lblCampos.TabIndex = 15;
            lblCampos.Text = "* Sólo si eligió tarjeta";
            lblCampos.Click += lblCampos_Click;
            // 
            // frmCuota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(819, 480);
            Controls.Add(lblCampos);
            Controls.Add(btnVolver);
            Controls.Add(btnPagarCuota);
            Controls.Add(picPagar);
            Controls.Add(txtTitulo);
            Controls.Add(selectMDPago);
            Controls.Add(lblCantCuotas);
            Controls.Add(txtCantCuotas);
            Controls.Add(lblMDPago);
            Controls.Add(lblMonto);
            Controls.Add(txtMontoCuota);
            Controls.Add(lblNroSocio);
            Controls.Add(txtNroSocio);
            Name = "frmCuota";
            Text = "formCuota";
            Load += formCuota_Load;
            ((System.ComponentModel.ISupportInitialize)picPagar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNroSocio;
        private Label lblNroSocio;
        private Label lblMonto;
        private TextBox txtMontoCuota;
        private Label lblMDPago;
        private Label lblCantCuotas;
        private TextBox txtCantCuotas;
        private ComboBox selectMDPago;
        private Label txtTitulo;
        private PictureBox picPagar;
        private Button btnPagarCuota;
        private Button btnVolver;
        private Label lblCampos;
    }
}