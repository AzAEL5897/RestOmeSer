using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessEntities.Restaurante;
using DataAccessLayer.Restaurante;
using DataAccessLayer.baseDatos;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DataAccessLayer.Restaurante
{
    class clienteFrecuenteDAL
    {
        conexion conexion = new conexion();
        public Boolean altaClienteFrecuente(clienteFrecuente _clientFrecu)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_altaClienteFrecuente", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", _clientFrecu.Nombe);
            comando.Parameters.AddWithValue("@apellido", _clientFrecu.Apellido);
            comando.Parameters.AddWithValue("@telefono", _clientFrecu.Telefono);
            comando.Parameters.AddWithValue("@email", _clientFrecu.Email);
            comando.Parameters.AddWithValue("@idCatCliente", _clientFrecu.IdtCliente);

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


        public Boolean eliminarClienteFre(clienteFrecuente _cF)
        {

            int elininar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_eliminarCliente", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombrecliente", _cF.Nombe);


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



        public AutoCompleteStringCollection autocompleteCliente()
        {


            {

                SqlCommand cmd = new SqlCommand("SELECT Nombre FROM clienteFrecuente where status=1", conexion.openDataBase());

                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                    Console.WriteLine(reader.GetString(0));
                }
                //  txt1.AutoCompleteCustomSource = MyCollection;
                conexion.closeDataBase();
                return MyCollection;
            }
        }



        public List<clienteFrecuente> seleccionarCliente()
        {
            List<clienteFrecuente> listClienteFrecente = new List<clienteFrecuente>();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectCliente";
            clienteFrecuente _clifcnt = new clienteFrecuente();
            _clifcnt.Nombe = "Cliente";

            listClienteFrecente.Add(_clifcnt);

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    clienteFrecuente _clienteFr = new clienteFrecuente();
                    _clienteFr.Id = int.Parse(lector[0].ToString());
                    _clienteFr.Nombe = lector[1].ToString();
                    listClienteFrecente.Add(_clienteFr);
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

            return listClienteFrecente;
        }


    }
}

    