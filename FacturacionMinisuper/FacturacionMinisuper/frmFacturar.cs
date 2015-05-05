using Logica;
using System;
using System.Collections.Generic;
using System.Data;
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
            lblCajero.Text = myCajero.Nombre + " " + myCajero.Apellido;
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
                //MontoTotal = MontoTotal + Cantidad.Producto.SubTotal;
                //lblMonto.Text = MontoTotal.ToString();
                CarroCompras.Rows.Add(nuevo);
                this.gvFacturar.DataSource = CarroCompras;
                CargarGrid();
            }
        }

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
                            + txtCodProducto.Text + " no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (CarroCompras.Rows.Count > 0)
            {
                Logica.Factura objFactura = new Logica.Factura();
                objFactura.Total = Convert.ToInt32(MontoTotal);
                objFactura.Fecha = DateTime.Now;
                objFactura.myCajero = myCajero;

                List<Logica.DetalleFactura> listaLineas = new List<Logica.DetalleFactura>();
                foreach (DataRow linea in CarroCompras.Rows)
                {
                    if (linea.RowState != DataRowState.Deleted)
                    {
                        string idP = linea[0].ToString();
                        Logica.Producto p = new Producto(idP.ToString());
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
                }
                if (MessageBox.Show("Deseas realizar esta venta?", "Venta Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objFactura.Detalle = listaLineas;

                    Logica.Gestor objGestor = new Logica.Gestor();

                    ResultadoFacturacion respuesta = objGestor.Facturar(objFactura);

                    objGestor.GenerarBitacora(0, "El cajero " + myCajero.Nombre + " " + myCajero.Apellido + " ha generado una nueva factura por un monto de: " + this.lblMonto.Text, myCajero.IDCajero);
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
                        CargarGrid();
                        gvFacturar.DataSource = null;
                        MontoTotal = 0;
                        lblMonto.Text = string.Empty;
                        CarroCompras.Rows.Clear();
                    }
                }

                //MontoTotal = 0;
                //lblMonto.Text = string.Empty;
                //CarroCompras.Rows.Clear();
                //gvFacturar.DataSource = null;
            }
            else
            {
                MessageBox.Show("Debe comprar al menos un producto para facturar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //gvFacturar.DataSource = null;
        }

        private void txtCodProducto_TextChanged(object sender, EventArgs e)
        {
        }

        private void gvFacturar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvFacturar.CurrentRow != null)
            {
                Logica.Gestor objGestor = new Gestor();

                DataGridViewRow rowActual = gvFacturar.CurrentRow;
                string codProdSelect = rowActual.Cells[0].Value.ToString();
                lblSeleccionado.Text = codProdSelect;
            }
        }

        public void UpdateAmount()
        {
            double Amount = 0;
            foreach (DataRow linea in CarroCompras.Rows)
            {
                try
                {
                    linea.BeginEdit();
                    Amount = Amount + Convert.ToInt32(linea[4]);
                    linea.AcceptChanges();
                }
                catch (Exception)
                {
                    //Por si acaso.
                }
            }
            this.lblMonto.Text = Amount.ToString();
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
        }

        private void gvFacturar_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateAmount();
        }

        private void gvFacturar_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateAmount();
        }

        private void pblimpiar_Click(object sender, EventArgs e)
        {
            MontoTotal = 0;
            lblMonto.Text = string.Empty;
            CarroCompras.Rows.Clear();
            gvFacturar.DataSource = null;
        }
    }
}