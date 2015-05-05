using System;
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
            pbBitacora.Visible = CajeroConectado.Rol;
            lblBita.Visible = CajeroConectado.Rol;
            pbCajero.Visible = CajeroConectado.Rol;
            lblCaje.Visible = CajeroConectado.Rol;
            pbDistribuidor.Visible = CajeroConectado.Rol;
            lblPro.Visible = CajeroConectado.Rol;
            pbProductos.Visible = CajeroConectado.Rol;
            lblProd.Visible = CajeroConectado.Rol;
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
                proc.StartInfo.FileName = "C:\\ManualUsuario.pdf";
                proc.Start();
                proc.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede mostrar");
            }
        }

        private void pbRespaldo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas respaldar la base de datos?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Logica.Gestor objGestor = new Logica.Gestor();
                int success = objGestor.RealizarRespaldo();
                objGestor = null;
                if (success == -1)
                {
                    MessageBox.Show("Respaldo realizado correctamente!", "BackUp!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al respaldar!", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //    Logica.Gestor objGestor = new Logica.Gestor();
                //    int registrosAfectados = objGestor.RealizarRespaldo();

                //      if (registrosAfectados)
                //    {
                //        MessageBox.Show("Respaldo realizado correctamente!", "BackUp!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }

                //    else
                //    {
                //        MessageBox.Show("Respaldo", "Error al respaldar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    }

                //    objGestor = null;
                //    DialogResult = System.Windows.Forms.DialogResult.OK;
                //bool desea_respaldar = true;
                //    Cursor.Current = Cursors.WaitCursor;

                //    if (desea_respaldar)
                //    {
                //        SqlConnection connect;
                //        string con = "Data Source = DANGELO-PC; Initial Catalog=DBFacturacionM1 ;Integrated Security = True;";
                //        connect = new SqlConnection(con);
                //        connect.Open();
                //        SqlCommand command;
                //        command = new SqlCommand(@"backup database DBFacturacionM1 to disk ='C:\Respaldo\BackUp" + "-" + System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString()
                //         + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString()
                //         + "-" + System.DateTime.Now.Second.ToString() + ".bak' with init,stats=10", connect);
                //        command.ExecuteNonQuery();
                //        connect.Close();

                //        MessageBox.Show("El Respaldo de la base de datos fue realizado satisfactoriamente!!", "Respaldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
            }
        }
    }
}