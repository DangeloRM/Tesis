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
            this.Producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
            this.Producto.SubTotal = this.Producto.Cantidad * this.Producto.Precio;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void pbAceptar_Click(object sender, EventArgs e)
        {
            ConfigurarCantidad();
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
