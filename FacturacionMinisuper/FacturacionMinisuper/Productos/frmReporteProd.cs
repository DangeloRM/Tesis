using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionMinisuper.Productos
{
    public partial class frmReporteProd : Form
    {
        public frmReporteProd()
        {
            InitializeComponent();
        }

        private void rptReporteProducto_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(@"C:\Reportes\ReporteProductos.rpt");
            report.Refresh();
            this.rptReporteProducto.ReportSource = report;
        }
    }
}
