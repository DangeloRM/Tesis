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
    public partial class frmProductoCantidad : Form
    {
        public Logica.Producto Producto { get; set; }
        public frmProductoCantidad()
        {
            InitializeComponent();
        }

        private void frmProductoCantidad_Load(object sender, EventArgs e)
        {
            txtCodProdu.Text = Producto.CodProducto.ToString();
            txtNombProduct.Text = Producto.Nombre;
            txtPrecio.Text = Producto.Precio.ToString();
            txtStock.Text = Producto.Cantidad.ToString();
            txtCantidad.Focus();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
            if (e.KeyChar == (Char)Keys.Enter)
            {

                ConfigurarCantidad();
            }
        }

        private void ConfigurarCantidad()
        {
            Logica.Producto pr = new Logica.Producto();
            pr = pr.ConsultarProducto(Producto.CodProducto);

            if (pr.Cantidad > Convert.ToInt32(txtCantidad.Text) || Convert.ToInt32(txtCantidad.Text) == pr.Cantidad) 
            {
                this.Producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                this.Producto.SubTotal = this.Producto.Cantidad * this.Producto.Precio;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No hay existencias en inventario!!", "Error de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void pbAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCantidad.Text))
            {
                int value = Convert.ToInt32(txtCantidad.Text);
                if (Producto.Cantidad > 0 && value > Convert.ToInt32(txtStock.Text))
                {
                    MessageBox.Show("Cantidad superior ó sin existencias en inventario!!", "Error de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    ConfigurarCantidad();
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese al menos un número", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
