using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            if (MessageBox.Show("Deseas Cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            pbBitacora.Enabled = CajeroConectado.Rol;
            pbRespaldo.Enabled = CajeroConectado.Rol;
            pbCajero.Enabled = CajeroConectado.Rol;
            pbDistribuidor.Enabled = CajeroConectado.Rol;
            pbProductos.Enabled = CajeroConectado.Rol;
            pbBitacora.Enabled = CajeroConectado.Rol;
        }

        private void pbBitacora_Click(object sender, EventArgs e)
        {
           Bitacora.frmReporteBitacora objReportes = new Bitacora.frmReporteBitacora();
           objReportes.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pbManual_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "C:\\scanner.pdf";
                proc.Start();
                proc.Close();
                //Process.Start( @"C:\\Manual.pdf");
                //Application.StartupPath + 
                //string pdfPath = Path.Combine(Application.StartupPath, "archivo.pdf");
                //Process.Start(pdfPath);
            }
            catch (Exception)            {
                MessageBox.Show("No se puede mostrar");
            }
        }

        private void pbRespaldo_Click(object sender, EventArgs e)
        {

            bool desea_respaldar = true;
            Cursor.Current = Cursors.WaitCursor;

           if (desea_respaldar)
            {
                SqlConnection connect;
                string con = "Data Source = DANGELO-PC; Initial Catalog=DBFacturacionM ;Integrated Security = True;";
                connect = new SqlConnection(con);
                connect.Open();
                SqlCommand command;
                command = new SqlCommand(@"backup database DBFacturacionM to disk ='C:\Respaldo\BackUp" + System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString()
                 + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString()
                 + "-" + System.DateTime.Now.Second.ToString() + ".bak' with init,stats=10", connect);
                command.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("El Respaldo de la base de datos fue realizado satisfactoriamente!!", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
