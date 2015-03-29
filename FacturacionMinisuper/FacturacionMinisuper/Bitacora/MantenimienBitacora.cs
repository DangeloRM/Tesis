using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionMinisuper.Bitacora
{
    public partial class MantenimienBitacora : Form
    {
        public MantenimienBitacora()
        {
            InitializeComponent();
        }

        private void MantenimienBitacora_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            Logica.Gestor objGestor = new Logica.Gestor();
            gvBitacora.DataSource = objGestor.ConsultaMasivaBitacora();
            objGestor = null;
            GC.Collect();
        }

        private void pbAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarBitacora objAgregar = new frmAgregarBitacora();
            objAgregar.ShowDialog();
            if (objAgregar.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                CargarGrid();
            }
        }

        private void pbreporte_Click(object sender, EventArgs e)
        {
            frmReporteBitacora objReporte = new frmReporteBitacora();
            objReporte.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gvBitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
