using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Sinistro
    {
        private Veiculo veiculo = new Veiculo();
        private Motorista motorista = new Motorista();

        private String data;

        public String Data
        {
            get { return data; }
            set { data = value; }
        }

        private String descricaoOcorrido;

        public String DescricaoOcorrido
        {
            get { return descricaoOcorrido; }
            set { descricaoOcorrido = value; }
        }

        private String local;

        public String Local
        {
            get { return local; }
            set { local = value; }
        }

        private String seguro;

        public String Seguro
        {
            get { return seguro; }
            set { seguro = value; }
        }

        public Sinistro()
        {

        }

        public void cadastrarSinistro() { }
        public void consultarSinistro() { }
        public void modificarSinisitro() { }
        public void excluirSinistro() { }
    }
}
