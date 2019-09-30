using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Abastecimento
    {
        private Veiculo veiculo = new Veiculo();

        private String data;

        public String Data
        {
            get { return data; }
            set { data = value; }
        }

        private String tipoCombustivel;

        public String TipoCombustivel
        {
            get { return tipoCombustivel; }
            set { tipoCombustivel = value; }
        }

        private String posto;

        public String Posto
        {
            get { return posto; }
            set { posto = value; }
        }

        private double valorLitro;

        public double ValorLitro
        {
            get { return valorLitro; }
            set { valorLitro = value; }
        }

        private double valorTotal;

        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        public Abastecimento()
        {

        }

        public void cadastrarAbastecimento() { }
        public void consultarAbastecimento() { }
        public void excluirAbastecimento() { }
    }
}
