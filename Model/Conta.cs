using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Conta
    {
        private Cliente cliente = new Cliente();

        private double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private String dataGeracao;

        public String DataGeracao
        {
            get { return dataGeracao; }
            set { dataGeracao = value; }
        }

        private String dataVencimento;

        public String DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        public Conta()
        {

        }

        public void cadastrarConta() { }
        public void consultarConta() { }
    }
}
