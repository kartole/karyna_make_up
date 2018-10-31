using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karyna_Make_Up
{
    class Marcas
    {

        private int idMarca;
        private string marca;
        

        public void setIdMarca(int idMarca)
        {
            this.idMarca = idMarca;
        }

        public int getIdMarca()
        {
            return this.idMarca;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public string getMarca()
        {
            return this.marca;
        }
        
    }
}
