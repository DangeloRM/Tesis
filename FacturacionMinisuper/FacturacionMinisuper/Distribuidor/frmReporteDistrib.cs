using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmReporteDistrib : Form
    {
        public frmReporteDistrib()
        {
            InitializeComponent();
        }

        private void frmReporteDistrib_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(@"C:\Reportes\ReporteDistribuidores.rpt");
            report.Refresh();
            this.rptReporteDsitr.ReportSource = report;
        }
    }
}
