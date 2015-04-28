namespace FacturacionMinisuper
{
    partial class frmFacturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturar));
            this.gbFacturación = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCajero = new System.Windows.Forms.Label();
            this.pbFacturar = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.gvFacturar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvProductos = new System.Windows.Forms.DataGridView();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFacturación.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacturar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFacturación
            // 
            this.gbFacturación.Controls.Add(this.groupBox3);
            this.gbFacturación.Controls.Add(this.label3);
            this.gbFacturación.Controls.Add(this.lblCajero);
            this.gbFacturación.Controls.Add(this.pbFacturar);
            this.gbFacturación.Controls.Add(this.groupBox2);
            this.gbFacturación.Controls.Add(this.groupBox1);
            this.gbFacturación.Controls.Add(this.txtCodProducto);
            this.gbFacturación.Controls.Add(this.label2);
            this.gbFacturación.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gbFacturación.Location = new System.Drawing.Point(30, 29);
            this.gbFacturación.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFacturación.Name = "gbFacturación";
            this.gbFacturación.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFacturación.Size = new System.Drawing.Size(680, 607);
            this.gbFacturación.TabIndex = 0;
            this.gbFacturación.TabStop = false;
            this.gbFacturación.Text = "Facturación";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.lblMonto);
            this.groupBox3.Font = new System.Drawing.Font("Footlight MT Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(317, 518);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 62);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Black;
            this.lblMonto.Location = new System.Drawing.Point(69, 26);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(0, 24);
            this.lblMonto.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Facturar";
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Location = new System.Drawing.Point(452, 43);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(76, 15);
            this.lblCajero.TabIndex = 10;
            this.lblCajero.Text = "Cajero_ON";
            // 
            // pbFacturar
            // 
            this.pbFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFacturar.Image = ((System.Drawing.Image)(resources.GetObject("pbFacturar.Image")));
            this.pbFacturar.Location = new System.Drawing.Point(532, 507);
            this.pbFacturar.Name = "pbFacturar";
            this.pbFacturar.Size = new System.Drawing.Size(73, 65);
            this.pbFacturar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFacturar.TabIndex = 9;
            this.pbFacturar.TabStop = false;
            this.pbFacturar.Click += new System.EventHandler(this.pbFacturar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSeleccionado);
            this.groupBox2.Controls.Add(this.gvFacturar);
            this.groupBox2.Location = new System.Drawing.Point(34, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 172);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos a Facturar";
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(52, 158);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(0, 15);
            this.lblSeleccionado.TabIndex = 2;
            this.lblSeleccionado.Visible = false;
            // 
            // gvFacturar
            // 
            this.gvFacturar.AllowUserToAddRows = false;
            this.gvFacturar.AllowUserToOrderColumns = true;
            this.gvFacturar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFacturar.Location = new System.Drawing.Point(16, 22);
            this.gvFacturar.Name = "gvFacturar";
            this.gvFacturar.ReadOnly = true;
            this.gvFacturar.Size = new System.Drawing.Size(579, 140);
            this.gvFacturar.TabIndex = 1;
            this.gvFacturar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFacturar_CellContentClick);
            this.gvFacturar.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gvFacturar_RowsAdded);
            this.gvFacturar.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gvFacturar_RowsRemoved);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvProductos);
            this.groupBox1.Location = new System.Drawing.Point(34, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 230);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Producto";
            // 
            // gvProductos
            // 
            this.gvProductos.AllowUserToAddRows = false;
            this.gvProductos.AllowUserToDeleteRows = false;
            this.gvProductos.AllowUserToOrderColumns = true;
            this.gvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductos.Location = new System.Drawing.Point(16, 22);
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.ReadOnly = true;
            this.gvProductos.Size = new System.Drawing.Size(579, 187);
            this.gvProductos.TabIndex = 0;
            this.gvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProductos_CellContentClick);
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(166, 40);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(189, 23);
            this.txtCodProducto.TabIndex = 3;
            this.txtCodProducto.TextChanged += new System.EventHandler(this.txtCodProducto_TextChanged);
            this.txtCodProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProducto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código Producto:";
            // 
            // frmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(738, 648);
            this.Controls.Add(this.gbFacturación);
            this.Font = new System.Drawing.Font("Footlight MT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFacturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.frmFacturar_Load);
            this.gbFacturación.ResumeLayout(false);
            this.gbFacturación.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacturar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFacturación;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.PictureBox pbFacturar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvFacturar;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvProductos;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}