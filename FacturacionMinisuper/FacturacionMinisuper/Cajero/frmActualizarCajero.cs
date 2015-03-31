using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

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
            txtContrasena.Text = CajeroModifi.Contrasena;
            //txtEstado.Text = CajeroModifi.Estado;

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtNombr.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtTelefo.Text) && !string.IsNullOrEmpty(txtContrasena.Text) && !string.IsNullOrEmpty(txtIdca.Text) && !string.IsNullOrEmpty(txtEstado.Text))
            //{
            //    Gestor objGestor = new Gestor();
            //    int registrosAfectados = objGestor.ActualizarCajero(txtNombr.Text, txtApellido.Text, txtTelefo.Text, txtContrasena.Text, txtEstado.Text, Convert.ToInt32(txtIdca.Text));

            //    if (registrosAfectados >= 0)
            //    {
            //        MessageBox.Show("Distribuidor Agregado correctamente!", "Distribuidor Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //    else
            //    {
            //        MessageBox.Show("No se pudo Agregar el Distribuidor", "Error al Agregar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //    objGestor = null;
            //    DialogResult = System.Windows.Forms.DialogResult.OK;
            //}

            //else
            //{
            //    MessageBox.Show("Por favor complete todos los espacios", "Espacios en incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
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

       

      
    }
}
