using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.modelo
{
    class CategoriaProducto
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
