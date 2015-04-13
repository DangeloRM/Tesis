namespace FacturacionMinisuper.Distribuidor
{
    partial class frmReporteDistrib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteDistrib));
            this.rptReporteDsitr = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptReporteDsitr
            // 
            this.rptReporteDsitr.ActiveViewIndex = -1;
            this.rptReporteDsitr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptReporteDsitr.CachedPageNumberPerDoc = 10;
            this.rptReporteDsitr.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptReporteDsitr.DisplayStatusBar = false;
            this.rptReporteDsitr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptReporteDsitr.EnableDrillDown = false;
            this.rptReporteDsitr.EnableRefresh = false;
            this.rptReporteDsitr.EnableToolTips = false;
            this.rptReporteDsitr.Location = new System.Drawing.Point(0, 0);
            this.rptReporteDsitr.Name = "rptReporteDsitr";
            this.rptReporteDsitr.ShowGroupTreeButton = false;
            this.rptReporteDsitr.ShowLogo = false;
            this.rptReporteDsitr.ShowPageNavigateButtons = false;
            this.rptReporteDsitr.ShowParameterPanelButton = false;
            this.rptReporteDsitr.ShowRefreshButton = false;
            this.rptReporteDsitr.ShowTextSearchButton = false;
            this.rptReporteDsitr.ShowZoomButton = false;
            this.rptReporteDsitr.Size = new System.Drawing.Size(846, 457);
            this.rptReporteDsitr.TabIndex = 2;
            this.rptReporteDsitr.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReporteDistrib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(846, 457);
            this.Controls.Add(this.rptReporteDsitr);
            this.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteDistrib";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top 3 Distribuidores";
            this.Load += new System.EventHandler(this.frmReporteDistrib_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptReporteDsitr;
    }
}