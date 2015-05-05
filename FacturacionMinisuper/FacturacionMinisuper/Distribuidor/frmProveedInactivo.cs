using System;
using System.Windows.Forms;

namespace FacturacionMinisuper.Distribuidor
{
    public partial class frmProveedInactivo : Form
    {
        public frmProveedInactivo()
        {
            InitializeComponent();
        }

        private void CargarGrid()
        {
            Logica.Gestor objGestor = new Logica.Gestor();
            gvDistribuidor.DataSource = objGestor.ConsultaMasivaDistribuidoresInactivos();
            objGestor = null;
            GC.Collect();
        }

        private void gvDistribuidor_MouseClick(object sender, MouseEventArgs e)
        {
            if (gvDistribuidor.CurrentRow != null)
            {
                DataGridViewRow rowActual = gvDistribuidor.CurrentRow;
                string codDistriSelect = rowActual.Cells[0].Value.ToString();
                lblSeleccionado.Text = codDistriSelect;
            }
        }

        private void gvDistribuidor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmProveedInactivo_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void pbActualizaDistribu_Click(object sender, EventArgs e)
        {
            if (gvDistribuidor.CurrentRow != null)
            {
                int coddistr = Convert.ToInt32(gvDistribuidor.CurrentRow.Cells[0].Value.ToString());
                string nombre = gvDistribuidor.CurrentRow.Cells[1].Value.ToString();
                string estad = gvDistribuidor.CurrentRow.Cells[2].Value.ToString();
                string telefon = gvDistribuidor.CurrentRow.Cells[3].Value.ToString();
                Logica.Distribuidor objDistrib = new Logica.Distribuidor(coddistr, nombre, estad, telefon);

                frmActualizarProveedor objActualizarDistri = new frmActualizarProveedor();
                objActualizarDistri.ActuDistribuidor = objDistrib;
                objActualizarDistri.ShowDialog();

                if (objActualizarDistri.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    CargarGrid();
                }
            }
        }
    }
}