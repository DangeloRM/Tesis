using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionMinisuper.Distribuidor
{
    public partial class frmActualizarDistribu : Form
    {
        public Logica.Distribuidor ActuDistribuidor { get; set; }
        public frmActualizarDistribu()
        {
            InitializeComponent();
        }

        private void frmActualizarDistribu_Load(object sender, EventArgs e)
        {
            txtCodDistrib.Text = ActuDistribuidor.CodDistribuidor.ToString();
            txtNombre.Text = ActuDistribuidor.Nombre;
            txtEstado.Text = ActuDistribuidor.Estado;
            txtTelefo.Text = ActuDistribuidor.Telefono;


        }

        private void txtTelefo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
        }


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtEstado.Text) && !string.IsNullOrEmpty(txtTelefo.Text) && !string.IsNullOrEmpty(txtCodDistrib.Text))
            {
                Gestor objGestor = new Gestor();
                int registrosAfectados = objGestor.ActualizarDistribuidor(txtNombre.Text, txtEstado.Text, txtTelefo.Text, Convert.ToInt32(txtCodDistrib.Text));

                if (registrosAfectados >= 0)
                {
                    MessageBox.Show("El Proveedor: "+ txtNombre.Text + ", se actualizo correctamente!", "Proveedor Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("No se pudo Actualizar el Proveedor", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                objGestor = null;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

            else
            {
                MessageBox.Show("Por favor ingrese todos los datos", "Datos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




    }
}
