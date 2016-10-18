using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Restaurante
{
   public class direccion
    {
        private int id;
        private string numero;
        private string calle;
        private string colonia;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }
        public string Colonia
        {
            get { return colonia; }
            set { colonia = value; }
        }
    }
}
