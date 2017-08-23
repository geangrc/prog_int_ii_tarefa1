using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa1
{
    class Pessoa
    {
        private String tipo;
        private String nome;
    
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getTipo()
        {
            return tipo;
        }

        public string getNome()
        {
            return nome;
        }

    }

}
