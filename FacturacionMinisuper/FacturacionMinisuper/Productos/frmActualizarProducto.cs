﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionMinisuper.Productos
{
    public partial class frmActualizarProducto : Form
    {
        public Logica.Producto ProductoModific { get; set; }
        public frmActualizarProducto()
        {
            InitializeComponent();
        }

        private void frmActualizarProducto_Load(object sender, EventArgs e)
        {
            txtNuevaCantidad.Text = "0";
        }


        private void pbBuscarProd_Click(object sender, EventArgs e)
        {
            try
            {
                Logica.Gestor objgestor = new Logica.Gestor();
                Logica.Producto objpro= new Logica.Producto();

                objpro = objgestor.ConsultarProducto(Convert.ToInt32(txtCodProdu.Text.ToString()));

                txtNombProduct.Text = objpro.Nombre.ToString();
                txtPrecio.Text = objpro.Precio.ToString();
                txtCantidad.Text = objpro.Cantidad.ToString();
                txtDistri.Text = objpro.CodDistribuidor.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un Código ó Producto inexistente", "Error al Buscar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pbActualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodProdu.Text) && !string.IsNullOrEmpty(txtNombProduct.Text) && !string.IsNullOrEmpty(txtPrecio.Text) && !string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtDistri.Text) && !string.IsNullOrEmpty(txtNuevaCantidad.Text))
            {

                Logica.Gestor objGestor = new Logica.Gestor();
                int registrosAfectados = objGestor.ActualizarProducto(txtNombProduct.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtNuevaCantidad.Text), Convert.ToInt32(txtDistri.Text), Convert.ToInt32(txtCodProdu.Text));

                if (registrosAfectados > 0)
                {
                    MessageBox.Show("Producto Actualizado correctamente!", "Producto Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("No se pudo Actualizar el Producto", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                objGestor = null;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

            else
            {
                MessageBox.Show("Por favor ingrese todos los datos", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
        }

        private void txtNuevaCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCodProdu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNuevaCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDistri_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
