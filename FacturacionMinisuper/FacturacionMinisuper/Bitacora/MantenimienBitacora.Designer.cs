namespace FacturacionMinisuper.Bitacora
{
    partial class MantenimienBitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimienBitacora));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbreporte = new System.Windows.Forms.PictureBox();
            this.pbAgregar = new System.Windows.Forms.PictureBox();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.gvBitacora = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbreporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbreporte);
            this.groupBox1.Controls.Add(this.pbAgregar);
            this.groupBox1.Controls.Add(this.lblSeleccionado);
            this.groupBox1.Controls.Add(this.gvBitacora);
            this.groupBox1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(33, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento Bitácora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Agregar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Generar Reporte";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbreporte
            // 
            this.pbreporte.BackColor = System.Drawing.Color.SteelBlue;
            this.pbreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbreporte.Image = ((System.Drawing.Image)(resources.GetObject("pbreporte.Image")));
            this.pbreporte.Location = new System.Drawing.Point(31, 325);
            this.pbreporte.Name = "pbreporte";
            this.pbreporte.Size = new System.Drawing.Size(81, 63);
            this.pbreporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbreporte.TabIndex = 4;
            this.pbreporte.TabStop = false;
            this.pbreporte.Click += new System.EventHandler(this.pbreporte_Click);
            // 
            // pbAgregar
            // 
            this.pbAgregar.BackColor = System.Drawing.Color.SteelBlue;
            this.pbAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("pbAgregar.Image")));
            this.pbAgregar.Location = new System.Drawing.Point(500, 16);
            this.pbAgregar.Name = "pbAgregar";
            this.pbAgregar.Size = new System.Drawing.Size(81, 63);
            this.pbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgregar.TabIndex = 3;
            this.pbAgregar.TabStop = false;
            this.pbAgregar.Click += new System.EventHandler(this.pbAgregar_Click);
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(41, 278);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblSeleccionado.TabIndex = 1;
            this.lblSeleccionado.Visible = false;
            // 
            // gvBitacora
            // 
            this.gvBitacora.AllowUserToAddRows = false;
            this.gvBitacora.AllowUserToDeleteRows = false;
            this.gvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvBitacora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvBitacora.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBitacora.Location = new System.Drawing.Point(20, 107);
            this.gvBitacora.Name = "gvBitacora";
            this.gvBitacora.Size = new System.Drawing.Size(579, 212);
            this.gvBitacora.TabIndex = 0;
            this.gvBitacora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBitacora_CellContentClick);
            // 
            // MantenimienBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(666, 461);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimienBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Bitácora";
            this.Load += new System.EventHandler(this.MantenimienBitacora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbreporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbAgregar;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.DataGridView gvBitacora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbreporte;
        private System.Windows.Forms.Label label2;
    }
}