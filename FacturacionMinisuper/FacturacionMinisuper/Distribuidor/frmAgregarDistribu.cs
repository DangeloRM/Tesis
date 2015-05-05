using System;
using System.Windows.Forms;

namespace FacturacionMinisuper.Distribuidor
{
    public partial class frmAgregarDistribu : Form
    {
        public Logica.Distribuidor AgregDistr { get; set; }

        public frmAgregarDistribu()
        {
            InitializeComponent();
        }

        private void frmAgregarDistribu_Load(object sender, EventArgs e)
        {
            Logica.Distribuidor objDistri = new Logica.Distribuidor();
            txtCodDis.Text = objDistri.CodDistr().ToString();
            txtCodDis.ReadOnly = true;
            txtEstad.Text = "Activo";
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodDis.Text) && !string.IsNullOrEmpty(txtNomb.Text) && !string.IsNullOrEmpty(txtEstad.Text) && !string.IsNullOrEmpty(txtTelefono.Text))
            {
                Logica.Gestor objGestor = new Logica.Gestor();
                int registrosAfectados = objGestor.AgregarDistribuidor(Convert.ToInt32(txtCodDis.Text), txtNomb.Text, txtEstad.Text, txtTelefono.Text);

                if (registrosAfectados > 0)
                {
                    MessageBox.Show("El Proveedor:" + txtNomb.Text + ",se agrego correctamente!", "Proveedor Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo Agregar el Proveedor", "Error al Agregar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                objGestor = null;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los datos", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtNomb_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}