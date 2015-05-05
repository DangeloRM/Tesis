using System;

namespace Logica
{
    internal interface IGestor
    {
        int RealizarRespaldo();

        int ActualizarCajero(int pId, string pAcceso, string pPass, string pNombre, string pApellido, string pTelefono, bool pEstado, int pIdAcceso);

        int ActualizarDistribuidor(string nombre, string estado, string telefono, int coddistribuidor);

        int ActualizarMovInventario(DateTime fecharealizacion, int codinventario);

        int ActualizarProducto(string nombre, double precio, int cantidad, int coddistribuidor, string codproducto);

        int AgregarCajero(int pId, string pAcceso, string pPass, string pNombre, string pApellido, string pTelefono, bool pEstado, int pIdAcceso);

        int AgregarDistribuidor(int coddistribuidor, string nombre, string estado, string telefono);

        int AgregarMovInventario(int codinventario, DateTime fecharealizacion);

        int AgregarProducto(string codproducto, string nombre, double precio, int coddistribuidor);

        System.Data.DataTable ConsultaMasivaCajero();

        System.Data.DataTable ConsultaMasivaDistribuidores();

        System.Data.DataTable ConsultaMasivaDistribuidoresInactivos();

        System.Data.DataTable ConsultaMasivaMovInventario();

        System.Data.DataTable ConsultaMasivaProducto();

        Cajero ConsultarCajero(int idcajero);

        Distribuidor ConsultarDistribuidor(int coddistribuidor);

        Distribuidor ConsultarDistribuidorNombre(string nombre);

        MovInventario ConsultarMovInventario(int codinventario);

        Producto ConsultarProducto(string codproducto);

        ResultadoFacturacion Facturar(Factura pFactura);

        int GenerarBitacora(int pId, string pAccion, int IdCajero);

        Cajero IniciaSession(string pCajero);
    }
}