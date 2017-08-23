using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa1
{
    class Juridica : Pessoa
    {
        private String cnpj;

        public void setCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public string getCnpj()
        {
            return this.cnpj;
        }
    }
}
