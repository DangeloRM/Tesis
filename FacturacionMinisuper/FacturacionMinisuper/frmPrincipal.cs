using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionMinisuper
{
    public partial class pbBitacora : Form
    {
        public pbBitacora()
        {
            InitializeComponent();
        }

        private void pbDistribuidor_Click(object sender, EventArgs e)
        {
            Distribuidor.MenuDistribuidor objDistr = new Distribuidor.MenuDistribuidor();
            objDistr.ShowDialog();
        }

        private void pbCajero_Click(object sender, EventArgs e)
        {
            Cajero.ManteniCajero objCajer = new Cajero.ManteniCajero();
            objCajer.ShowDialog();
        }

        private void pbBita_Click(object sender, EventArgs e)
        {
            Bitacora.MantenimienBitacora objBitacora = new Bitacora.MantenimienBitacora();
            objBitacora.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Productos.MantenimiProducto objProducto = new Productos.MantenimiProducto();
            objProducto.ShowDialog();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmFacturar objFactura = new frmFacturar();
            objFactura.ShowDialog();
        }


    }
}
