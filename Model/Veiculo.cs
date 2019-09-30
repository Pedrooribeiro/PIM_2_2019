using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Veiculo
    {
        private String cor;

        public String Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        private String placa;

        public String Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private String modelo;

        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private String marca;

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private int anoFabricacao;

        public int AnoFabricacao
        {
            get { return anoFabricacao; }
            set { anoFabricacao = value; }
        }

        private String motorizacao;

        public String Motorizacao
        {
            get { return motorizacao; }
            set { motorizacao = value; }
        }

        private String tipoCombustivel;

        public String TipoCombustivel
        {
            get { return tipoCombustivel; }
            set { tipoCombustivel = value; }
        }

        private String tipoVeiculo;

        public String TipoVeiculo
        {
            get { return tipoVeiculo; }
            set { tipoVeiculo = value; }
        }







        public Veiculo()
        {

        }

        public Boolean cadastrarVeiculo() { return true; }
        public Boolean consultarVeiculo() { return true; }
        public Boolean modificarVeiculo() { return true; }
        public Boolean excluirVeiculo() { return true; }

    }
}
