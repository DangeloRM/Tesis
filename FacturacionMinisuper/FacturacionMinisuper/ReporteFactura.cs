using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Windows.Forms;

namespace FacturacionMinisuper
{
    public partial class ReporteFactura : Form
    {
        public int CodFactura { get; set; }

        public ReporteFactura()
        {
            InitializeComponent();
        }

        private void ReporteFactura_Load(object sender, EventArgs e)
        {
            ReportDocument reporte = new ReportDocument();
            ParameterFields arregloParametros = new ParameterFields();
            ParameterField codFactura = new ParameterField();
            codFactura.Name = "@idFactura";
            ParameterDiscreteValue valor = new ParameterDiscreteValue();
            valor.Value = this.CodFactura;
            codFactura.CurrentValues.Add(valor);
            arregloParametros.Add(codFactura);
            this.rptReporteFactura.ParameterFieldInfo = arregloParametros;
            reporte.Load(@"C:\Reportes\ReporteFacturas.rpt");
            //reporte.SetDatabaseLogon("sa", "123", "DANGELO-PC", "DBFacturacionM1");
            this.rptReporteFactura.ReportSource = reporte;
        }

        private void rptReporteFactura_Load(object sender, EventArgs e)
        {
        }
    }
}