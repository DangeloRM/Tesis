using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class Gestor : Logica.IGestor
    {

        #region Cajero

        Cajero objCajero = null;
        public int ActualizarCajero(int pId, string pAcceso, string pPass, string pNombre, string pApellido, string pTelefono, bool pEstado, int pIdAcceso)
        {
            objCajero = new Cajero(pId, pAcceso,pPass,pNombre,pApellido, pTelefono, pEstado, pIdAcceso);
            return objCajero.ActualizarCajero();
        }

        public int AgregarCajero(int pId, string pAcceso, string pPass, string pNombre, string pApellido, string pTelefono, bool pEstado, int pIdAcceso)
        {
            objCajero = new Cajero(pId, pAcceso, pPass, pNombre, pApellido, pTelefono, pEstado, pIdAcceso);
            return objCajero.AgregarCajero();
        }

        public Cajero ConsultarCajero(int idcajero)
        {
            objCajero = new Cajero();
            return objCajero.ConsultarCajero(idcajero);
        }

       public Cajero IniciaSession(string pCajero)
        {
            objCajero = new Cajero();
            return objCajero.InicioSesion(pCajero);
        }
        public DataTable ConsultaMasivaCajero()
        {
            objCajero = new Cajero();
            return objCajero.ConsultaMasivaCajero();
        }

        #endregion Cajero

        #region Distrib

         Distribuidor objDistrib = null;
        public int ActualizarDistribuidor(string nombre, string estado, string telefono, int coddistribuidor)
        {
            objDistrib = new Distribuidor(coddistribuidor,nombre,estado,telefono);
            return objDistrib.ActualizarDistribuidor();
        }

          public int AgregarDistribuidor(int coddistribuidor,string nombre, string estado, string telefono)
        {
            objDistrib = new Distribuidor(coddistribuidor,nombre,estado,telefono);
            return objDistrib.AgregarDistribuidor();
        }

        public Distribuidor ConsultarDistribuidor(int coddistribuidor)
        {
            objDistrib = new Distribuidor();
            return objDistrib.ConsultarDistribuidor(coddistribuidor);
        }

        public Distribuidor ConsultarDistribuidorNombre(string nombre)
        {
            objDistrib = new Distribuidor();
            return objDistrib.ConsultarDistribuidorNomb(nombre);
        }
        public DataTable ConsultaMasivaDistribuidores()
        {
            objDistrib = new Distribuidor();
            return objDistrib.ConsultaMasivaDistribuidores();
        }

        public DataTable ConsultaMasivaDistribuidoresInactivos()
        {
            objDistrib = new Distribuidor();
            return objDistrib.ConsultaMasivaDistribuidoresInactivos();
        }
        #endregion Distrib

        #region MovInventario

        MovInventario objMovInventario = null;
        public int AgregarMovInventario(int codinventario, DateTime fecharealizacion)
        {
            
                objMovInventario = new MovInventario(codinventario, fecharealizacion, codinventario);
                return objMovInventario.AgregarMovInventario();
           
        }
        public int ActualizarMovInventario(DateTime fecharealizacion, int codinventario)
        {
                objMovInventario = new MovInventario(codinventario, fecharealizacion, codinventario);
                return objMovInventario.ActualizarMovInventario();
 
        }

        public DataTable ConsultaMasivaMovInventario()
        {
            objMovInventario = new MovInventario();
            return objMovInventario.ConsultaMasivaMovInventarios();
        }

        public MovInventario ConsultarMovInventario(int codinventario)
        {
            objMovInventario = new MovInventario();
            return objMovInventario.ConsultarMovInventario(codinventario);
        }

        #endregion MovInventario

        #region Producto

        Producto objProducto = null;
        public int AgregarProducto(int codproducto, string nombre, double precio, int coddistribuidor)
        {
            objDistrib = new Distribuidor();
            if (objDistrib.ConsultarDistribuidor(coddistribuidor) != null)
            {
                coddistribuidor = objDistrib.CodDistribuidor;
            }

                 objProducto = new Producto(codproducto, nombre, precio, coddistribuidor);
                 if (objProducto.ConsultarProducto(codproducto) ==null)
                 {
                     return objProducto.AgregarProducto();
                 }
            else
            {
                return 0;
            }
        }
        public int ActualizarProducto(string nombre, double precio, int cantidad, int coddistribuidor, int codproducto)
        {
            objDistrib = new Distribuidor();
            if (objDistrib.ConsultarDistribuidor(coddistribuidor) != null)
            {
                coddistribuidor = objDistrib.CodDistribuidor;
            }

            objProducto = new Producto(codproducto, nombre,precio, cantidad, coddistribuidor);
            if (objProducto.ConsultarProducto(codproducto) != null)
            {
                return objProducto.ActualizarProducto();
            }
            else
            {
                return 0;
            }
        }

         public DataTable ConsultaMasivaProducto()
        {
            objProducto = new Producto();
            return objProducto.ConsultaMasivaProductos();
        }

         public Producto ConsultarProducto(int codproducto)
        {
            objProducto = new Producto();
            return objProducto.ConsultarProducto(codproducto);
        }

        #endregion Producto

         public ResultadoFacturacion Facturar(Factura pFactura)
         {
             ProcesoFacturacion objFacturacion = new ProcesoFacturacion();
             return objFacturacion.Facturar(pFactura);
         }

         Bitacora myBit = null;
         public int GenerarBitacora(int pId, string pAccion, int IdCajero)
         {
             myBit = new Bitacora(pId, pAccion, IdCajero);
             return myBit.AgregarBitacora();
         }

    }
}
