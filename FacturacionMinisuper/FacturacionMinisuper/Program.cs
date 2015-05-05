using System;
using System.Windows.Forms;

namespace FacturacionMinisuper
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login myLogin = new Login();
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
}