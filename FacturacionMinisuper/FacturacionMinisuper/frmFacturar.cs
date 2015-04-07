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
            lblCajero.Text = myCajero.Nombre +" "+ myCajero.Apellido;
            CarroCompras = new DataTable("CarroCompras");
            DataColumn colCodProducto = new DataColumn("Codigo", typeof(string));
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
        //    if (e.KeyChar == (Char)Keys.Enter)
        //    {
        //        Logica.Gestor objGestor = new Logica.Gestor();
        //        Logica.Cajero objCajero = null;
        //        objCajero = objGestor.ConsultarCajero(Convert.ToInt32(txtCajero.Text));
        //        if (objCajero != null)
        //        {
        //            lblDatos.Text = objCajero.IDCajero + " " + objCajero.Nombre + " " + objCajero.Apellido;
        //            lblCajero.Text = objCajero.IDCajero.ToString();
        //        }
        //        objGestor = null;
        //        txtCajero.Clear();
        //        e.Handled = true;
        //    }
        //}

         private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTextBox.SoloNumeros(e);
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
                    Logica.Producto objProducto = objGestor.ConsultarProducto(txtCodProducto.Text);
                    if (objProducto != null)
                    {
                        SolicitarCantidad(objProducto);
                    }
                    else
                    {
                        MessageBox.Show("El código escaneado: "
                            + txtCodProducto.Text + " no existe","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                 string codpro = actual.Cells[0].Value.ToString();
                 string nomb = actual.Cells[1].Value.ToString();
                 double preci = Convert.ToDouble(actual.Cells[2].Value);
                 int cantidad = Convert.ToInt32(actual.Cells[3].Value.ToString());

                 objProducto = new Logica.Producto(codpro, nomb, preci, cantidad);
                 SolicitarCantidad(objProducto);
                 }
         }

         private void pbFacturar_Click(object sender, EventArgs e)
         {
                 /*
                  * Primero verificamos si nuestro grid de productos contiene datos para 
                  * poder realizar la facturación correspondiente.
                  */
                 if (CarroCompras.Rows.Count > 0)
                 {
                     /*En el caso que si contenga productos válidos
                      *procedemos con el proceso de facturación.
                      */
                     Logica.Factura objFactura = new Logica.Factura();//Creamos nuestro objeto factura
                     objFactura.Total = Convert.ToInt32(lblMonto.Text);//Obtenemos el total del label encargado
                     objFactura.Fecha = DateTime.Now;//Obtenemos la fecha de hoy
                     objFactura.myCajero = myCajero;//Asignamos el cajero actual al que llevará la factura
                     /*
                      * Creamos nuestra lista de lineas de la factura o detalles para poder procesarlos
                      * uno por uno y asignarlos al proceso de facturación.
                      */
                     List<Logica.DetalleFactura> listaLineas = new List<Logica.DetalleFactura>();
                     //Trabajamos en nuestra lista asignandole los valores de nuestro grid de productos a facturar.
                     //Estos productos los obtenemos del grid CarroCompras de sus objetos datarow.
                     foreach (DataRow linea in CarroCompras.Rows)
                     {
                         //Extraemos los datos correspondientes
                         string idP = linea[0].ToString();
                         Logica.Producto p = new Producto(idP.ToString());
                         string des = linea[1].ToString();
                         int precio = Convert.ToInt32(linea[2]);
                         int cant = Convert.ToInt32(linea[3]);
                         int subTotal = Convert.ToInt32(linea[4]);
                         /*
                          * Creamos nuestro objeto detalle y le asignamos los valores procesados
                          * anteriormente provenientes de nuestro grid CarroCompras.
                          */
                         Logica.DetalleFactura objDetalle = new Logica.DetalleFactura();
                         objDetalle.Cantidad = cant;
                         objDetalle.Precio = precio;
                         objDetalle.SubTotal = subTotal;
                         objDetalle.myProducto = p;
                         /*
                          * Agregamos nuestros detalles a nuestra lista previamente creada listaLineas
                          */
                         listaLineas.Add(objDetalle);
                     }
                     if (MessageBox.Show("Deseas realizar esta venta?", "Venta Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                     //Asignamos nuestra lista de detalles al objeto factura.
                     objFactura.Detalle = listaLineas;
                     //Llamamos al gestor para poder usar nuestra clase de procesos Resultado Facturacion
                     Logica.Gestor objGestor = new Logica.Gestor();
                     //Obtenemos los datos de respuesta de nuestra clase resultad facturacion, esta nos 
                     //indicará si todo salió correctamente.
                     ResultadoFacturacion respuesta = objGestor.Facturar(objFactura);
                     //Porcedemos a crear la bitácora respectiva para llevar un registro cerrado de las
                     //actividades.
                     objGestor.GenerarBitacora(0, "El cajero " + myCajero.Nombre +" "+ myCajero.Apellido + " ha generado una nueva factura por un monto de: " + objFactura.Total , myCajero.IDCajero);
                     objGestor = null;
                     //Validamos nuestra respuesta si nuestra respuesta es 1 significa que todo salio bien
                     if (respuesta.CodigoError != 0)
                     {
                         MessageBox.Show(respuesta.MensajeError);
                     }
                     else
                     {
                         //Procedemos a mostrar el reporte
                         ReporteFactura objReporte = new ReporteFactura();
                         objReporte.CodFactura = respuesta.idFactura;//Le enviamos el codigo de la factura para poder obtener el reporte
                         objReporte.ShowDialog();
                         CargarGrid();
                     }
            }
                     //Liberamos nuestros controles
                     MontoTotal = 0;
                     lblMonto.Text = string.Empty;
                     CarroCompras.Rows.Clear();
                     gvFacturar.DataSource = null;
                 }
                 else
                 {
                     MessageBox.Show("Debe comprar al menos un producto para facturar","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                 }
                 gvFacturar.DataSource = null;
         }

         private void txtCodProducto_TextChanged(object sender, EventArgs e)
         {

         }
               
    }
}
