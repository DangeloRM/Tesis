using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace FacturacionMinisuper.Bitacora
{
    public partial class frmReporteBitacora : Form
    {
        public frmReporteBitacora()
        {
            InitializeComponent();
        }

        private void frmReporteBitacora_Load(object sender, EventArgs e)
        {

        }

        private void pbGenerarReporte_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(@"C:\Reportes\ReporteBitacora.rpt");
            report.Refresh();
            this.rptReporteBitacora.ReportSource = report;
        }
    }
}
