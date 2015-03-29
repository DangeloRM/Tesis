using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DetalleFactura
    {
        public int idDetalle { get; set; }
        public int idFactura { get; set; }
        public Producto myProducto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double SubTotal { get; set; }
    }
}
