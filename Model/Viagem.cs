using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Viagem
    {
        private Veiculo veiculo = new Veiculo();
        private Motorista motorista = new Motorista();

        private String data;

        public String Data
        {
            get { return data; }
            set { data = value; }
        }

        private String dataEntregar;

        public String DataEntregar
        {
            get { return dataEntregar; }
            set { dataEntregar = value; }
        }

        private String dataEntregue;

        public String DataEntregue
        {
            get { return dataEntregue; }
            set { dataEntregue = value; }
        }

        private String motivo;

        public String Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        private String situacao;

        public String Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        private double kmInicial;

        public double KmInicial
        {
            get { return kmInicial; }
            set { kmInicial = value; }
        }

        private double kmFinal;

        public double KmFinal
        {
            get { return kmFinal; }
            set { kmFinal = value; }
        }


        public Viagem()
        {

        }

        public Boolean cadastrarViagem { get; set; }
        public Boolean consultarViagem { get; set; }
    }
}
