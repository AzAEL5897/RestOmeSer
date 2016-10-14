using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.modelo
{
    class CatCliente
    {
        private int id;
        private string catUser;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string CatUser
        {
            get { return catUser; }
            set { catUser = value; }
        }
    }
}
