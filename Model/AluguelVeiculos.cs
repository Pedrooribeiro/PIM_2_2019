using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class AluguelVeiculos
    {
        private Cliente cliente = new Cliente();

        private int numeroVeiculos;

        public int NumeroVeiculos
        {
            get { return numeroVeiculos; }
            set { numeroVeiculos = value; }
        }

        private String tipoVeiculo;

        public String TipoVeiculo
        {
            get { return tipoVeiculo; }
            set { tipoVeiculo = value; }
        }


        private String dataInicio;

        public String DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        private String dataEntrega;

        public String DataEntrega
        {
            get { return dataEntrega; }
            set { dataEntrega = value; }
        }

        private double valorTtotal;

        public double ValorTotal
        {
            get { return valorTtotal; }
            set { valorTtotal = value; }
        }    
        
        public AluguelVeiculos()
        {

        }

        public void cadastrarAluguel() { }
        public void consultarAluguel() { }
        public void modificarAluguel() { }
        public void excluirAluguel() { }
    }
}
