using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Bitacora
    {

        #region Prop
        public int CodBitacora { get; set; }
        public string Evento { get; set; }
        public int IDCajero { get; set; }

        #endregion Prop

        #region Contruc

        public Bitacora()
        {

        }

        public Bitacora(int codbitacora, string evento,  int idcajero)
        {
            this.CodBitacora = codbitacora;
            this.Evento = evento;
            this.IDCajero = idcajero;
        }

        #endregion Contruc


        #region Opraciones Select
        
        /// <summary>
        /// Consultar Bitacora
        /// </summary>
        /// <param name="codbitacora"></param>
        /// <returns></returns>
        public Bitacora ConsultarBitacora(int codbitacora)
        {
            Bitacora objBitacora = null;
            string consulta = string.Format("Select CodBitacora, Evento, IDCajero from Factura where CodBitacora = (0)", codbitacora);

            Conexion.Conexion objDatos = new Conexion.Conexion();

            try
            {
                if (objDatos.AbrirConexion())
                {
                    DataTable dtResultado = objDatos.HacerSelect(consulta);

                    if (dtResultado != null && dtResultado.Rows.Count > 0)
                    {
                        int codbitac = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        string even = dtResultado.Rows[0][1].ToString();
                        int idcaje = Convert.ToInt32(dtResultado.Rows[0][2].ToString());

                        objBitacora = new Bitacora(codbitac, even,  idcaje);

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
            return objBitacora;
        }



        /// <summary>
        /// Consulta Masiva Bitacora
        /// </summary>
        /// <returns></returns>
        public DataTable ConsultaMasivaBitacora()
        {
            DataTable dtBitacora = new DataTable();
            string consulta = string.Format("Select codbitacora as Código, Evento, Fecha as Fecha_Realización, idcajero as Cédula_Cajero from Bitacora");
            Conexion.Conexion objDatos = new Conexion.Conexion();

            try
            {
                if (objDatos.AbrirConexion())
                {
                    dtBitacora = objDatos.HacerSelect(consulta);
                    objDatos.CerrarConexion();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("HUBO UN ERROR", ex); 
            }
            objDatos = null;
            GC.Collect();
            return dtBitacora;
        }

        #endregion Opraciones Select


        #region Operaciones Hit

        /// <summary>
        /// Agregar Bitacora
        /// </summary>
        /// <param name="codbitacora"></param>
        /// <param name="evento"></param>
        /// <param name="fecha"></param>
        /// <param name="idcajero"></param>
        /// <returns></returns>
        public int AgregarBitacora()
        {
            int registrosafectados = 0;
            Conexion.Conexion objDatos = new Conexion.Conexion();
            string consulta = string.Format(" exec AgregarBitacora {0},'{1}',{2}", CodBitacora, Evento, IDCajero);            
            if (objDatos.AbrirConexion())
            {
               registrosafectados = objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();
            }
            objDatos = null;
            GC.Collect();
            return registrosafectados;
        }

        public int CodBitaco()
        {
            int num = 0;
            string consulta = "select COUNT(*) as Código from Bitacora";
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

        #region Desctruc

        ~Bitacora()
        {
            this.CodBitacora = 0;
            this.Evento = null;
            this.IDCajero = 0;

        }

        #endregion Desctruc
    }
}
