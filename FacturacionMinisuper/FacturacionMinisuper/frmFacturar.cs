using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionMinisuper
{
    public partial class frmFacturar : Form
    {
        public Logica.Cajero myCajero { get; set; }
        public Logica.Producto myProducto { get; set; }
        public DataTable CarroCompras { get; set; }
        public double MontoTotal { get; set; }
        public frmFacturar()
        {
            InitializeComponent();
        }

        private void frmFacturar_Load(object sender, EventArgs e)
        {
            lblCajero.Text = myCajero.NombreAcceso;
            CarroCompras = new DataTable("CarroCompras");
            DataColumn colCodProducto = new DataColumn("Codigo", typeof(int));
            colCodProducto.Caption = "Código";
            DataColumn colNombre = new DataColumn("Nombre", typeof(string));
            colNombre.Caption = "Nombre";
            DataColumn colPrecio = new DataColumn("Precio", typeof(int));
            DataColumn colCantidad = new DataColumn("Cantidad", typeof(int));
            DataColumn colSubTotal = new DataColumn("SubTotal", typeof(int));
            CarroCompras.Columns.Add(colCodProducto);
            CarroCompras.Columns.Add(colNombre);
            CarroCompras.Columns.Add(colPrecio);
            CarroCompras.Columns.Add(colCantidad);
            CarroCompras.Columns.Add(colSubTotal);
        }

        //private void txtCajero_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //     if (e.KeyChar == (Char)Keys.Enter)
        //    {
        //        Logica.Gestor objGestor = new Logica.Gestor();
        //        Logica.Cajero objCajero = null;
        //        objCajero = objGestor.ConsultarCajero(Convert.ToInt32(txtCajero.Text));
        //        if (objCajero != null)
        //        {
        //            lblDatos.Text = objCajero.IDCajero+ " " + objCajero.Nombre + " " + objCajero.Apellido;
        //            lblCajero.Text= objCajero.IDCajero.ToString();
        //        }
        //        objGestor = null;
        //        txtCajero.Clear();
        //        e.Handled = true;
        //    }
        //}

         private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtCodProducto.Text))
                {
                    Logica.Gestor objGestor = new Logica.Gestor();
                    gvProductos.DataSource = objGestor.ConsultaMasivaProducto();
                    objGestor = null;
                }
                else
                {
                    Logica.Gestor objGestor = new Logica.Gestor();
                    Logica.Producto objProducto = objGestor.ConsultarProducto(Convert.ToInt32(txtCodProducto.Text));
                    if (objProducto != null)
                    {
                        SolicitarCantidad(objProducto);
                    }
                    else
                    {
                        MessageBox.Show("El código escaneado: "
                            + txtCodProducto.Text + " no existe");
                    }
                    txtCodProducto.Text = string.Empty;
                }
            }
        }

         private void CargarGrid()
         {
             Logica.Gestor objGestor = new Logica.Gestor();
             gvProductos.DataSource = objGestor.ConsultaMasivaProducto();
             objGestor = null;
             GC.Collect();
         }

         private void SolicitarCantidad(Logica.Producto objProducto)
         {
             Productos.frmProductoCantidad Cantidad = new Productos.frmProductoCantidad();
             Cantidad.Producto = objProducto;
             Cantidad.ShowDialog();
             if (Cantidad.DialogResult == System.Windows.Forms.DialogResult.OK)
             {
                 DataRow nuevo = CarroCompras.NewRow();
                 nuevo["Codigo"] = Cantidad.Producto.CodProducto;
                 nuevo["Nombre"] = Cantidad.Producto.Nombre;
                 nuevo["Precio"] = Cantidad.Producto.Precio;
                 nuevo["Cantidad"] = Cantidad.Producto.Cantidad;
                 nuevo["SubTotal"] = Cantidad.Producto.SubTotal;
                 MontoTotal = MontoTotal + Cantidad.Producto.SubTotal;
                 lblMonto.Text = MontoTotal.ToString();
                 CarroCompras.Rows.Add(nuevo);
                 this.gvFacturar.DataSource = CarroCompras;
             }
         }

         private void gvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             if (gvProductos.CurrentRow != null)
             {
                 Logica.Producto objProducto = null;
                 Logica.Gestor objGestor = new Logica.Gestor();
                 gvProductos.DataSource = objGestor.ConsultaMasivaProducto();
                 objGestor = null;
                 DataGridViewRow actual = this.gvProductos.CurrentRow;
                 int codpro = Convert.ToInt32(actual.Cells[0].Value.ToString());
                 string nomb = actual.Cells[1].Value.ToString();
                 double preci = Convert.ToDouble(actual.Cells[2].Value);
                 int cantidad = Convert.ToInt32(actual.Cells[3].Value.ToString());

                 objProducto = new Logica.Producto(codpro, nomb, preci, cantidad);
                 SolicitarCantidad(objProducto);
             }
         }

         private void pbFacturar_Click(object sender, EventArgs e)
         {
             if (CarroCompras.Rows.Count > 0)
             {
                 Logica.Factura objFactura = new Logica.Factura();
                 objFactura.Total = Convert.ToInt32(lblMonto.Text);
                 objFactura.Fecha = DateTime.Now;
                 objFactura.myCajero = myCajero;
                 List<Logica.DetalleFactura> listaLineas = new List<Logica.DetalleFactura>();
                 foreach (DataRow linea in CarroCompras.Rows)
                 {
                     int idP = Convert.ToInt32(linea[0].ToString());
                     Logica.Producto p = new Producto(idP);
                     string des = linea[1].ToString();
                     int precio = Convert.ToInt32(linea[2]);
                     int cant = Convert.ToInt32(linea[3]);
                     int subTotal = Convert.ToInt32(linea[4]);
                     Logica.DetalleFactura objDetalle = new Logica.DetalleFactura();
                     objDetalle.Cantidad = cant;
                     objDetalle.Precio = precio;
                     objDetalle.SubTotal = subTotal;
                     objDetalle.myProducto = p;
                     listaLineas.Add(objDetalle);
                 }
                 objFactura.Detalle = listaLineas;
                 Logica.Gestor objGestor = new Logica.Gestor();
                 ResultadoFacturacion respuesta = objGestor.Facturar(objFactura);
                 objGestor.GenerarBitacora(0, "El cajero "+myCajero.NombreAcceso+" ha generado una nueva factura con un monto de: "+objFactura.Total+" a las: "+DateTime.Today.TimeOfDay, myCajero.IDCajero);
                 objGestor = null;
                 if (respuesta.CodigoError != 0)
                 {
                     MessageBox.Show(respuesta.MensajeError);
                 }
                 else
                 {
                     ReporteFactura objReporte = new ReporteFactura();
                     objReporte.CodFactura = respuesta.idFactura;
                     objReporte.ShowDialog();
                 }
                 MontoTotal = 0;
                 lblMonto.Text = string.Empty;
                 CarroCompras.Rows.Clear();
                 gvFacturar.DataSource = null;
             }
             else
             {
                 MessageBox.Show("Debe comprar al menos un producto para facturar");
             }
         }

         private void pbrefresh_Click(object sender, EventArgs e)
         {
             CargarGrid();
         }
               
    }
}
