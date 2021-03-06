﻿using CrystalDecisions.CrystalReports.Engine;
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
            reporte.Load(@"C:\Reportes\ReporteFactura.rpt");
            reporte.SetDatabaseLogon("sa", "falling20", "WILLIAM\\DESARROLLO", "DBFacturacionM");
            this.rptReporteFactura.ReportSource = reporte;
        }
    }
}
