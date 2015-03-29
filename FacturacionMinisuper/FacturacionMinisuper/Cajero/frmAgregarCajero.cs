using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionMinisuper.Cajero
{
    public partial class frmAgregarCajero : Form
    {

        public frmAgregarCajero()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDCajero.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtTelef.Text) && !string.IsNullOrEmpty(txtContrasena.Text) && !string.IsNullOrEmpty(txtEstado.Text))
            {
                Logica.Gestor objGestor = new Logica.Gestor();

                int registrosAfectados = objGestor.AgregarCajero(Convert.ToInt32(txtIDCajero.Text), txtNombre.Text, txtApellido.Text, txtTelef.Text, txtContrasena.Text, txtEstado.Text);

                if (registrosAfectados > 0)
                {
                    MessageBox.Show("Cajero Agregado correctamente!", "Cajero Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("No se pudo Agregar el Cajero", "Error al Agregar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                objGestor = null;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

            else
            {
                MessageBox.Show("Por favor complete todos los espacios", "Espacios en incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void txtIDCajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloLetras(e);
        }

        private void txtTelef_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmAgregarCajero_Load(object sender, EventArgs e)
        {

        }

    
    }
}
