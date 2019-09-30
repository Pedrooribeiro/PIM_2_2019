using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class EntradaSaida
    {
        private Veiculo veiculo = new Veiculo();

        private String dataEntrada;

        public String DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }

        private String dataSaida;
                    
        public String DataSaida
        {
            get { return dataSaida; }
            set { dataSaida = value; }
        }
        
        public EntradaSaida()
        {

        }

        public void cadastrarEntrada() { }
        public void cadastrarSaida() { }
        public void consultarDatas() { }
    }
}
