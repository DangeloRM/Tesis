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
            txtCantidad.Focus();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                ConfigurarCantidad();
            }
        }

        private void ConfigurarCantidad()
        {
            //Logica.Producto pr = new Logica.Producto();
            //pr = pr.ConsultarProducto(Producto.CodProducto);
            if (Producto.Cantidad > 0 || Producto.Cantidad == 1)
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
            if (Producto.Cantidad > 0 || Producto.Cantidad == 1)
            {
            ConfigurarCantidad();
            }
            else
            {
                MessageBox.Show("No hay existencias en inventario!!", "Error de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
