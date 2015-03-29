using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MovInventario
    {

        #region Prop

        public int CodInventario { get; set; }
        public DateTime FechaRealizacion { get; set; }
        public int CodProducto { get; set; }

        #endregion Prop

        #region Construc

        public MovInventario() 
        {

        }

        public MovInventario(int codinventario, DateTime fecharealizacion, int codproducto)
        {
            this.CodInventario = codinventario;
            this.FechaRealizacion = fecharealizacion;
            this.CodProducto = codproducto;

        }

        #endregion Construc

        #region Operacion Select
        /// <summary>
        /// Consulta Especifica MovInventario
        /// </summary>
        /// <param name="codinventario"></param>
        /// <returns></returns>
        public MovInventario ConsultarMovInventario(int codinventario)
        {
            MovInventario objMovInventario = null;
            string consulta = string.Format("Select codinventario, fecharealizacion, codproducto from MovInventario where codinventario = (0)", codinventario);

            Conexion.Conexion objDatos = new Conexion.Conexion();

            try
            {
                if (objDatos.AbrirConexion())
                {
                    DataTable dtResultado = objDatos.HacerSelect(consulta);

                    if (dtResultado != null && dtResultado.Rows.Count > 0)
                    {
                        objMovInventario = new MovInventario(CodInventario, FechaRealizacion, CodProducto);

                        int codinv = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        System.DateTime fecharealiz = Convert.ToDateTime(dtResultado.Rows[0][1].ToString());
                        int codpr = Convert.ToInt32(dtResultado.Rows[0][2].ToString());

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
            return objMovInventario;
        }


        /// <summary>
        /// Consulta Masiva MovInventarios
        /// </summary>
        /// <returns></returns>
        public DataTable ConsultaMasivaMovInventarios()
        {
            DataTable dtMovInvent = new DataTable();
            string consulta = string.Format("Select codinventario, fecharealizacion, codproducto from MovInventario");
            Conexion.Conexion objDatos = new Conexion.Conexion();

            try
            {
                if (objDatos.AbrirConexion())
                {
                    dtMovInvent = objDatos.HacerSelect(consulta);
                    objDatos.CerrarConexion();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("HUBO UN ERROR", ex); 
            }
            objDatos = null;
            GC.Collect();
            return dtMovInvent;
        }

        #endregion Operacion Select

        #region Operaciones Hit

        /// <summary>
        /// Actualizar MovInventario
        /// </summary>
        /// <returns></returns>
        public int ActualizarMovInventario()
        {
            int registrosafectados = 0;

            string consulta = string.Format("update MovInventario set fecharealizacion='{0}', " +
                                            "where codinventario = {1}", FechaRealizacion,  CodInventario);

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
        /// Agregar  MovInventario
        /// </summary>
        /// <param name="codinventario"></param>
        /// <param name="fecharealizacion"></param>
        /// <param name="cantidadprod"></param>
        /// <returns></returns>
        public int AgregarMovInventario()
        {
            int registrosafectados = 0;
            Conexion.Conexion objDatos = new Conexion.Conexion();

            string consulta = string.Format(" ", CodInventario, FechaRealizacion.ToString("yyyy-MM-dd"));
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

        ~MovInventario()
        {
            this.CodInventario = 0;
 
        }

        #endregion Destruc

    }
}
