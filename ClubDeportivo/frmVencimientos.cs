using ClubDeportivo.Entidades;
using System.Data;

namespace ClubDeportivo
{
    public partial class frmVencimientos : Form
    {
        public frmVencimientos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void frmVencimientos_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = Cuota.ListarVencimientos();

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No hay cuotas con vencimiento en el día.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvVencimientos.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vencimientos: " + ex.Message, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
