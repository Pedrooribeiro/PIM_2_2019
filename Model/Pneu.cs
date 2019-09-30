using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Pneu
    {
        private Veiculo veiculo = new Veiculo();

        private String numeroSerie;

        public String NumeroSerie
        {
            get { return numeroSerie; }
            set { numeroSerie = value; }
        }

        private String situacao;

        public String Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        private String marca;

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private String modelo;

        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private String dimensao;

        public String Dimensao
        {
            get { return dimensao; }
            set { dimensao = value; }
        }

        public Pneu()
        {

        }

        public Boolean cadastrarPneu() { return true; }
        public Boolean consultarPneu() { return true; }
        public Boolean excluirPneu() { return true; }
    }
}
