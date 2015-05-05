using CrystalDecisions.CrystalReports.Engine;
using System;
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
            report.Load(@"C:\Reportes\ReporteProducto.rpt");
            report.Refresh();
            this.rptReporteProducto.ReportSource = report;
        }
    }
}