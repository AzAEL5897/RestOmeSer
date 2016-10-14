using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaRestaurante.modelo;
using SistemaRestaurante.BaseDatos;

namespace SistemaRestaurante.modelo
{
    class ControlMesa
    {
        conexion conexion = new conexion();
        public string[] seleccionarStatusMesa()
        {
            string[] arraymesas = new string[28];
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "sp_selectMesas";


            Mesa Municipio = new Mesa();
            try
            {
                int i = 0;
                IDataReader lector = Comando.ExecuteReader();
                while(lector.Read())
                {
                    Mesa Muni = new Mesa();
                    arraymesas[i] = lector[2].ToString();

                    i++;

                }
                arraymesas[i + 1] = "fin";

            }
            catch ( Exception ex)
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

        public List<Mesa> seleccionarMesasDisponibles()
        {
            List<Mesa> listMesasDisponibles = new List<Mesa>();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;
            Comando.CommandText = "sp_selectMesasLibres";
            Mesa _Mesaa = new Mesa();

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    Mesa _Mesa = new Mesa();
                    _Mesa.Id = int.Parse(lector[0].ToString());
                    _Mesa.NumeroMesa = int.Parse(lector[1].ToString());
                    listMesasDisponibles.Add(_Mesa);
                }
            }
            catch ( Exception ex)
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
        public List<Mesa> seleccionarMesasOcupadas()

        {
            List<Mesa> listMesasDsiponibles = new List<Mesa>();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();
            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectMesasOcupadas";
            Mesa _Mesaa = new Mesa();

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while(lector.Read())
                {
                    Mesa _Mesa = new Mesa();
                    _Mesa.Id = int.Parse(lector[1].ToString());
                    listMesasDsiponibles.Add(_Mesa);
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
            return listMesasDsiponibles;
        }

        public Boolean ReservarMesa(Mesa _mesa, string fecha, ClienteFrecuente _clieF)
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



        public Boolean liberarMesa(Mesa _mesa)
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
