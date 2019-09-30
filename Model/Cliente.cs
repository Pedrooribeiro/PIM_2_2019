using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Cliente
    {
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private String rg;

        public String Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        private String cpf;

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private String endereco;

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private String empresa;

        public String Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        
        public Cliente()
        {

        }

        public Boolean cadastrarCliente() { return true; }
        public Boolean consultarCliente() { return true; }
        public Boolean modificarCliente() { return true; }
        public Boolean excluirCliente() { return true; }
    }
}
