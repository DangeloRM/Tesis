namespace FacturacionMinisuper.Distribuidor
{
    partial class frmActualizarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarProveedor));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.PictureBox();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.txtTelefo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodDistrib = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 409);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 118;
            this.label2.Text = "Guardar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 409);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 117;
            this.label1.Text = "Cancelar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(388, 351);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(85, 55);
            this.btnActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnActualizar.TabIndex = 116;
            this.btnActualizar.TabStop = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.txtEstado.Location = new System.Drawing.Point(170, 252);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(5);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(250, 23);
            this.txtEstado.TabIndex = 1;
            // 
            // txtTelefo
            // 
            this.txtTelefo.Location = new System.Drawing.Point(170, 304);
            this.txtTelefo.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefo.MaxLength = 15;
            this.txtTelefo.Name = "txtTelefo";
            this.txtTelefo.ReadOnly = true;
            this.txtTelefo.Size = new System.Drawing.Size(250, 23);
            this.txtTelefo.TabIndex = 112;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(170, 201);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(250, 23);
            this.txtNombre.TabIndex = 108;
            // 
            // txtCodDistrib
            // 
            this.txtCodDistrib.Location = new System.Drawing.Point(170, 145);
            this.txtCodDistrib.Margin = new System.Windows.Forms.Padding(5);
            this.txtCodDistrib.Name = "txtCodDistrib";
            this.txtCodDistrib.ReadOnly = true;
            this.txtCodDistrib.Size = new System.Drawing.Size(250, 23);
            this.txtCodDistrib.TabIndex = 115;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(83, 307);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 15);
            this.lblTelefono.TabIndex = 114;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(83, 255);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(49, 15);
            this.lblEstado.TabIndex = 113;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(83, 204);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 15);
            this.lblNombre.TabIndex = 111;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(83, 148);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 15);
            this.lblCodigo.TabIndex = 109;
            this.lblCodigo.Text = "Código:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(272, 351);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 55);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelar.TabIndex = 119;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmActualizarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(520, 438);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtTelefo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodDistrib);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Footlight MT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActualizarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Estado Proveedor";
            this.Load += new System.EventHandler(this.frmActualizarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnActualizar;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.TextBox txtTelefo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodDistrib;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCancelar;

    }
}