namespace FacturacionMinisuper.Bitacora
{
    partial class frmReporteBitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteBitacora));
            this.rptReporteBitacora = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptReporteBitacora
            // 
            this.rptReporteBitacora.ActiveViewIndex = -1;
            this.rptReporteBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptReporteBitacora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rptReporteBitacora.CachedPageNumberPerDoc = 10;
            this.rptReporteBitacora.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptReporteBitacora.DisplayStatusBar = false;
            this.rptReporteBitacora.EnableDrillDown = false;
            this.rptReporteBitacora.EnableRefresh = false;
            this.rptReporteBitacora.EnableToolTips = false;
            this.rptReporteBitacora.Location = new System.Drawing.Point(26, 29);
            this.rptReporteBitacora.Name = "rptReporteBitacora";
            this.rptReporteBitacora.ShowGroupTreeButton = false;
            this.rptReporteBitacora.ShowLogo = false;
            this.rptReporteBitacora.ShowPageNavigateButtons = false;
            this.rptReporteBitacora.ShowParameterPanelButton = false;
            this.rptReporteBitacora.ShowRefreshButton = false;
            this.rptReporteBitacora.ShowTextSearchButton = false;
            this.rptReporteBitacora.ShowZoomButton = false;
            this.rptReporteBitacora.Size = new System.Drawing.Size(1034, 544);
            this.rptReporteBitacora.TabIndex = 1;
            this.rptReporteBitacora.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.rptReporteBitacora.ToolPanelWidth = 233;
            this.rptReporteBitacora.Load += new System.EventHandler(this.rptReporteBitacora_Load_1);
            // 
            // frmReporteBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1085, 597);
            this.Controls.Add(this.rptReporteBitacora);
            this.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Bitácora";
            this.Load += new System.EventHandler(this.frmReporteBitacora_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptReporteBitacora;
    }
}