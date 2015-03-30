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
            this.pbGenerarReporte = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerarReporte)).BeginInit();
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
            this.rptReporteBitacora.Size = new System.Drawing.Size(623, 412);
            this.rptReporteBitacora.TabIndex = 1;
            this.rptReporteBitacora.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.rptReporteBitacora.ToolPanelWidth = 233;
            this.rptReporteBitacora.Load += new System.EventHandler(this.rptReporteBitacora_Load);
            // 
            // pbGenerarReporte
            // 
            this.pbGenerarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGenerarReporte.Image = ((System.Drawing.Image)(resources.GetObject("pbGenerarReporte.Image")));
            this.pbGenerarReporte.Location = new System.Drawing.Point(68, 456);
            this.pbGenerarReporte.Name = "pbGenerarReporte";
            this.pbGenerarReporte.Size = new System.Drawing.Size(64, 48);
            this.pbGenerarReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGenerarReporte.TabIndex = 2;
            this.pbGenerarReporte.TabStop = false;
            this.pbGenerarReporte.Click += new System.EventHandler(this.pbGenerarReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Generar Reporte";
            // 
            // frmReporteBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(674, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGenerarReporte);
            this.Controls.Add(this.rptReporteBitacora);
            this.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Bitácora";
            this.Load += new System.EventHandler(this.frmReporteBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerarReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptReporteBitacora;
        private System.Windows.Forms.PictureBox pbGenerarReporte;
        private System.Windows.Forms.Label label1;
    }
}