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
    public partial class Login : Form
    {
        public Logica.Cajero myCajero { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pbIngresar_Click(object sender, EventArgs e)
        {
            Logica.Gestor myGestor = new Logica.Gestor();
            Logica.Cajero CJ = new Logica.Cajero();
            CJ = myGestor.IniciaSession(txtUser.Text.Trim());
            if (CJ != null)
            {
                if (CJ.Contrasena == txtContrasena.Text)
                {
                    this.myCajero = CJ;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    MessageBox.Show("Bienvenido(a) al sistema " + txtUser.Text, "Sistema Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Clear();
                    txtContrasena.Clear();
                    txtUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Sus datos no son correctos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas Salir del Sistema?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            Application.Exit();
            }
        }
    }
}
