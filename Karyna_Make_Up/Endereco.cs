using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karyna_Make_Up
{
    class Endereco
    {
        string rua;
        string num;
        string comp;
        string bairro;
        string cidade;
        string uf;
        string endereco2;
        string endereco3;

        public void setEndereco(string[] endereco)
        {
            this.rua = endereco[0].Trim();
            this.num = endereco[1].Trim();
            this.endereco2 = endereco[2];
        }

        public void setRua(string rua)
        {
            this.rua = rua;
        }

        public string getRua()
        {
            return this.rua;
        }

        public void setNum(string num)
        {
            this.num = num;
        }

        public string getNum()
        {
            return this.num;
        }

        public string getEndereco2()
        {
            return this.endereco2;
        }

        public void setEndereco2(string[] endereco2)
        {
            this.comp = endereco2[0].Trim();
            this.bairro = endereco2[1].Trim();
            this.endereco3 = endereco2[2];
        }

        public void setComp(string comp)
        {
            this.comp = comp;
        }

        public string getComp()
        {
            return this.comp;
        }

        
        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string getBairro()
        {
            return this.bairro;
        }

        public string getEndereco3()
        {
            return this.endereco3;
        }

        public void setEndereco3(string[] endereco3)
        {
            this.cidade = endereco3[0].Trim();
            this.uf = endereco3[1].Trim();
        }


        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string getCidade()
        {
            return this.cidade;
        }

        public void setUF(string uf)
        {
            this.uf = uf;
        }

        public string getUF()
        {
            return this.uf;
        }
        //s
    }
}
