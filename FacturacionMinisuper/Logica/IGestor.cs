using System;
namespace Logica
{
    interface IGestor
    {
        int ActualizarCajero(string nombre, string apellido, string telefono, string contrasena, string estado, int idcajero);
        int ActualizarDistribuidor(string nombre, string estado, string telefono, int coddistribuidor);
        int ActualizarMovInventario(DateTime fecharealizacion, int codinventario);
        int ActualizarProducto(string nombre, double precio, int cantidad, int coddistribuidor, int codproducto);
        int ActualizarUsuario(string nombreusuario, string password, int idtipousuario);
        int AgregarBitacora(int codbitacora, string evento, int idcajero);
        int AgregarCajero(int idcajero, string nombre, string apellido, string telefono, string contrasena, string estado);
        int AgregarDistribuidor(int coddistribuidor, string nombre, string estado, string telefono);
        int AgregarMovInventario(int codinventario, DateTime fecharealizacion);
        int AgregarProducto(int codproducto, string nombre, double precio, int coddistribuidor);
        System.Data.DataTable ConsultaMasivaBitacora();
        System.Data.DataTable ConsultaMasivaCajero();
        System.Data.DataTable ConsultaMasivaDistribuidores();
        System.Data.DataTable ConsultaMasivaDistribuidoresInactivos();
        System.Data.DataTable ConsultaMasivaMovInventario();
        System.Data.DataTable ConsultaMasivaProducto();
        Bitacora ConsultarBitacora(int codbitacora);
        Cajero ConsultarCajero(int idcajero);
        Cajero ConsultarCajeroBita(int idcajero);
        Distribuidor ConsultarDistribuidor(int coddistribuidor);
        Distribuidor ConsultarDistribuidorNombre(string nombre);
        MovInventario ConsultarMovInventario(int codinventario);
        Producto ConsultarProducto(int codproducto);
        Usuario ConsultarUsuario(string password);
    }
}
