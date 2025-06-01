namespace ClubDeportivo
{
    partial class frmVencimientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvVencimientos;
        private System.Windows.Forms.Button btnVolver;


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
            this.dgvVencimientos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVencimientos
            // 
            this.dgvVencimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencimientos.Location = new System.Drawing.Point(30, 30);
            this.dgvVencimientos.Name = "dgvVencimientos";
            this.dgvVencimientos.RowHeadersWidth = 51;
            this.dgvVencimientos.RowTemplate.Height = 29;
            this.dgvVencimientos.Size = new System.Drawing.Size(740, 300);
            this.dgvVencimientos.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(650, 350);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 40);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmVencimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvVencimientos);
            this.Name = "frmVencimientos";
            this.Text = "Listado de Cuotas a Vencer Hoy";
            this.Load += new System.EventHandler(this.frmVencimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencimientos)).EndInit();
            this.ResumeLayout(false);
        }


        #endregion
    }
}