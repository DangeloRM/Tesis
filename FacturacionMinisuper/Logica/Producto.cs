using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Producto
    {
        #region Prop

        public int CodProducto { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public int CodDistribuidor { get; set; }

        

        #endregion Prop

        #region Construc

        public Producto()
        {

        }
        public Producto(int codproducto)
        {
            this.CodProducto = codproducto;
        }

        public Producto(int codproducto, string nombre, string estado, double precio,int cantidad, int coddistribuidor)
        {
            this.CodProducto = codproducto;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.CodDistribuidor = coddistribuidor;

            
        }

        public Producto(int codproducto, string nombre, double precio, int cantidad, int coddistribuidor)
        {
            this.CodProducto = codproducto;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.CodDistribuidor = coddistribuidor;

        }

        public Producto(int codproducto, string nombre, double precio, int coddistribuidor)
        {
            this.CodProducto = codproducto;
            this.Nombre = nombre;
            this.Precio = precio;
            this.CodDistribuidor = coddistribuidor;

        }

        #endregion Construc

        #region Operaciones Select
        /// <summary>
        /// Consultar Producto
        /// </summary>
        /// <param name="codproducto"></param>
        /// <returns></returns>
        public Producto ConsultarProducto(int codproducto)
        {
            Producto objProducto = null;
            string consulta = string.Format("exec SP_ConsultaProducto {0},1", codproducto);

            Conexion.Conexion objDatos = new Conexion.Conexion();

            try
            {
                if (objDatos.AbrirConexion())
                {
                    DataTable dtResultado = objDatos.HacerSelect(consulta);

                    if (dtResultado != null && dtResultado.Rows.Count > 0)
                    {
                        int codprod = Convert.ToInt32(dtResultado.Rows[0][0].ToString());
                        string nombr= dtResultado.Rows[0][1].ToString();
                        double preci = Convert.ToDouble(dtResultado.Rows[0][2].ToString());
                        int canti = Convert.ToInt32(dtResultado.Rows[0][3].ToString());
                        int coddistri = Convert.ToInt32(dtResultado.Rows[0][4].ToString());

                        objProducto = new Producto(codprod, nombr, preci, canti, coddistri);
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
            return objProducto;
        }


        /// <summary>
        /// ConsultaMasivaProductos
        /// </summary>
        /// <returns></returns>
        public DataTable ConsultaMasivaProductos()
        {
            DataTable dtProducto = new DataTable();
            string consulta = string.Format("exec SP_ConsultaProducto 0, 0");
            Conexion.Conexion objDatos = new Conexion.Conexion();

            try
            {
                if (objDatos.AbrirConexion())
                {
                    dtProducto = objDatos.HacerSelect(consulta);
                    objDatos.CerrarConexion();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("HUBO UN ERROR", ex); 
            }
            objDatos = null;
            GC.Collect();
            return dtProducto;
        }
        

        #endregion Operaciones Select

        #region Operaciones Hit

        /// <summary>
        /// ActualizarProducto
        /// </summary>
        /// <param name="codproducto"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="estado"></param>
        /// <param name="precio"></param>
        /// <param name="coddistribuidor"></param>
        /// <returns></returns>
        public int ActualizarProducto()
        {
            int registrosafectados = 0;

            string consulta = string.Format("exec SP_Producto {0}, {1},{2},'{3}',{4} , 2", CodProducto, CodDistribuidor, Precio, Nombre, Cantidad);

            Conexion.Conexion objDatos = new Conexion.Conexion();
            if (objDatos.AbrirConexion())
            {
                registrosafectados = objDatos.OperacionesHit(consulta);
                objDatos.CerrarConexion();
            }
            objDatos = null;
            GC.Collect();
            return registrosafectados;
        }


        /// <summary>
        ///Agregar Producto 
        /// </summary>
        /// <param name="codproducto"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="estado"></param>
        /// <param name="precio"></param>
        /// <param name="coddistribuidor"></param>
        /// <returns></returns>
        public int AgregarProducto()
        {
            int registrosafectados = 0;
            Conexion.Conexion objDatos = new Conexion.Conexion();

            string consulta = string.Format("exec SP_Producto {0}, {1},{2},'{3}', 1, 1", CodProducto, CodDistribuidor, Precio, Nombre );
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

        #region Destructor

        ~Producto()
        {
            this.CodProducto = 0;
            this.Nombre = null;
            this.Precio = 0;
            this.Cantidad = 0;
            this.CodDistribuidor = 0;            
        }

        #endregion Destructor
    }

}
