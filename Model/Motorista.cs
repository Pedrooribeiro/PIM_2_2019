using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Motorista
    {
        private String nomeCompleto;

        public String NomeCompleto
        {
            get { return nomeCompleto; }
            set { nomeCompleto = value; }
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

        private String cnh;

        public String Cnh
        {
            get { return cnh; }
            set { cnh = value; }
        }

        private String vencimentoCnh;

        public String VencimentoCnh
        {
            get { return vencimentoCnh; }
            set { vencimentoCnh = value; }
        }

        private String empresa;

        public String Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public Motorista()
        {

        }

        public Boolean cadastrarMotorista() { return true; }
        public Boolean consultarMotorista() { return true;  }
        public Boolean modificarMotorista() { return true;  }
        public Boolean excluirMotorista() { return true; }
    }
}
