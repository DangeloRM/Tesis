using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;




namespace Conexion
{
    public class Conexion
    {
        #region Prop

        SqlConnection cnx = null;
        
       #endregion Prop
        
        #region Constr

        public Conexion()
        {
            cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionBD"].ToString());
        }

        #endregion Constr

        #region Funciones

        /// <summary>
        /// Abrir Conexion
        /// </summary>
        /// <returns></returns>
        public bool AbrirConexion()
        {
            bool abrirconexion = true;
            try
            {
                cnx.Open();
            }
            catch (Exception)
            {

                abrirconexion = false;

            }
            return abrirconexion;
        }

        /// <summary>
        /// Cerrar Conexion
        /// </summary>
        /// <returns></returns>
        public bool CerrarConexion() 
        {
            bool cerrarconexion = true;

            try
            {
                cnx.Close();
            }
            catch (Exception)
            {

                cerrarconexion = false;

            }
            return cerrarconexion;
        }

        /// <summary>
        /// HacerSelect
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataTable HacerSelect(string consulta) 
        {
            DataTable dtconsulta = new DataTable();

            SqlCommand comando = new SqlCommand(consulta, cnx);

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dtconsulta);
            return dtconsulta;
        }

        public int OperacionesHit(string consulta)
        {
            int registrosAfectados = 0;
            try
            {
                SqlCommand comando = new SqlCommand(consulta, cnx);
                registrosAfectados = comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            return registrosAfectados;
        }

        public void Respaldo(string consulta)
        {
            try
            {
                SqlCommand comando = new SqlCommand(consulta, cnx);
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion Funciones

        #region Destruc

        ~Conexion()
        {
            this.cnx = null;
        }

        #endregion Destruc
   }
}
