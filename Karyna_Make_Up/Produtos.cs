using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karyna_Make_Up
{
    class Produtos
    {

        private int idProduto;
        private string produto;
        private int qtde;


        public void setIdProduto(int idProduto)
        {
            this.idProduto = idProduto;
        }

        public int getIdProduto()
        {
            return this.idProduto;
        }

        public void setProduto(string produto)
        {
            this.produto = produto;
        }

        public string getProduto()
        {
            return this.produto;
        }

        public void setQtde(int qtde)
        {
            this.qtde = qtde;
        }

        public int getQtde()
        {
            return this.qtde;
        }
    }
}
