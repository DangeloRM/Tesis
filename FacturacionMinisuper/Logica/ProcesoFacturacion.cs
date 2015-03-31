using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProcesoFacturacion
    {
        public ResultadoFacturacion Facturar(Factura myFactura)
        {
            ResultadoFacturacion rf = new ResultadoFacturacion();
            string cmd = string.Format("exec SP_Factura '{0}',{1},{2},1", myFactura.Fecha.ToString("yyyy-MM-dd"), myFactura.Total, myFactura.myCajero.IDCajero);
            Conexion.Conexion cnx = new Conexion.Conexion();
            if (cnx.AbrirConexion())
            {
                int add = cnx.OperacionesHit(cmd);
                if (add > 0)
                {
                    string idFactura = "SELECT @@IDENTITY";
                    DataTable dt = cnx.HacerSelect(idFactura);                    
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        int pId = Convert.ToInt32(dt.Rows[0][0]);
                        foreach (DetalleFactura Detalle in myFactura.Detalle)
                        {
                            Producto pr = new Producto();
                            string comm = string.Format("exec SP_Detalle {0},{1},{2},{3},{4};", Detalle.idFactura, Detalle.myProducto.CodProducto, Detalle.Cantidad, Detalle.Precio, Detalle.SubTotal);
                            cnx.OperacionesHit(cmd);
                            pr.ReducirStock(Detalle.myProducto.CodProducto, Detalle.Cantidad);
                        }
                        rf.idFactura = pId;
                        rf.CodigoError = 0;
                        rf.MensajeError = "Factura generada correctamente";
                    }
                    else
                    {
                        rf.CodigoError = 3;
                        rf.MensajeError = "No se pudo obtener el ID de Factura";
                    }
                }
                else
                {
                    rf.CodigoError = 2;
                    rf.MensajeError = "Error al ingresar la factura";
                }
                cnx.CerrarConexion();
            }
            else
            {
                rf.CodigoError = 1;
                rf.MensajeError = "Error de conexion a la base de datos";
            }
            cnx = null;
            return rf;
        }
    }
}
