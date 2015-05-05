using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Windows.Forms;

namespace FacturacionMinisuper.Distribuidor
{
    public partial class frmReporteDistrib : Form
    {
        public frmReporteDistrib()
        {
            InitializeComponent();
        }

        private void frmReporteDistrib_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(@"C:\Reportes\ReporteDistribuidor.rpt");
            report.Refresh();
            this.rptReporteDsitr.ReportSource = report;
        }
    }
}