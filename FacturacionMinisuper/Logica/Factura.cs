using System;
using System.Collections.Generic;

namespace Logica
{
    public class Factura
    {
        public int IdFactura { get; set; }

        public DateTime Fecha { get; set; }

        public double Total { get; set; }

        public Cajero myCajero { get; set; }

        public List<DetalleFactura> Detalle { get; set; }
    }
}