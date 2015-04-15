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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
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
            this.rptReporteBitacora.Location = new System.Drawing.Point(12, 62);
            this.rptReporteBitacora.Name = "rptReporteBitacora";
            this.rptReporteBitacora.ShowGroupTreeButton = false;
            this.rptReporteBitacora.ShowLogo = false;
            this.rptReporteBitacora.ShowPageNavigateButtons = false;
            this.rptReporteBitacora.ShowParameterPanelButton = false;
            this.rptReporteBitacora.ShowRefreshButton = false;
            this.rptReporteBitacora.ShowTextSearchButton = false;
            this.rptReporteBitacora.ShowZoomButton = false;
            this.rptReporteBitacora.Size = new System.Drawing.Size(995, 508);
            this.rptReporteBitacora.TabIndex = 1;
            this.rptReporteBitacora.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.rptReporteBitacora.ToolPanelWidth = 233;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Bitácoras según fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(295, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 21);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2015, 4, 14, 14, 50, 53, 0);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscar.Image")));
            this.pbBuscar.Location = new System.Drawing.Point(414, 12);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(64, 44);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBuscar.TabIndex = 5;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // frmReporteBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1019, 597);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptReporteBitacora);
            this.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Bitácora";
            this.Load += new System.EventHandler(this.frmReporteBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptReporteBitacora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pbBuscar;
    }
}