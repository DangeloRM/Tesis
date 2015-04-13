namespace FacturacionMinisuper
{
    partial class ReporteFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteFactura));
            this.rptReporteFactura = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptReporteFactura
            // 
            this.rptReporteFactura.ActiveViewIndex = -1;
            this.rptReporteFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptReporteFactura.CachedPageNumberPerDoc = 10;
            this.rptReporteFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptReporteFactura.DisplayStatusBar = false;
            this.rptReporteFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptReporteFactura.EnableDrillDown = false;
            this.rptReporteFactura.EnableRefresh = false;
            this.rptReporteFactura.EnableToolTips = false;
            this.rptReporteFactura.Location = new System.Drawing.Point(0, 0);
            this.rptReporteFactura.Name = "rptReporteFactura";
            this.rptReporteFactura.ShowGroupTreeButton = false;
            this.rptReporteFactura.ShowLogo = false;
            this.rptReporteFactura.ShowPageNavigateButtons = false;
            this.rptReporteFactura.ShowParameterPanelButton = false;
            this.rptReporteFactura.ShowRefreshButton = false;
            this.rptReporteFactura.ShowTextSearchButton = false;
            this.rptReporteFactura.ShowZoomButton = false;
            this.rptReporteFactura.Size = new System.Drawing.Size(895, 491);
            this.rptReporteFactura.TabIndex = 0;
            this.rptReporteFactura.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.rptReporteFactura.Load += new System.EventHandler(this.rptReporteFactura_Load);
            // 
            // ReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(895, 491);
            this.Controls.Add(this.rptReporteFactura);
            this.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Factura";
            this.Load += new System.EventHandler(this.ReporteFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptReporteFactura;
    }
}