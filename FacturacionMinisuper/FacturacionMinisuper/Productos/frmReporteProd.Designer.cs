namespace FacturacionMinisuper.Productos
{
    partial class frmReporteProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteProd));
            this.rptReporteProducto = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptReporteProducto
            // 
            this.rptReporteProducto.ActiveViewIndex = -1;
            this.rptReporteProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptReporteProducto.CachedPageNumberPerDoc = 10;
            this.rptReporteProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptReporteProducto.DisplayStatusBar = false;
            this.rptReporteProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptReporteProducto.EnableDrillDown = false;
            this.rptReporteProducto.EnableRefresh = false;
            this.rptReporteProducto.EnableToolTips = false;
            this.rptReporteProducto.Location = new System.Drawing.Point(0, 0);
            this.rptReporteProducto.Name = "rptReporteProducto";
            this.rptReporteProducto.ShowGroupTreeButton = false;
            this.rptReporteProducto.ShowLogo = false;
            this.rptReporteProducto.ShowPageNavigateButtons = false;
            this.rptReporteProducto.ShowParameterPanelButton = false;
            this.rptReporteProducto.ShowRefreshButton = false;
            this.rptReporteProducto.ShowTextSearchButton = false;
            this.rptReporteProducto.ShowZoomButton = false;
            this.rptReporteProducto.Size = new System.Drawing.Size(885, 488);
            this.rptReporteProducto.TabIndex = 1;
            this.rptReporteProducto.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.rptReporteProducto.Load += new System.EventHandler(this.rptReporteProducto_Load);
            // 
            // frmReporteProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(885, 488);
            this.Controls.Add(this.rptReporteProducto);
            this.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top 5 Productos más Vendidos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptReporteProducto;
    }
}