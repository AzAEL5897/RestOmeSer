using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.modelo
{
    class ReservarMesa
    {
        private int id;
        private int idMesa;
        private int idCliente;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdMesa
        {
            get { return idMesa; }
            set { idMesa = value; }
        }
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
    }
}
