using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Seguro
    {
        private Veiculo veiculo = new Veiculo();

        private String numeroApolice;

        public String NumeroApolice
        {
            get { return numeroApolice; }
            set { numeroApolice = value; }
        }

        private String seguradora;

        public String Seguradora
        {
            get { return seguradora; }
            set { seguradora = value; }
        }

        private String segurado;

        public String Segurado
        {
            get { return segurado; }
            set { segurado = value; }
        }

        private String corretor;

        public String Corretor
        {
            get { return corretor; }
            set { corretor = value; }
        }

        private String dataInicio;

        public String DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        private String dataVencimento;

        public String DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        private double valorTotal;

        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        private double numeroParcelas;

        public double NumeroParcelas
        {
            get { return numeroParcelas; }
            set { numeroParcelas = value; }
        }

        private String situacao;

        public String Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        public Seguro()
        {

        }

        public void cadastrarSeguro() { }
        public void consultarSeguro() { }
        public void modificarSeguro() { }
        public void excluirSeguro() { }
    }
}
