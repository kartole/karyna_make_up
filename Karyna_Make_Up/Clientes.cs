using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karyna_Make_Up
{
    class Clientes
    {
        private int rowId;
        private string nome;
        private string cpf;
        private string nasc;
        private string sexo;
        private string email;
        private string telefone;

        public void setRowId(int rowId)
        {
            this.rowId = rowId;
        }

        public int getRowId()
        {
            return this.rowId;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCPF()
        {
            return this.cpf;
        }

        public void setNasc(string nasc)
        {
            this.nasc = nasc;
        }

        public string getNasc()
        {
            return this.nasc;
        }

        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }

        public string getSexo()
        {
            return this.sexo;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string getTelefone()
        {
            return this.telefone;
        }

    }
}
