using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer.baseDatos;
using DataAccessLayer.Restaurante;
using BusinessEntities.Restaurante;

namespace DataAccessLayer.Restaurante
{
    class CatClienteDAL
    {
        conexion conexion = new conexion();
        public List<CatCliente> seleccionarCatCliente()
        {
            List<CatCliente> listacatCliente = new List<CatCliente>();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectCatCliente";
            CatCliente _catClient = new CatCliente();
            _catClient.CatUser = "Seleccione";

            listacatCliente.Add(_catClient);

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    CatCliente _catCli = new CatCliente();
                    _catCli.Id = int.Parse(lector[0].ToString());
                    _catCli.CatUser = lector[1].ToString();
                    listacatCliente.Add(_catCli);
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

            return listacatCliente;
        }
    }
}

