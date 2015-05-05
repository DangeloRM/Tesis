using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Windows.Forms;

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
            dateTimePicker1.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            ParameterFields arregloParam = new ParameterFields();
            ParameterField Fecha = new ParameterField();
            Fecha.Name = "@Fecha";
            ParameterDiscreteValue valor = new ParameterDiscreteValue();
            valor.Value = this.dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Fecha.CurrentValues.Add(valor);
            arregloParam.Add(Fecha);
            this.rptReporteBitacora.ParameterFieldInfo = arregloParam;
            report.Load(@"C:\Reportes\ReporteBitacoras.rpt");
            //report.SetDatabaseLogon("sa", "123", "DANGELO-PC", "DBFacturacionM");
            this.rptReporteBitacora.ReportSource = report;
        }
    }
}