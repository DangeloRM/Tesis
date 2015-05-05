using System;
using System.Windows.Forms;

namespace FacturacionMinisuper.Productos
{
    public partial class MantenimiProducto : Form
    {
        public MantenimiProducto()
        {
            InitializeComponent();
        }

        private void CargarGrid()
        {
            Logica.Gestor objGestor = new Logica.Gestor();
            gvProductos.DataSource = objGestor.ConsultaMasivaProducto();
            objGestor = null;
            GC.Collect();
        }

        private void pbAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarProducto objAgregar = new frmAgregarProducto();
            objAgregar.ShowDialog();
            if (objAgregar.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                CargarGrid();
            }
        }

        private void MantenimiProducto_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            frmActualizarProducto objActualizarProd = new frmActualizarProducto();
            objActualizarProd.ShowDialog();

            if (objActualizarProd.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                CargarGrid();
            }
        }

        private void gvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void pbReporteProducto_Click(object sender, EventArgs e)
        {
            frmReporteProd objprod = new frmReporteProd();
            objprod.ShowDialog();
        }
    }
}