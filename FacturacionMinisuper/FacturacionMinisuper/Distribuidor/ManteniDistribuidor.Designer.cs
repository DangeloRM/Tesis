﻿namespace FacturacionMinisuper.Distribuidor
{
    partial class MenuDistribuidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDistribuidor));
            this.bdManteDistri = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.pbActualizaDistribu = new System.Windows.Forms.PictureBox();
            this.pbAgregaDis = new System.Windows.Forms.PictureBox();
            this.gvDistribuidor = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bdManteDistri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizaDistribu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregaDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDistribuidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bdManteDistri
            // 
            this.bdManteDistri.Controls.Add(this.label2);
            this.bdManteDistri.Controls.Add(this.label1);
            this.bdManteDistri.Controls.Add(this.lblSeleccionado);
            this.bdManteDistri.Controls.Add(this.pbActualizaDistribu);
            this.bdManteDistri.Controls.Add(this.pbAgregaDis);
            this.bdManteDistri.Controls.Add(this.gvDistribuidor);
            this.bdManteDistri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bdManteDistri.Location = new System.Drawing.Point(20, 39);
            this.bdManteDistri.Margin = new System.Windows.Forms.Padding(4);
            this.bdManteDistri.Name = "bdManteDistri";
            this.bdManteDistri.Padding = new System.Windows.Forms.Padding(4);
            this.bdManteDistri.Size = new System.Drawing.Size(591, 356);
            this.bdManteDistri.TabIndex = 0;
            this.bdManteDistri.TabStop = false;
            this.bdManteDistri.Text = "Mantenimiento Proveedor";
            this.bdManteDistri.Enter += new System.EventHandler(this.bdManteDistri_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Agregar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Editar";
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(54, 339);
            this.lblSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(0, 18);
            this.lblSeleccionado.TabIndex = 3;
            this.lblSeleccionado.Visible = false;
            // 
            // pbActualizaDistribu
            // 
            this.pbActualizaDistribu.BackColor = System.Drawing.Color.SteelBlue;
            this.pbActualizaDistribu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbActualizaDistribu.Image = ((System.Drawing.Image)(resources.GetObject("pbActualizaDistribu.Image")));
            this.pbActualizaDistribu.Location = new System.Drawing.Point(374, 15);
            this.pbActualizaDistribu.Margin = new System.Windows.Forms.Padding(4);
            this.pbActualizaDistribu.Name = "pbActualizaDistribu";
            this.pbActualizaDistribu.Size = new System.Drawing.Size(81, 63);
            this.pbActualizaDistribu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbActualizaDistribu.TabIndex = 2;
            this.pbActualizaDistribu.TabStop = false;
            this.pbActualizaDistribu.Click += new System.EventHandler(this.pbActualizaDistribu_Click);
            this.pbActualizaDistribu.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pbActualizaDistribu_ControlAdded);
            // 
            // pbAgregaDis
            // 
            this.pbAgregaDis.BackColor = System.Drawing.Color.SteelBlue;
            this.pbAgregaDis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAgregaDis.Image = ((System.Drawing.Image)(resources.GetObject("pbAgregaDis.Image")));
            this.pbAgregaDis.Location = new System.Drawing.Point(490, 15);
            this.pbAgregaDis.Margin = new System.Windows.Forms.Padding(4);
            this.pbAgregaDis.Name = "pbAgregaDis";
            this.pbAgregaDis.Size = new System.Drawing.Size(81, 63);
            this.pbAgregaDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgregaDis.TabIndex = 1;
            this.pbAgregaDis.TabStop = false;
            this.pbAgregaDis.Click += new System.EventHandler(this.pbAgregaDis_Click);
            // 
            // gvDistribuidor
            // 
            this.gvDistribuidor.AllowUserToAddRows = false;
            this.gvDistribuidor.AllowUserToDeleteRows = false;
            this.gvDistribuidor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvDistribuidor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gvDistribuidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDistribuidor.Location = new System.Drawing.Point(26, 102);
            this.gvDistribuidor.Margin = new System.Windows.Forms.Padding(4);
            this.gvDistribuidor.Name = "gvDistribuidor";
            this.gvDistribuidor.ReadOnly = true;
            this.gvDistribuidor.Size = new System.Drawing.Size(545, 233);
            this.gvDistribuidor.TabIndex = 0;
            this.gvDistribuidor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDistribuidor_CellContentClick);
            this.gvDistribuidor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gvDistribuidor_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Proveedores Inactivos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MenuDistribuidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(628, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bdManteDistri);
            this.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuDistribuidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Proveedor";
            this.Load += new System.EventHandler(this.MenuDistribuidor_Load);
            this.bdManteDistri.ResumeLayout(false);
            this.bdManteDistri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizaDistribu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregaDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDistribuidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox bdManteDistri;
        private System.Windows.Forms.PictureBox pbAgregaDis;
        private System.Windows.Forms.DataGridView gvDistribuidor;
        private System.Windows.Forms.PictureBox pbActualizaDistribu;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}