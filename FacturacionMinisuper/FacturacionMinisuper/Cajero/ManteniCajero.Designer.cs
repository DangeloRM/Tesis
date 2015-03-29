namespace FacturacionMinisuper.Cajero
{
    partial class ManteniCajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManteniCajero));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbAgregarCajero = new System.Windows.Forms.PictureBox();
            this.gvCajero = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarCajero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCajero)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSeleccionado);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pbAgregarCajero);
            this.groupBox1.Controls.Add(this.gvCajero);
            this.groupBox1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento Cajero";
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(31, 298);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblSeleccionado.TabIndex = 5;
            this.lblSeleccionado.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbAgregarCajero
            // 
            this.pbAgregarCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbAgregarCajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAgregarCajero.Image = ((System.Drawing.Image)(resources.GetObject("pbAgregarCajero.Image")));
            this.pbAgregarCajero.Location = new System.Drawing.Point(451, 14);
            this.pbAgregarCajero.Name = "pbAgregarCajero";
            this.pbAgregarCajero.Size = new System.Drawing.Size(87, 58);
            this.pbAgregarCajero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgregarCajero.TabIndex = 3;
            this.pbAgregarCajero.TabStop = false;
            this.pbAgregarCajero.Click += new System.EventHandler(this.pbAgregarCajero_Click);
            // 
            // gvCajero
            // 
            this.gvCajero.AllowUserToAddRows = false;
            this.gvCajero.AllowUserToDeleteRows = false;
            this.gvCajero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCajero.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvCajero.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvCajero.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvCajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCajero.Location = new System.Drawing.Point(17, 102);
            this.gvCajero.Name = "gvCajero";
            this.gvCajero.ReadOnly = true;
            this.gvCajero.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvCajero.Size = new System.Drawing.Size(531, 262);
            this.gvCajero.TabIndex = 0;
            this.gvCajero.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCajero_CellContentClick);
            this.gvCajero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvCajero_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Agregar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Editar";
            // 
            // ManteniCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(613, 430);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManteniCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Cajero";
            this.Load += new System.EventHandler(this.ManteniCajero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarCajero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCajero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvCajero;
        private System.Windows.Forms.PictureBox pbAgregarCajero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}