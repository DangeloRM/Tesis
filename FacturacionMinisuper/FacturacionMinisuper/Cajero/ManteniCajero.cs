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
    public partial class ManteniCajero : Form
    {
        public ManteniCajero()
        {
            InitializeComponent();
        }

        private void CargarGrid()
        {
            Logica.Gestor objGestor = new Logica.Gestor();
            gvCajero.DataSource = objGestor.ConsultaMasivaCajero();
            objGestor = null;
            GC.Collect();
        }

        private void ManteniCajero_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void pbAgregarCajero_Click(object sender, EventArgs e)
        {
            frmAgregarCajero objAgregar = new frmAgregarCajero();
            objAgregar.ShowDialog();
            if (objAgregar.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
              CargarGrid();
            }

           }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (gvCajero.CurrentRow != null)
            {
                int idcajer = Convert.ToInt32(gvCajero.CurrentRow.Cells[0].Value.ToString());
                string nombre = gvCajero.CurrentRow.Cells[1].Value.ToString();
                string apellido = gvCajero.CurrentRow.Cells[2].Value.ToString();
                string telefon = gvCajero.CurrentRow.Cells[3].Value.ToString();
                string contrasena = gvCajero.CurrentRow.Cells[4].Value.ToString();
                string estado = gvCajero.CurrentRow.Cells[5].Value.ToString();
                Logica.Cajero objCajero = new Logica.Cajero(idcajer,nombre,apellido,telefon,contrasena,estado);

                frmActualizarCajero objActualizarCarj = new frmActualizarCajero();
                objActualizarCarj.CajeroModifi = objCajero;
                objActualizarCarj.ShowDialog();

                if (objActualizarCarj.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    CargarGrid();
                }
            }
        }

        private void gvCajero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvCajero_MouseClick(object sender, MouseEventArgs e)
        {
            if (gvCajero.CurrentRow != null)
            {
                DataGridViewRow rowActual = gvCajero.CurrentRow;
                string idCajeroSeleccionado = rowActual.Cells[0].Value.ToString();
                lblSeleccionado.Text = idCajeroSeleccionado;
            }

        }
        }
    
}
