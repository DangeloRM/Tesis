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
    public partial class frmAgregarProducto : Form
    {
        public frmAgregarProducto()
        {
            InitializeComponent();
        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            ComboDistribuidor();
        }


        private void pbAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodProdu.Text) && !string.IsNullOrEmpty(txtNombProduct.Text)  && !string.IsNullOrEmpty(txtPrecio.Text) && !string.IsNullOrEmpty(txtNombreDistribui.Text))
            {

                Logica.Gestor objGestor = new Logica.Gestor();
                int registrosAfectados = objGestor.AgregarProducto(txtCodProdu.Text, txtNombProduct.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtCodDistribui.Text));

                if (registrosAfectados > 0 )
                {
                    MessageBox.Show("Producto Agregado correctamente!", "Producto Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                     MessageBox.Show("Producto", "Error al Agregar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                objGestor = null;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

            else
            {
                MessageBox.Show("Por favor ingrese todos los datos", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCodProdu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Logica.Gestor objGestor = new Logica.Gestor();
                Logica.Producto objProducto = objGestor.ConsultarProducto(txtCodProdu.Text);
                if (objProducto != null)
                {
                    MessageBox.Show("El producto ya esta en inventario!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodProdu.Text = string.Empty;
                }
                else
                {
                }

            }
        }


        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
        }

        private void pbCncelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public void ComboDistribuidor()
        {
            try
            {
                Logica.Gestor objGestor = new Logica.Gestor();
                txtNombreDistribui.DataSource = objGestor.ConsultaMasivaDistribuidores();
                txtNombreDistribui.DisplayMember = "Nombre";
                txtNombreDistribui.ValueMember = "Nombre";
                txtNombreDistribui.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error capturado: " +ex);
            }
        }

        private void pbBuscarDistri_Click_1(object sender, EventArgs e)
        {
            try
            {
                Logica.Gestor objgestor = new Logica.Gestor();
                Logica.Distribuidor objdistr = new Logica.Distribuidor();

                objdistr = objgestor.ConsultarDistribuidorNombre(txtNombreDistribui.Text.ToString());

                txtCodDistribui.Text = objdistr.CodDistribuidor.ToString();
                txtEstadoDistr.Text = objdistr.Estado;
                txtTelef.Text = objdistr.Telefono.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un Proveedor ó Proveedor Inexistente", "Error al Buscar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        }
}
