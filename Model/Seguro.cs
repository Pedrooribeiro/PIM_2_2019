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

        private string placaConsultada;

        public string PlacaConsultada
        {
            get { return placaConsultada; }
            set { placaConsultada = value; }
        }


        private Boolean passou = true;

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
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO seguros (numero_apolice,seguradora,segurado,corretor,data_inicio,data_vencimento,valor_total,numero_parcelas,situacao,placa_seguro) VALUES (@numeroApolice,@seguradora,@segurado,@corretor,@dataInicio,@dataVencimento,@valorTotal,@numeroParcelas,@situacao,@placaSeguro)");
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
                dbConnection.close();
            }
        }

        public void consultarSeguro() {
            try
            {
                dbConnection.open();
                SqlCommand cmdConsultar = new SqlCommand("SELECT * FROM seguros WHERE placa_seguro = @placaConsultada");
                cmdConsultar.Parameters.AddWithValue("@placaConsultada", this.placaConsultada);
                cmdConsultar.Connection = dbConnection.getSqlConn();
                SqlDataReader dr = cmdConsultar.ExecuteReader();
                while (dr.Read())
                {
                    this.numeroApolice = dr["numero_apolice"].ToString();
                    this.seguradora = dr["seguradora"].ToString();
                    this.segurado = dr["segurado"].ToString();
                    this.corretor = dr["corretor"].ToString();
                    this.dataInicio = dr["data_inicio"].ToString();
                    this.dataVencimento = dr["data_vencimento"].ToString();
                    this.valorTotal = double.Parse(dr["valor_total"].ToString());
                    this.numeroParcelas = dr["numero_parcelas"].ToString();
                    this.situacao = dr["situacao"].ToString();
                    this.placaSeguro = dr["placa_seguro"].ToString();
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente", "Erro");
                passou = false;
            }
            finally
            {
                dbConnection.close();
            }
        }
        public void modificarSeguro() {
            try
            {
                dbConnection.open();
                SqlCommand cmdModificar = new SqlCommand("UPDATE seguros SET numero_apolice = @numeroApolice, seguradora = @seguradora, segurado = @segurado, corretor = @corretor, data_inicio = @dataInicio, data_vencimento = @dataVencimento, valor_total = @valorTotal, numero_parcelas = @numeroParcelas, situacao = @situacao, placa_seguro = @placaSeguro WHERE placa_seguro = @placaConsultada");
                cmdModificar.Parameters.AddWithValue("@numeroApolice", this.numeroApolice);
                cmdModificar.Parameters.AddWithValue("@seguradora", this.seguradora);
                cmdModificar.Parameters.AddWithValue("@segurado", this.segurado);
                cmdModificar.Parameters.AddWithValue("@corretor", this.corretor);
                cmdModificar.Parameters.AddWithValue("@dataInicio", this.dataInicio);
                cmdModificar.Parameters.AddWithValue("@dataVencimento", this.dataVencimento);
                cmdModificar.Parameters.AddWithValue("@valorTotal", this.valorTotal);
                cmdModificar.Parameters.AddWithValue("@numeroParcelas", this.numeroParcelas);
                cmdModificar.Parameters.AddWithValue("@situacao", this.situacao);
                cmdModificar.Parameters.AddWithValue("@placaSeguro", this.placaSeguro);
                cmdModificar.Parameters.AddWithValue("@placaConsultada", this.placaConsultada);
                cmdModificar.Connection = dbConnection.getSqlConn();
                cmdModificar.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                MessageBox.Show("Erro ao modificar! Item não localizado, campos vazios ou preenchidos incorretamente, tente novamente.", "Erro");
                passou = false;
            }
            finally
            {
                dbConnection.close();
            }
        }

        public void excluirSeguro() {
            try
            {
                dbConnection.open();
                SqlCommand cmdExcluir = new SqlCommand("DELETE FROM seguros WHERE placa_seguro = @placaConsultada");
                cmdExcluir.Parameters.AddWithValue("@placaConsultada", this.placaConsultada);
                cmdExcluir.Connection = dbConnection.getSqlConn();
                cmdExcluir.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Erro ao excluir! Item não localizados, campos vazios ou preenchidos incorretamente, tente novamente.", "Erro");
                passou = false;
            }
            finally
            {
                dbConnection.close();
            }
        }
    }
}
