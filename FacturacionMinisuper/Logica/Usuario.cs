using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Usuario
    {
        #region Prop

        public string Password { get; set; }
        public string NombreUsuario { get; set; }
        public int IdTipoUsu { get; set; }

        #endregion Prop

        #region Construc

        public Usuario()
        { 

        }

        public Usuario(string password, string nombreusuario, int idtipousuario)
        {
            this.Password = password;
            this.NombreUsuario = nombreusuario;
            this.IdTipoUsu = idtipousuario;
        }

        #endregion Construc

        #region Operacion Select
        /// <summary>
        /// Consulta Especifica del Administrador
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public Usuario ConsultarUsuario(string password)
        { 
         Usuario objUsua = null;
        string consulta = string.Format("Select Password, NombreUsuario, IdTipoUsuario from Administrador where Password = '(0)'", password);

        Conexion.Conexion objDatos = new Conexion.Conexion();

        try
        {
            if (objDatos.AbrirConexion())
            {
                DataTable dtResultado = objDatos.HacerSelect(consulta);

                if (dtResultado != null && dtResultado.Rows.Count >0)
                {
                    objUsua = new Usuario(Password,NombreUsuario,IdTipoUsu);

                    string pass = dtResultado.Rows[0][0].ToString();
                    string nomb = dtResultado.Rows[0][1].ToString();
                    int idtipo = Convert.ToInt32(dtResultado.Rows[0][2].ToString());
                    
                }
                objDatos.CerrarConexion();
            }            
        }
        catch (Exception ex)
        {
            Console.WriteLine("HUBO UN ERROR", ex); 
        }
        objDatos = null;
        GC.Collect();
        return objUsua;
        }
        

        #endregion Operacion Select

        #region Operacion Hit

        public int ActualizarUser()
        {
            int registrosafectados = 0;

            string consulta = string.Format("Update Usuario set NombreUsuario= '{0}', IdTipoUsuario = {1} where Password = '{2}'",NombreUsuario,IdTipoUsu,Password);

            Conexion.Conexion objDatos = new Conexion.Conexion();
            if (objDatos.AbrirConexion())
            {
                objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();
            }
            objDatos = null;
            GC.Collect();
            return registrosafectados;
        }

        #endregion Operacion Hit

        #region Destruc

        ~Usuario()
        {
            this.Password = null;
            this.NombreUsuario = null;
            this.IdTipoUsu = 0;
        }

        #endregion Destruc
    }
}
