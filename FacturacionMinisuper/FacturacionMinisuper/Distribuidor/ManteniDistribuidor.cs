using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionMinisuper.Distribuidor
{
    public partial class MenuDistribuidor : Form
    {
        public MenuDistribuidor()
        {
            InitializeComponent();
        }

        private void MenuDistribuidor_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            Logica.Gestor objGestor = new Logica.Gestor();
            gvDistribuidor.DataSource = objGestor.ConsultaMasivaDistribuidores();
            objGestor = null;
            GC.Collect();
        }

        private void pbAgregaDis_Click(object sender, EventArgs e)
        {
            frmAgregarDistribu objAgregar = new frmAgregarDistribu();
            objAgregar.ShowDialog();
            if (objAgregar.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                CargarGrid();
            }
        }

        private void pbActualizaDistribu_Click(object sender, EventArgs e)
        {

            if (gvDistribuidor.CurrentRow != null)
            {
                int coddistr = Convert.ToInt32(gvDistribuidor.CurrentRow.Cells[0].Value.ToString());
                string nombre = gvDistribuidor.CurrentRow.Cells[1].Value.ToString();
                string estad = gvDistribuidor.CurrentRow.Cells[2].Value.ToString();
                string telefon = gvDistribuidor.CurrentRow.Cells[3].Value.ToString();
                Logica.Distribuidor objDistrib = new Logica.Distribuidor(coddistr,nombre,estad,telefon);

                frmActualizarDistribu objActualizarDistri = new frmActualizarDistribu();
                objActualizarDistri.ActuDistribuidor = objDistrib;
                objActualizarDistri.ShowDialog();

                if (objActualizarDistri.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    CargarGrid();
                }
            }
        }

        private void bdManteDistri_Enter(object sender, EventArgs e)
        {

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

        private void pbActualizaDistribu_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmProveedInactivo objProve = new frmProveedInactivo();
            objProve.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void pbReporteDis_Click(object sender, EventArgs e)
        {
            frmReporteDistrib objDistr = new frmReporteDistrib();
            objDistr.ShowDialog();
        }

    }
}
