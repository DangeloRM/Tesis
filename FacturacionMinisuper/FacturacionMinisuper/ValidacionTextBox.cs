using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionMinisuper
{
    public class ValidacionTextBox
    {
        public static void SoloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo se permiten Letras","Ingreso datos no validos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo se permiten Numeros", "Ingreso datos no validos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //public static void NumerosDecimales(KeyPressEventArgs v)
        //{
        //    if (Char.IsDigit(v.KeyChar))
        //    {
        //        v.Handled = false;
        //    }
        //    else if (Char.IsSeparator(v.KeyChar))
        //    {
        //        v.Handled = false;
        //    }
        //    else if (Char.IsControl(v.KeyChar))
        //    {
        //        v.Handled = false;
        //    }
        //    else if (v.KeyChar.ToString().Equals("."))
        //    {
        //        v.Handled = false;
        //    }
        //    else
        //    {
        //        v.Handled = true;
        //        MessageBox.Show("Solo numeros o numeros con punto decimal");
        //    }
        //}
    }
}
