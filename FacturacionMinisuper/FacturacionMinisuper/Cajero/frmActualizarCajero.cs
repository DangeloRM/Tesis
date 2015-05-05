using Logica;
using System;
using System.Windows.Forms;

namespace FacturacionMinisuper.Cajero
{
    public partial class frmActualizarCajero : Form
    {
        public Logica.Cajero CajeroModifi { get; set; }

        public frmActualizarCajero()
        {
            InitializeComponent();
        }

        private void frmActualizarCajero_Load(object sender, EventArgs e)
        {
            txtIdca.Text = CajeroModifi.IDCajero.ToString();
            txtNombr.Text = CajeroModifi.Nombre;
            txtApellido.Text = CajeroModifi.Apellido;
            txtTelefo.Text = CajeroModifi.Telefono;
            txtNomAcceso.Text = CajeroModifi.NombreAcceso;
            txtTipoacces.Text = CajeroModifi.IDTipoAcceso.ToString();
            txtContrasena.Text = CajeroModifi.Contrasena;
            tEstado.Checked = CajeroModifi.Estado;
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombr.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtTelefo.Text) && !string.IsNullOrEmpty(txtContrasena.Text) && !string.IsNullOrEmpty(txtNomAcceso.Text) && !string.IsNullOrEmpty(txtTipoacces.Text))
            {
                Gestor objGestor = new Gestor();
                int registrosAfectados = objGestor.ActualizarCajero(Convert.ToInt32(txtIdca.Text), txtNomAcceso.Text, txtContrasena.Text, txtNombr.Text, txtApellido.Text, txtTelefo.Text, Convert.ToBoolean(tEstado.Checked), Convert.ToInt32(txtTipoacces.Text));

                if (registrosAfectados >= 0)
                {
                    MessageBox.Show("El Cajero: " + txtNombr.Text + ",se actualizo correctamente!", "Cajero Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo Actualizar el Cajero", "Error al Agregar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                objGestor = null;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Por favor complete todos los espacios", "Espacios en incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNombr_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloLetras(e);
        }

        private void txtTelefo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTipoacces_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
        }

        private void txtEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (tEstado.Checked)
            {
                tEstado.Text = "1";
            }
            else
            {
                tEstado.Text = "0";
            }
        }
    }
}