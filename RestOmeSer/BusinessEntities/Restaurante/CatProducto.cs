using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Restaurante
{
   public  class CatProducto
    {

        private int id;
        private string categoria;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
    }
}
