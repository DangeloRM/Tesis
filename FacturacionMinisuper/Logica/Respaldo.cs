using System;

namespace Logica
{
    public class Respaldo
    {
        public int RealizarBackup()
        {
            int success = 0;
            string cmd = "USE Master "
                         + "BACKUP DATABASE DBFacturacionM1 "
                         + "TO DISK = 'C:\\Respaldo\\BackUp-" + DateTime.Today.Day
                         + "-" + DateTime.Today.Month
                         + "-" + DateTime.Today.Year
                         + "-" + DateTime.Now.Hour
                         + "-" + DateTime.Now.Minute
                         + "-" + DateTime.Now.Second
                         + ".bak' WITH NOINIT";
            Conexion.Conexion objDatos = new Conexion.Conexion();
            if (objDatos.AbrirConexion())
            {
                success = objDatos.Respaldo(cmd);
                objDatos.CerrarConexion();
            }
            objDatos = null;
            GC.Collect();
            return success;
        }
    }
}