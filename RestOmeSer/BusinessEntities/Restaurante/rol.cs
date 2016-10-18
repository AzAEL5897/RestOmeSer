using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Restaurante
{
  public class rol
    {
        private int id;
        private string roluser;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Roluser
        {
            get { return roluser; }
            set { roluser = value; }
        }
    }
}
