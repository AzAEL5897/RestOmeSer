using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaRestaurante.BaseDatos
{
    class conexion
    {
        private String cadenaConexionBaseDeDatos;
        public String obtenerCadenaDeConexion()
        {
            cadenaConexionBaseDeDatos = "Data Source =.; Initial Catalog = SistemaRestaurante; Integrated Security = True";
            return cadenaConexionBaseDeDatos;

        }

        private SqlConnection conexionBaseDatos;
        public conexion()
        {
            conexionBaseDatos = new SqlConnection(obtenerCadenaDeConexion());
        }
        public SqlConnection openDataBase()
        {
            conexionBaseDatos.Open();
            if (conexionBaseDatos == null)
            {
                conexionBaseDatos.Close();

            }
            return conexionBaseDatos;
        }

        public void closeDataBase()
        {
            try
            {
                conexionBaseDatos.Close();
            }
            catch (Exception _ex)
            {
                String mnsaje = _ex.Message;
            }
        }
    }
}
