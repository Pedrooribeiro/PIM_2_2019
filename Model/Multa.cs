using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Multa
    {
        private Veiculo veiculo = new Veiculo();
        private Motorista motorista = new Motorista();

        private String data;

        public String Data
        {
            get { return data; }
            set { data = value; }
        }

        private String autoInfracao;

        public String AutoInfracao
        {
            get { return autoInfracao; }
            set { autoInfracao = value; }
        }

        private String descricaoInfracao;

        public String DescricaoInfracao
        {
            get { return descricaoInfracao; }
            set { descricaoInfracao = value; }
        }

        private String local;

        public String Local
        {
            get { return local; }
            set { local = value; }
        }

        private double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private String gravidade;

        public String Gravidade
        {
            get { return gravidade; }
            set { gravidade = value; }
        }

        private String dataVencimento;

        public String DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        private String dataPagamento;

        public String DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }

        private String situacao;

        public String Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }


        public Multa()
        {

        }

        public void cadastrarMulta() { }
        public void consultarMulta() { }
        public void excluirMulta() { }
    }
}
