using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Quilometragem
    {
        private Veiculo veiculo = new Veiculo();

        private String dataInicio;

        public String DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        private String dataAtual;

        public String DataAtual
        {
            get { return dataAtual; }
            set { dataAtual = value; }
        }

        private double quilometrosRodados;

        public double QuilometrosRodados
        {
            get { return quilometrosRodados; }
            set { quilometrosRodados = value; }
        }


        public Quilometragem()
        {

        }

        public void cadastrarQuilometragem() { }
        public void consultarQuilometragem() { }
        public void excluirQuilometragem() { }
    }
}
