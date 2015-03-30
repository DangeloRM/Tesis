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
            this.label3 = new System.Windows.Forms.Label();
            this.lblCajero = new System.Windows.Forms.Label();
            this.pbFacturar = new System.Windows.Forms.PictureBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvFacturar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvProductos = new System.Windows.Forms.DataGridView();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.txtCajero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFacturación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacturar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFacturación
            // 
            this.gbFacturación.Controls.Add(this.label3);
            this.gbFacturación.Controls.Add(this.lblCajero);
            this.gbFacturación.Controls.Add(this.pbFacturar);
            this.gbFacturación.Controls.Add(this.lblMonto);
            this.gbFacturación.Controls.Add(this.lblTotal);
            this.gbFacturación.Controls.Add(this.lblDatos);
            this.gbFacturación.Controls.Add(this.groupBox2);
            this.gbFacturación.Controls.Add(this.groupBox1);
            this.gbFacturación.Controls.Add(this.txtCodProducto);
            this.gbFacturación.Controls.Add(this.txtCajero);
            this.gbFacturación.Controls.Add(this.label2);
            this.gbFacturación.Controls.Add(this.label1);
            this.gbFacturación.Location = new System.Drawing.Point(27, 29);
            this.gbFacturación.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFacturación.Name = "gbFacturación";
            this.gbFacturación.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFacturación.Size = new System.Drawing.Size(644, 589);
            this.gbFacturación.TabIndex = 0;
            this.gbFacturación.TabStop = false;
            this.gbFacturación.Text = "Facturación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Facturar";
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Location = new System.Drawing.Point(571, 40);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(47, 15);
            this.lblCajero.TabIndex = 10;
            this.lblCajero.Text = "Cajero";
            // 
            // pbFacturar
            // 
            this.pbFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFacturar.Image = ((System.Drawing.Image)(resources.GetObject("pbFacturar.Image")));
            this.pbFacturar.Location = new System.Drawing.Point(530, 499);
            this.pbFacturar.Name = "pbFacturar";
            this.pbFacturar.Size = new System.Drawing.Size(73, 65);
            this.pbFacturar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFacturar.TabIndex = 9;
            this.pbFacturar.TabStop = false;
            this.pbFacturar.Click += new System.EventHandler(this.pbFacturar_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(541, 469);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(47, 15);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "####";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(494, 469);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 15);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(22, 469);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(80, 15);
            this.lblDatos.TabIndex = 6;
            this.lblDatos.Text = "Info. Cajero";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvFacturar);
            this.groupBox2.Location = new System.Drawing.Point(25, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 172);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos a Facturar";
            // 
            // gvFacturar
            // 
            this.gvFacturar.AllowUserToAddRows = false;
            this.gvFacturar.AllowUserToDeleteRows = false;
            this.gvFacturar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFacturar.Location = new System.Drawing.Point(16, 20);
            this.gvFacturar.Name = "gvFacturar";
            this.gvFacturar.Size = new System.Drawing.Size(562, 140);
            this.gvFacturar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvProductos);
            this.groupBox1.Location = new System.Drawing.Point(25, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Producto";
            // 
            // gvProductos
            // 
            this.gvProductos.AllowUserToAddRows = false;
            this.gvProductos.AllowUserToDeleteRows = false;
            this.gvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductos.Location = new System.Drawing.Point(16, 22);
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.Size = new System.Drawing.Size(562, 127);
            this.gvProductos.TabIndex = 0;
            this.gvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProductos_CellContentClick);
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(166, 76);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(189, 23);
            this.txtCodProducto.TabIndex = 3;
            this.txtCodProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProducto_KeyPress);
            // 
            // txtCajero
            // 
            this.txtCajero.Location = new System.Drawing.Point(166, 40);
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.Size = new System.Drawing.Size(189, 23);
            this.txtCajero.TabIndex = 2;
            this.txtCajero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCajero_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedúla Cajero:";
            // 
            // frmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(706, 636);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbFacturar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFacturación;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvProductos;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.TextBox txtCajero;
        private System.Windows.Forms.PictureBox pbFacturar;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvFacturar;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Label label3;
    }
}