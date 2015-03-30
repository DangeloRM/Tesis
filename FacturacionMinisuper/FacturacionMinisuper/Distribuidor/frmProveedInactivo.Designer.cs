namespace FacturacionMinisuper.Distribuidor
{
    partial class frmProveedInactivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedInactivo));
            this.gvDistribuidor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pbActualizaDistribu = new System.Windows.Forms.PictureBox();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDistribuidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizaDistribu)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDistribuidor
            // 
            this.gvDistribuidor.AllowUserToAddRows = false;
            this.gvDistribuidor.AllowUserToDeleteRows = false;
            this.gvDistribuidor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDistribuidor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvDistribuidor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvDistribuidor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvDistribuidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDistribuidor.Location = new System.Drawing.Point(24, 89);
            this.gvDistribuidor.Margin = new System.Windows.Forms.Padding(5);
            this.gvDistribuidor.Name = "gvDistribuidor";
            this.gvDistribuidor.ReadOnly = true;
            this.gvDistribuidor.Size = new System.Drawing.Size(523, 240);
            this.gvDistribuidor.TabIndex = 1;
            this.gvDistribuidor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDistribuidor_CellContentClick);
            this.gvDistribuidor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvDistribuidor_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Editar";
            // 
            // pbActualizaDistribu
            // 
            this.pbActualizaDistribu.BackColor = System.Drawing.Color.SteelBlue;
            this.pbActualizaDistribu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbActualizaDistribu.Image = ((System.Drawing.Image)(resources.GetObject("pbActualizaDistribu.Image")));
            this.pbActualizaDistribu.Location = new System.Drawing.Point(457, 2);
            this.pbActualizaDistribu.Margin = new System.Windows.Forms.Padding(4);
            this.pbActualizaDistribu.Name = "pbActualizaDistribu";
            this.pbActualizaDistribu.Size = new System.Drawing.Size(81, 63);
            this.pbActualizaDistribu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbActualizaDistribu.TabIndex = 18;
            this.pbActualizaDistribu.TabStop = false;
            this.pbActualizaDistribu.Click += new System.EventHandler(this.pbActualizaDistribu_Click);
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(74, 327);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(0, 15);
            this.lblSeleccionado.TabIndex = 20;
            this.lblSeleccionado.Visible = false;
            // 
            // frmProveedInactivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(567, 360);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbActualizaDistribu);
            this.Controls.Add(this.gvDistribuidor);
            this.Font = new System.Drawing.Font("Footlight MT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProveedInactivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores Inactivos";
            this.Load += new System.EventHandler(this.frmProveedInactivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDistribuidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizaDistribu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDistribuidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbActualizaDistribu;
        private System.Windows.Forms.Label lblSeleccionado;
    }
}