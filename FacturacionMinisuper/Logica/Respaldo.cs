using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class Respaldo
    {

       public void RealizarBackup()
       {
           string consulta = string.Format(@"backup database DBFacturacionM1 to disk ='C:\Respaldo\BackUp" + "-" + System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString()
                   + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString()
                   + "-" + System.DateTime.Now.Second.ToString() + ".bak' with init,stats=10");

           Conexion.Conexion objDatos = new Conexion.Conexion();
           if (objDatos.AbrirConexion())
           {
               objDatos.Respaldo(consulta);
               objDatos.CerrarConexion();
           }
           objDatos = null;
           GC.Collect();

       }
           
    }
}
