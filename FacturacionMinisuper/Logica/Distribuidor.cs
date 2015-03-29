using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Distribuidor
    {
        #region Propi

        public int CodDistribuidor { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Telefono { get; set; }   


        #endregion Propi

        #region Constru
        public Distribuidor()
        {

        }

        public Distribuidor(string nombre)
        {
            this.Nombre = nombre;
        }

        public Distribuidor(int codditribuidor, string nombre, string estado, string telefono)
        {
            this.CodDistribuidor = codditribuidor;
            this.Nombre = nombre;
            this.Estado = estado;
            this.Telefono = telefono;     

        }

        #endregion Construc

        #region Operaciones Select
        /// <summary>
        /// Consulta Especifica de Distribuidores
        /// </summary>
        /// <param name="coddistribuidor"></param>
        /// <returns></returns>
        public Distribuidor ConsultarDistribuidor(int coddistribuidor)
        { 
        Distribuidor objDistribuidor = null;
        string consulta = string.Format("Select CodDistribuidor, Nombre, Estado, Telefono" +
                                        "from Distribuidor where CodDistribuidor = (0)", coddistribuidor);

        Conexion.Conexion objDatos = new Conexion.Conexion();

        try
        {
            if (objDatos.AbrirConexion())
            {
                DataTable dtResultado = objDatos.HacerSelect(consulta);

                if (dtResultado != null && dtResultado.Rows.Count >0)
                {
                    
                    int codDis = Convert.ToInt32(dtResultado.Rows[0][0]);
                    string nomb = dtResultado.Rows[0][1].ToString();
                    string estad = dtResultado.Rows[0][2].ToString();
                    string telf = dtResultado.Rows[0][3].ToString();

                    objDistribuidor = new Distribuidor(codDis, nomb, estad, telf);
                    
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
        return objDistribuidor;
        }

        public Distribuidor ConsultarDistribuidorNomb(string nombre)
        {
            Distribuidor objDistribuidor = null;
            string consulta = string.Format("Select CodDistribuidor, Nombre, Estado, Telefono from Distribuidor where Nombre = '{0}'", nombre);

            Conexion.Conexion objDatos = new Conexion.Conexion();

            try
            {
                if (objDatos.AbrirConexion())
                {
                    DataTable dtResultado = objDatos.HacerSelect(consulta);

                    if (dtResultado != null && dtResultado.Rows.Count > 0)
                    {
                        int codDis = Convert.ToInt32(dtResultado.Rows[0][0]);
                        string nom = dtResultado.Rows[0][1].ToString();
                        string estad = dtResultado.Rows[0][2].ToString();
                        string telf = dtResultado.Rows[0][3].ToString();
                        objDistribuidor = new Distribuidor(codDis,nom,estad,telf);
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
            return objDistribuidor;
        }

        /// <summary>
        /// Consulta Masiva Distribuidores
        /// </summary>
        /// <returns></returns>
        public DataTable ConsultaMasivaDistribuidores()
        {
            DataTable dtDistribuidor = new DataTable();
            string consulta = string.Format("Select CodDistribuidor as Código, Nombre, Estado, Telefono as Teléfono from Distribuidor where Estado = 'Activo'");
            Conexion.Conexion objDatos = new Conexion.Conexion();

            try
            {
                if (objDatos.AbrirConexion())
                {
                    dtDistribuidor = objDatos.HacerSelect(consulta);
                    objDatos.CerrarConexion();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("HUBO UN ERROR", ex);
            }

            objDatos = null;
            GC.Collect();
            return dtDistribuidor;
        }

        public DataTable ConsultaMasivaDistribuidoresInactivos()
        {
            DataTable dtDistribuidor = new DataTable();
            string consulta = string.Format("Select CodDistribuidor as Código, Nombre, Estado, Telefono as Teléfono from Distribuidor where Estado = 'Inactivo'");
            Conexion.Conexion objDatos = new Conexion.Conexion();

            try
            {
                if (objDatos.AbrirConexion())
                {
                    dtDistribuidor = objDatos.HacerSelect(consulta);
                    objDatos.CerrarConexion();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("HUBO UN ERROR", ex);
            }

            objDatos = null;
            GC.Collect();
            return dtDistribuidor;
        }
        #endregion Operaciones Select

        #region Operaciones Hit
        /// <summary>
        /// ActualizarDistribuidor
        /// </summary>
        /// <param name="coddistribuidor"></param>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <param name="telefono"></param>
        /// <returns></returns>
        public int ActualizarDistribuidor()
        {
            int registrosafectados = 0;

            string consulta = string.Format("update Distribuidor set Nombre='{0}', Estado='{1}', Telefono='{2}'"+
                                            "where CodDistribuidor = {3}", Nombre, Estado, Telefono, CodDistribuidor);

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
        /// Agregar Distribuidor
        /// </summary>
        /// <param name="coddistribuidor"></param>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <param name="telefono"></param>
        /// <returns></returns>
        public int AgregarDistribuidor()
        {
            int registrosafectados = 0;
            Conexion.Conexion objDatos = new Conexion.Conexion();

            string consulta = string.Format("exec AgregarDistribuidor {0},'{1}','{2}','{3}' ", CodDistribuidor, Nombre, Estado, Telefono);
            if (objDatos.AbrirConexion())
            {
                registrosafectados = objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();
            }
            objDatos = null;
            GC.Collect();
            return registrosafectados;
        }

        public int CodDistr()
        {
            int num = 0;
            string consulta = "select COUNT(*) as Codigo from Distribuidor";
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

        ~Distribuidor()
        {
            this.CodDistribuidor = 0;
            this.Nombre = null;
            this.Estado = null;
            this.Telefono = null;
        }

        #endregion Destruc
    }

    }
