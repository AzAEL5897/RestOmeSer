using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer.baseDatos;
using BusinessEntities.Restaurante;


namespace DataAccessLayer.Restaurante
{
    class ingredienteDAL
    {
        conexion conexion = new conexion();
        public DataSet SelectAllIngredientes()
        {
            DataSet productDataSet = new DataSet();




            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();



            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectAllIngrediente";

            try
            {

                SqlDataAdapter myAdapter = new SqlDataAdapter(Comando);
                productDataSet = new DataSet();
                myAdapter.Fill(productDataSet);

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

            return productDataSet;
        }




        public Boolean altaIngrediente(ingrediente _ingrediente)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_insertarIngrediente", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", _ingrediente.Ingrediente);
            comando.Parameters.AddWithValue("@stock", _ingrediente.Stock);

            try
            {
                insertar = comando.ExecuteNonQuery();
                if (insertar < 0)
                {
                    respuesta = true;
                }
                conexion.closeDataBase();
            }
            catch (Exception)
            {
                conexion.closeDataBase();
                throw;

            }

            return respuesta;



        }



        public Boolean eliminarIngrediente(ingrediente _ingrediente)
        {

            int elininar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_elininarIngrediente", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", _ingrediente.Ingrediente);


            try
            {
                elininar = comando.ExecuteNonQuery();
                if (elininar < 0)
                {
                    respuesta = true;
                }
                conexion.closeDataBase();
            }
            catch (Exception)
            {
                conexion.closeDataBase();
                throw;

            }

            return respuesta;



        }




        public DataSet SelectIngredintesDeProducto(ingrediente _ingrediente)
        {
            DataSet productDataSet = new DataSet();




            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();



            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_DetalleIngredienteProducto";
            Comando.Parameters.AddWithValue("@idProducto", _ingrediente.Id);
            try
            {

                SqlDataAdapter myAdapter = new SqlDataAdapter(Comando);
                productDataSet = new DataSet();
                myAdapter.Fill(productDataSet);

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

            return productDataSet;
        }




    }
}

    