﻿using System;
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
    public partial class frmPrincipal : Form
    {
        public Logica.Cajero CajeroConectado { get; set; }
        public frmPrincipal()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Productos.MantenimiProducto objProducto = new Productos.MantenimiProducto();
            objProducto.ShowDialog();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Login myLogin = new Login();
            this.Dispose();
            myLogin.ShowDialog();
            if (myLogin.DialogResult == DialogResult.OK)
            {
                frmPrincipal frm = new frmPrincipal();
                frm.CajeroConectado = myLogin.myCajero;
                myLogin.Dispose();
                frm.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmFacturar objFactura = new frmFacturar();
            objFactura.myCajero = this.CajeroConectado;
            objFactura.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Permisos del Formulario principal
            pbCajero.Enabled = CajeroConectado.Rol;
            pbDistribuidor.Enabled = CajeroConectado.Rol;
            pbProductos.Enabled = CajeroConectado.Rol;
        }
    }
}
