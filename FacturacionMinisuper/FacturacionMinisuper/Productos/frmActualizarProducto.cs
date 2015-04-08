using System;
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


        private void pbActualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodProdu.Text) && !string.IsNullOrEmpty(txtNombProduct.Text) && !string.IsNullOrEmpty(txtPrecio.Text) && !string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtDistri.Text) && !string.IsNullOrEmpty(txtNuevaCantidad.Text))
            {

                Logica.Gestor objGestor = new Logica.Gestor();
                int registrosAfectados = objGestor.ActualizarProducto(txtNombProduct.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtNuevaCantidad.Text), Convert.ToInt32(txtDistri.Text), txtCodProdu.Text);

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


        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
        }

        private void txtNuevaCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

 //       public void BuscarProducto()
 //       {
           
 //               Logica.Gestor objgestor = new Logica.Gestor();
 //               Logica.Producto objpro = new Logica.Producto();

 //               objpro = objgestor.ConsultarProducto(txtCodProdu.Text.ToString());
 //               if (objpro != null)
 //               {
 //                   txtNombProduct.Text = objpro.Nombre.ToString();
 //                   txtPrecio.Text = objpro.Precio.ToString();
 //                   txtCantidad.Text = objpro.Cantidad.ToString();
 //                   txtDistri.Text = objpro.CodDistribuidor.ToString();
 //               }
 //               else
 //   {
 //MessageBox.Show("Ingrese un Código ó Producto inexistente", "Error al Buscar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
 //   }

                
 //       }


        private void txtCodProdu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Logica.Gestor objGestor = new Logica.Gestor();
                Logica.Producto objprod = objGestor.ConsultarProducto(txtCodProdu.Text);
                if (objprod != null)
                {
                    txtNombProduct.Text = objprod.Nombre.ToString();
                    txtPrecio.Text = objprod.Precio.ToString();
                    txtCantidad.Text = objprod.Cantidad.ToString();
                    txtDistri.Text = objprod.CodDistribuidor.ToString();
                }
                else
                {
                    MessageBox.Show("Ingrese un Código ó Producto inexistente", "Error al Buscar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodProdu.Text = string.Empty;
                }
               
               
            }
           
        }


    }
}
