using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cajero
    {
        #region Prop

        public int IDCajero { get; set; }
        public string NombreAcceso { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Contrasena { get; set; }
        public bool Estado { get; set; }
        public int IDTipoAcceso { get; set; }
        public bool Rol { get; set; }

        #endregion Prop

        #region Contruc
        public Cajero() { }

         public Cajero(int idcajero)
         {
            this.IDCajero = idcajero;
         }

        public Cajero(int pId, string pAcceso, string pPass, string pNombre, string pApellido, string pTelefono, bool pEstado, int pIdAcceso)
         {
            this.IDCajero = pId;
            this.NombreAcceso = pAcceso;
            this.Contrasena = pPass;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Telefono = pTelefono;
            this.Estado = pEstado;
         }

        public Cajero(string pAcceso, string pPass, string pNombre, string pApellido, string pTelefono, bool pEstado, int pIdAcceso)
        {
            this.NombreAcceso = pAcceso;
            this.Contrasena = pPass;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Telefono = pTelefono;
            this.Estado = pEstado;
        }

        public Cajero(int pId, string pAcceso, string pPass, string pNombre, string pApellido, string pTelefono, bool pEstado, int pIdAcceso, bool pRol)
        {
            this.IDCajero = pId;
            this.NombreAcceso = pAcceso;
            this.Contrasena = pPass;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Telefono = pTelefono;
            this.Estado = pEstado;
            this.IDTipoAcceso = pIdAcceso;
            this.Rol = pRol;
        }
        #endregion Contruc

        #region Operaciones Select
        /// <summary>
        /// Consulta Especifica Cajero
        /// </summary>
        /// <param name="idcajero"></param>
        /// <returns></returns>
        public Cajero ConsultarCajero(int Usuario)
        {
            Cajero objCajero = null;
            string consulta = string.Format("select c.IDCajero, c.NombreAcceso, c.Contrasena, c.Nombre, c.Apellido, c.Telefono, "                             +"c.Estado, c.IDTipoAcceso from Cajero c"
                                           + "where c.NombreAcceso = '{0}'", Usuario);
            Conexion.Conexion objDatos = new Conexion.Conexion();
            try
            {
                if (objDatos.AbrirConexion())
                {
                    DataTable dtResultado = objDatos.HacerSelect(consulta);
                    if (dtResultado != null && dtResultado.Rows.Count > 0)
                    {
                        int codCajer = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        string acceso = dtResultado.Rows[0][1].ToString();
                        string contrase = dtResultado.Rows[0][2].ToString();
                        string nomb = dtResultado.Rows[0][3].ToString();
                        string apelli = dtResultado.Rows[0][4].ToString();
                        string telf = dtResultado.Rows[0][5].ToString();
                        bool estad = Convert.ToBoolean(dtResultado.Rows[0][6]);
                        int idacceso = Convert.ToInt32(dtResultado.Rows[0][7]);
                        objCajero = new Cajero(codCajer, acceso, contrase, nomb, apelli, telf, estad, idacceso);
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
            return objCajero;
        }

        public Cajero InicioSesion(string Usuario)
        {
            Cajero objCajero = null;
            string consulta = string.Format("exec Acceso '{0}'", Usuario);
            Conexion.Conexion objDatos = new Conexion.Conexion();
            try
            {
                if (objDatos.AbrirConexion())
                {
                    DataTable dtResultado = objDatos.HacerSelect(consulta);
                    if (dtResultado != null && dtResultado.Rows.Count > 0)
                    {
                        int codCajer = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        string acceso = dtResultado.Rows[0][1].ToString();
                        string contrase = dtResultado.Rows[0][2].ToString();
                        string nomb = dtResultado.Rows[0][3].ToString();
                        string apelli = dtResultado.Rows[0][4].ToString();
                        string telf = dtResultado.Rows[0][5].ToString();
                        bool estad = Convert.ToBoolean(dtResultado.Rows[0][6].ToString());
                        int idacceso = Convert.ToInt32(dtResultado.Rows[0][7]);
                        string rol = dtResultado.Rows[0][8].ToString();
                        bool r = (rol == "1");
                        objCajero = new Cajero(codCajer, acceso, contrase, nomb, apelli, telf, estad, idacceso, r);
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
            return objCajero;
        }

        /// <summary>
        /// Consulta Masiva Cajeros
        /// </summary>
        /// <returns></returns>
        public DataTable ConsultaMasivaCajero()
        {
            DataTable dtCajero = new DataTable();
            string consulta = string.Format("select IDCajero as Código, NombreAcceso as Usuario, Contrasena as Contraseña, Nombre, Apellido, Telefono as Teléfono, Estado, IDTipoAcceso as Tipo_Acceso from Cajero ");
            Conexion.Conexion objDatos = new Conexion.Conexion();

            try
            {
                if (objDatos.AbrirConexion())
                {
                    dtCajero = objDatos.HacerSelect(consulta);
                    objDatos.CerrarConexion();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("HUBO UN ERROR", ex); 
            }
            objDatos = null;
            GC.Collect();
            return dtCajero;
        }

        #endregion Operaciones Select

        #region Operaciones Hit
        /// <summary>
        /// Actualizar  Cajero
        /// </summary>
        /// <param name="idcajero"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="telefono"></param>
        /// <param name="contrasena"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public int ActualizarCajero()
        {
            int registrosafectados = 0;

            string consulta = string.Format("update Cajero set NombreAcceso='{0}', Contrasena='{1}', Nombre='{2}', Apellido='{3}', Telefono= '{4}', Estado= 1, IDTipoAcceso= {5}" +
                                            "where idcajero = {6}", NombreAcceso, Contrasena, Nombre, Apellido, Telefono, Estado, IDTipoAcceso, IDCajero);

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

        /// <summary>
        /// Agregar   Cajero
        /// </summary>
        /// <param name="idcajero"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="telefono"></param>
        /// <param name="contrasena"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public int AgregarCajero()
        {
            int registrosafectados = 0;
            Conexion.Conexion objDatos = new Conexion.Conexion();

            string consulta = string.Format("exec SP_Cajero {0},'{1}','{2}', '{3}','{4}','{5}',1,2",IDCajero,NombreAcceso,Contrasena,Nombre,Apellido,Telefono,Estado,IDTipoAcceso);
            if (objDatos.AbrirConexion())
            {
               registrosafectados = objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();
            }
            objDatos = null;
            GC.Collect();
            return registrosafectados;
        }

        public int IdCajero()
        {
            int num = 0;
            string consulta = "select COUNT(*) as IDCajero from Cajero";
            Conexion.Conexion objDatos = new Conexion.Conexion();
            try
            {
                if (objDatos.AbrirConexion())
                {
                    DataTable dtResultado = objDatos.HacerSelect(consulta);
                    if (dtResultado != null && dtResultado.Rows.Count > 0)
                    {
                        int cod = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        num = cod + 1;

                    }
                    objDatos.CerrarConexion();
                }
            }
            catch (Exception)
            {

                num = 0;
            }
            objDatos = null;
            GC.Collect();
            return num;
        }

             
        #endregion Operaciones Hit

        #region Destruc

        ~Cajero()
        {
            this.IDCajero = 0;
            this.Nombre = null;
            this.Apellido = null;
            this.Telefono = null;
            this.Contrasena = null;
            this.Estado = false;
        }

        #endregion Destruc
    }
}
