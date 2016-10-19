using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BusinessEntities.Restaurante;
using DataAccessLayer.baseDatos;
using DataAccessLayer.Restaurante;

namespace DataAccessLayer.Restaurante
{
    class rolDAL
    {
        conexion conexion = new conexion();
        public List<rol> seleccionarCatProducto()
        {
            List<rol> listaRol = new List<rol>();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectRol";
            rol _roll = new rol();
            _roll.Roluser = "Seleccione";

            listaRol.Add(_roll);

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    rol _rol = new rol();
                    _rol.Id = int.Parse(lector[0].ToString());
                    _rol.Roluser = lector[1].ToString();
                    listaRol.Add(_rol);
                }
            }
            catch (Exception ex)
            {
                string m = ex.Message;
                Comando.Dispose();
            }

            finally
            {
                conexion.closeDataBase();
            }

            return listaRol;
        }
    }
}
    
