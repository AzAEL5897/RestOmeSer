using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BusinessEntities.Restaurante;
using DataAccessLayer.Restaurante;
using DataAccessLayer.baseDatos;

namespace DataAccessLayer.Restaurante
{
    class reservaMesaDAL
    {
        conexion conexion = new conexion();
        public Boolean altaOrden(int monto)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_Orden", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@MontoTotal", monto);

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



        public Boolean altaDetelleOrden(string nombreProducto)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_OrdenProductos", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreProducto", nombreProducto);





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



        public Boolean altaOrdenTipoMesaLocal(mesa _mesa, clienteFrecuente _cliente, usuario _Personal)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_OrdenMesaLocal", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idMesa ", _mesa.Id);
            comando.Parameters.AddWithValue("@idcliente ", _cliente.Id);
            comando.Parameters.AddWithValue("@idPersonal ", _Personal.Id);

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



        public Boolean altaOrdenParaLlevar(string observacion, clienteFrecuente _cliente, usuario _Personal)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_OrdenLLevar", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idcliente ", _cliente.Id);
            comando.Parameters.AddWithValue("@observacion", observacion);
            comando.Parameters.AddWithValue("@idPersonal ", _Personal.Id);

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




    }
}
    