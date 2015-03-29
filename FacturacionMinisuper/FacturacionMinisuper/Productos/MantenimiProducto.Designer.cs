namespace FacturacionMinisuper.Productos
{
    partial class MantenimiProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimiProducto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.pbAgregar = new System.Windows.Forms.PictureBox();
            this.gvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbEditar);
            this.groupBox1.Controls.Add(this.pbAgregar);
            this.groupBox1.Controls.Add(this.gvProductos);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(20, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(628, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Agregar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Editar";
            // 
            // pbEditar
            // 
            this.pbEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(379, 25);
            this.pbEditar.Margin = new System.Windows.Forms.Padding(4);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(81, 63);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 2;
            this.pbEditar.TabStop = false;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // pbAgregar
            // 
            this.pbAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("pbAgregar.Image")));
            this.pbAgregar.Location = new System.Drawing.Point(482, 25);
            this.pbAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.pbAgregar.Name = "pbAgregar";
            this.pbAgregar.Size = new System.Drawing.Size(81, 63);
            this.pbAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgregar.TabIndex = 1;
            this.pbAgregar.TabStop = false;
            this.pbAgregar.Click += new System.EventHandler(this.pbAgregar_Click);
            // 
            // gvProductos
            // 
            this.gvProductos.AllowUserToAddRows = false;
            this.gvProductos.AllowUserToDeleteRows = false;
            this.gvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductos.Location = new System.Drawing.Point(25, 109);
            this.gvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.gvProductos.Name = "gvProductos";
            this.gvProductos.ReadOnly = true;
            this.gvProductos.Size = new System.Drawing.Size(561, 292);
            this.gvProductos.TabIndex = 0;
            this.gvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProductos_CellContentClick);
            // 
            // MantenimiProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(665, 482);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimiProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Producto";
            this.Load += new System.EventHandler(this.MantenimiProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.PictureBox pbAgregar;
        private System.Windows.Forms.DataGridView gvProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}