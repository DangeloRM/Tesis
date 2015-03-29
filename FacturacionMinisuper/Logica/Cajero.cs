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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }

        #endregion Prop

        #region Contruc

        public Cajero()
        {

        }

         public Cajero(int idcajero)
             {
            this.IDCajero = idcajero;
             }

        public Cajero(int idcajero, string nombre, string apellido, string telefono, string contrasena, string estado)
        {
            this.IDCajero = idcajero;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Contrasena = contrasena;
            this.Estado = estado;
        }
        #endregion Contruc

        #region Operaciones Select
        /// <summary>
        /// Consulta Especifica Cajero
        /// </summary>
        /// <param name="idcajero"></param>
        /// <returns></returns>
        public Cajero ConsultarCajero(int idcajero)
        {
            Cajero objCajero = null;
            string consulta = string.Format("Select idcajero, nombre, apellido, telefono, contrasena, estado from Cajero" +
                                          "where idcajero = (0)", idcajero);

            Conexion.Conexion objDatos = new Conexion.Conexion();

            try
            {
                if (objDatos.AbrirConexion())
                {
                    DataTable dtResultado = objDatos.HacerSelect(consulta);

                    if (dtResultado != null && dtResultado.Rows.Count > 0)
                    {
                        int codCajer = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        string nomb = dtResultado.Rows[0][1].ToString();
                        string apelli = dtResultado.Rows[0][2].ToString();
                        string telf = dtResultado.Rows[0][3].ToString();
                        string contrase = dtResultado.Rows[0][4].ToString();
                        string estad = dtResultado.Rows[0][5].ToString();

                        objCajero = new Cajero(codCajer,nomb,apelli,telf,contrase,estad);
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


        public Cajero ConsultarCajeroBita(int idcajero)
        {
            Cajero objCajero = null;
            string consulta = string.Format("Select idcajero from Cajero where idcajero = (0)", idcajero);

            Conexion.Conexion objDatos = new Conexion.Conexion();

            try
            {
                if (objDatos.AbrirConexion())
                {
                    DataTable dtResultado = objDatos.HacerSelect(consulta);

                    if (dtResultado != null && dtResultado.Rows.Count > 0)
                    {
                        objCajero = new Cajero(IDCajero);

                        int codCajer = Convert.ToInt32(dtResultado.Rows[0][0].ToString());

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
            string consulta = string.Format("select IDCajero as Cédula,Nombre,Apellido,Telefono, Contrasena as Contraseña, Estado from Cajero");
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

            string consulta = string.Format("update Cajero set nombre='{0}', apellido='{1}', telefono='{2}', contrasena='{3}', estado= '{4}' " +
                                            "where idcajero = {5}", Nombre, Apellido, Telefono, Contrasena, Estado, IDCajero);

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

            string consulta = string.Format("insert into Cajero (idcajero,nombre,apellido,telefono,contrasena, estado) values({0},'{1}','{2}','{3}', '{4}', '{5}' )", IDCajero, Nombre, Apellido, Telefono, Contrasena, Estado);
            if (objDatos.AbrirConexion())
            {
               registrosafectados = objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();
            }
            objDatos = null;
            GC.Collect();
            return registrosafectados;
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
            this.Estado = null;
        }

        #endregion Destruc
    }
}
