namespace FacturacionMinisuper.Cajero
{
    partial class frmActualizarCajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarCajero));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIDCajero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTelef = new System.Windows.Forms.Label();
            this.txtIdca = new System.Windows.Forms.TextBox();
            this.txtNombr = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tEstado = new System.Windows.Forms.CheckBox();
            this.txtTipoacces = new System.Windows.Forms.TextBox();
            this.txtNomAcceso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblContrase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 111);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblIDCajero
            // 
            this.lblIDCajero.AutoSize = true;
            this.lblIDCajero.Location = new System.Drawing.Point(163, 35);
            this.lblIDCajero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDCajero.Name = "lblIDCajero";
            this.lblIDCajero.Size = new System.Drawing.Size(71, 18);
            this.lblIDCajero.TabIndex = 1;
            this.lblIDCajero.Text = "IDCajero:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(169, 78);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // lblTelef
            // 
            this.lblTelef.AutoSize = true;
            this.lblTelef.Location = new System.Drawing.Point(166, 160);
            this.lblTelef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(68, 18);
            this.lblTelef.TabIndex = 4;
            this.lblTelef.Text = "Teléfono:";
            // 
            // txtIdca
            // 
            this.txtIdca.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtIdca.Location = new System.Drawing.Point(242, 32);
            this.txtIdca.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdca.Name = "txtIdca";
            this.txtIdca.ReadOnly = true;
            this.txtIdca.Size = new System.Drawing.Size(70, 24);
            this.txtIdca.TabIndex = 34;
            // 
            // txtNombr
            // 
            this.txtNombr.Location = new System.Drawing.Point(242, 75);
            this.txtNombr.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombr.MaxLength = 25;
            this.txtNombr.Name = "txtNombr";
            this.txtNombr.Size = new System.Drawing.Size(182, 24);
            this.txtNombr.TabIndex = 1;
            this.txtNombr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombr_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(242, 115);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(182, 24);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtTelefo
            // 
            this.txtTelefo.Location = new System.Drawing.Point(242, 157);
            this.txtTelefo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefo.MaxLength = 15;
            this.txtTelefo.Name = "txtTelefo";
            this.txtTelefo.Size = new System.Drawing.Size(121, 24);
            this.txtTelefo.TabIndex = 3;
            this.txtTelefo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefo_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(379, 377);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 48);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelar.TabIndex = 104;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(276, 377);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(64, 48);
            this.btnActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnActualizar.TabIndex = 105;
            this.btnActualizar.TabStop = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 107;
            this.label2.Text = "Guardar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 106;
            this.label1.Text = "Cancelar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tEstado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTipoacces);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomAcceso);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtContrasena);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblContrase);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblIDCajero);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTelef);
            this.groupBox1.Controls.Add(this.txtIdca);
            this.groupBox1.Controls.Add(this.txtNombr);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtTelefo);
            this.groupBox1.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 454);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizar Cajero";
            // 
            // tEstado
            // 
            this.tEstado.AutoSize = true;
            this.tEstado.Location = new System.Drawing.Point(242, 339);
            this.tEstado.Name = "tEstado";
            this.tEstado.Size = new System.Drawing.Size(15, 14);
            this.tEstado.TabIndex = 121;
            this.tEstado.UseVisualStyleBackColor = true;
            // 
            // txtTipoacces
            // 
            this.txtTipoacces.Location = new System.Drawing.Point(242, 294);
            this.txtTipoacces.Name = "txtTipoacces";
            this.txtTipoacces.Size = new System.Drawing.Size(70, 24);
            this.txtTipoacces.TabIndex = 120;
            // 
            // txtNomAcceso
            // 
            this.txtNomAcceso.Location = new System.Drawing.Point(242, 250);
            this.txtNomAcceso.Name = "txtNomAcceso";
            this.txtNomAcceso.Size = new System.Drawing.Size(182, 24);
            this.txtNomAcceso.TabIndex = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 118;
            this.label5.Text = "Tipo Acceso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 117;
            this.label4.Text = "Usuario:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(242, 206);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena.MaxLength = 20;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(182, 24);
            this.txtContrasena.TabIndex = 114;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(179, 336);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 18);
            this.lblEstado.TabIndex = 116;
            this.lblEstado.Text = "Estado:";
            // 
            // lblContrase
            // 
            this.lblContrase.AutoSize = true;
            this.lblContrase.Location = new System.Drawing.Point(146, 209);
            this.lblContrase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrase.Name = "lblContrase";
            this.lblContrase.Size = new System.Drawing.Size(88, 18);
            this.lblContrase.TabIndex = 115;
            this.lblContrase.Text = "Contraseña:";
            // 
            // frmActualizarCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(486, 481);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActualizarCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Cajero";
            this.Load += new System.EventHandler(this.frmActualizarCajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIDCajero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTelef;
        private System.Windows.Forms.TextBox txtIdca;
        private System.Windows.Forms.TextBox txtNombr;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefo;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox btnActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox tEstado;
        private System.Windows.Forms.TextBox txtTipoacces;
        private System.Windows.Forms.TextBox txtNomAcceso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblContrase;
    }
}