using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using BusinessEntities.Restaurante;
using DataAccessLayer.baseDatos;
using DataAccessLayer.Restaurante;

namespace DataAccessLayer.Restaurante
{
    class mesaDAL
    {
        conexion conexion = new conexion();
        public string[] seleccionarStatusMesa()
        {
            string[] arraymesas = new string[12];

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectMesas";


            mesa _municipio = new mesa();


            try
            {
                int i = 0;
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {

                    mesa _municipi = new mesa();

                    arraymesas[i] = lector[2].ToString();

                    i++;

                }

                arraymesas[i + 1] = "fin";
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

            return arraymesas;
        }


        public List<mesa> seleccionarMesasDispobles()
        {
            List<mesa> listMesasDisponibles = new List<mesa>();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectMesasLibres";
            mesa _mesaa = new mesa();
            // _mesaa.NumeroMesa = "Mesas Disponibles";

            // listMesasDisponibles.Add(_mesaa);

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    mesa _mesa = new mesa();
                    _mesa.Id = int.Parse(lector[0].ToString());
                    _mesa.NumeroMesa = int.Parse(lector[1].ToString());
                    listMesasDisponibles.Add(_mesa);
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

            return listMesasDisponibles;
        }





        public List<mesa> seleccionarMesasOcupadas()
        {
            List<mesa> listMesasDisponibles = new List<mesa>();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectMesasOcupadas";
            mesa _mesaa = new mesa();
            // _mesaa.NumeroMesa = "Mesas Disponibles";

            // listMesasDisponibles.Add(_mesaa);

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    mesa _mesa = new mesa();
                    _mesa.Id = int.Parse(lector[0].ToString());
                    _mesa.NumeroMesa = int.Parse(lector[1].ToString());
                    listMesasDisponibles.Add(_mesa);
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

            return listMesasDisponibles;
        }


        public Boolean ReservarMesa(mesa _mesa, string fecha, clienteFrecuente _clieF)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_reservar", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idMesa", _mesa.Id);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@NombreCliente", _clieF.Nombe);


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



        public Boolean liberarMesa(mesa _mesa)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_liberarMesa", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idMesa", _mesa.Id);



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

    