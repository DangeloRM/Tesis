using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionMinisuper.Bitacora
{
    public partial class frmAgregarBitacora : Form
    {
        public frmAgregarBitacora()
        {
            InitializeComponent();
        }

        private void frmAgregarBitacora_Load(object sender, EventArgs e)
        {
            Logica.Bitacora objDistri = new Logica.Bitacora();
            txtCodigo.Text = objDistri.CodBitaco().ToString();
            txtCodigo.ReadOnly = true;
        }

        private void pbGuardarCjero_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text) && !string.IsNullOrEmpty(txtEvento.Text) && !string.IsNullOrEmpty(txtCajero.Text))
            {

                Logica.Gestor objGestor = new Logica.Gestor();
                int registrosAfectados = objGestor.AgregarBitacora(Convert.ToInt32(txtCodigo.Text),txtEvento.Text, Convert.ToInt32(txtCajero.Text));

                if (registrosAfectados > 0)
                {
                    MessageBox.Show("Bitácora Agregada correctamente!", "Bitácora Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("No se pudo Agregar la Bitácora", "Error al Agregar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                objGestor = null;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

            else
            {
                MessageBox.Show("Por favor ingrese todos los datos", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCajero_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ValidacionTextBox.SoloNumeros(e);
            }
            catch (Exception )
            {

                MessageBox.Show("Cajero Inexistente", "Verifique Datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }



    }
}
