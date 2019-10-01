using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class Seguro
    {
        DBConnection dbConnection = new DBConnection();

        private string numeroApolice;

        public string NumeroApolice
        {
            get { return numeroApolice; }
            set { numeroApolice = value; }
        }

        private string seguradora;

        public string Seguradora
        {
            get { return seguradora; }
            set { seguradora = value; }
        }

        private string segurado;

        public string Segurado
        {
            get { return segurado; }
            set { segurado = value; }
        }

        private string corretor;

        public string Corretor
        {
            get { return corretor; }
            set { corretor = value; }
        }

        private string dataInicio;

        public string DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        private string dataVencimento;

        public string DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        private double valorTotal;

        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        private string numeroParcelas;

        public string NumeroParcelas
        {
            get { return numeroParcelas; }
            set { numeroParcelas = value; }
        }

        private string situacao;

        public string Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        private string placaSeguro;

        public string PlacaSeguro
        {
            get { return placaSeguro; }
            set { placaSeguro = value; }
        }

        private Boolean passou;

        public Boolean Passou
        {
            get { return passou; }
            set { passou = value; }
        }



        public Seguro()
        {

        }

        public void cadastrarSeguro() {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO seguros (numero_apolice,seguraora,segurado,corretor,data_inicio,data_vencimento,valor_total,numero_parcelas,situacao,placa_seguro) VALUES (@numeroApolice,@seguradora,@segurado,@corretor,@dataInicio,@dataVencimento,@valorTotal,@numeroParcelas,@situacao,@placaSeguro)");
                cmdCadastrar.Parameters.AddWithValue("@numeroApolice", this.numeroApolice);
                cmdCadastrar.Parameters.AddWithValue("@seguradora", this.seguradora);
                cmdCadastrar.Parameters.AddWithValue("@segurado", this.segurado);
                cmdCadastrar.Parameters.AddWithValue("@corretor", this.corretor);
                cmdCadastrar.Parameters.AddWithValue("@dataInicio", this.dataInicio);
                cmdCadastrar.Parameters.AddWithValue("@dataVencimento", this.dataVencimento);
                cmdCadastrar.Parameters.AddWithValue("@valorTotal", this.valorTotal);
                cmdCadastrar.Parameters.AddWithValue("@numeroParcelas", this.numeroParcelas);
                cmdCadastrar.Parameters.AddWithValue("@situacao", this.situacao);
                cmdCadastrar.Parameters.AddWithValue("@placaSeguro", this.placaSeguro);
                cmdCadastrar.Connection = dbConnection.getSqlConn();
                cmdCadastrar.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                MessageBox.Show("Erro ao cadastrar! Campos vazios ou preenchidos incorretamente, tente novamente.", "Erro");
                this.passou = false;
            }
            finally
            {
                this.passou = true;
                dbConnection.close();
            }
        }

        public void consultarSeguro() { }
        public void modificarSeguro() { }
        public void excluirSeguro() { }
    }
}
