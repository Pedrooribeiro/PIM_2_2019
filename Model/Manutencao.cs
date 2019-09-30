using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Manutencao
    {
        private Veiculo veiculo = new Veiculo();

        private String data;

        public String Data
        {
            get { return data; }
            set { data = value; }
        }

        private String motivo;

        public String Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        private String estabelecimento;

        public String Estabelecimento
        {
            get { return estabelecimento; }
            set { estabelecimento = value; }
        }

        private double valorTotal;

        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        public Manutencao()
        {

        }

        public void cadastrarManutencao() { }
        public void consultarManutencao() { }
        public void excluirManutencao() { }
    }
}
