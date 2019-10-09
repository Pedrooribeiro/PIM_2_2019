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
    public class Multa
    {
        DBConnection dbConnection = new DBConnection();

        private string placa;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }


        private string data;

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        private string autoInfracao;

        public string AutoInfracao
        {
            get { return autoInfracao; }
            set { autoInfracao = value; }
        }

        private string descricaoInfracao;

        public string DescricaoInfracao
        {
            get { return descricaoInfracao; }
            set { descricaoInfracao = value; }
        }

        private string local;

        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        private string valor;

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private string gravidade;

        public string Gravidade
        {
            get { return gravidade; }
            set { gravidade = value; }
        }

        private string dataVencimento;

        public string DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        private string dataPagamento;

        public string DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }

        private string situacao;

        public string Situacao
        {
            get { return situacao; }
            set { situacao = value; }
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

        private DataTable dataTable = new DataTable();

        public DataTable DataTable
        {
            get { return this.dataTable; }
        }

        private int idMulta;

        public int IdMulta
        {
            get { return idMulta; }
            set { idMulta = value; }
        }

        public Multa()
        {

        }

        public void cadastrarMulta() {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO multas (data_multa, auto_infracao, descricao_infracao, local_multa, gravidade, data_vencimento, data_pagamento, situacao, placa, cpf, valor) VALUES (@dataMulta, @autoInfracao, @descricaoInfracao, @localMulta, @gravidade, @dataVencimento, @dataPagamento, @situacao, @placa, @cpf, @valor)");
                cmdCadastrar.Parameters.AddWithValue("@dataMulta", this.data);
                cmdCadastrar.Parameters.AddWithValue("@autoInfracao", this.autoInfracao);
                cmdCadastrar.Parameters.AddWithValue("@descricaoInfracao", this.descricaoInfracao);
                cmdCadastrar.Parameters.AddWithValue("@localMulta", this.local);
                cmdCadastrar.Parameters.AddWithValue("@gravidade", this.gravidade);
                cmdCadastrar.Parameters.AddWithValue("@dataVencimento", this.dataVencimento);
                cmdCadastrar.Parameters.AddWithValue("@dataPagamento", this.dataPagamento);
                cmdCadastrar.Parameters.AddWithValue("@situacao", this.situacao);
                cmdCadastrar.Parameters.AddWithValue("@placa", this.placa);
                cmdCadastrar.Parameters.AddWithValue("@cpf", this.cpf);
                cmdCadastrar.Parameters.AddWithValue("@valor", this.valor);
                cmdCadastrar.Connection = dbConnection.getSqlConn();
                cmdCadastrar.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Erro ao cadastrar! Campos vazios ou preenchidos incorretamente, tente novamente.", "Erro");
                passou = false;
            }
            finally
            {
                dbConnection.close();
            }
        }

        public void consultarMulta() {
            try
            {
                dbConnection.open();
                SqlCommand cmdConsultar = new SqlCommand("SELECT id_multa, data_multa, auto_infracao, descricao_infracao, local_multa, gravidade, data_vencimento, data_pagamento, situacao, placa, cpf, valor FROM multas WHERE placa = @placaConsultada", dbConnection.getSqlConn());
                cmdConsultar.Parameters.AddWithValue("@placaConsultada", this.placaConsultada);

                SqlDataAdapter adaptadorEntrada = new SqlDataAdapter();
                adaptadorEntrada.SelectCommand = cmdConsultar;
                adaptadorEntrada.Fill(this.dataTable);

                if (this.dataTable == null)
                {
                    MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente", "Erro");
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
                MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente", "Erro");
                passou = false;
            }
            finally
            {
                dbConnection.close();
            }
        }

        public void modificarMulta() {
            try
            {
                dbConnection.open();
                SqlCommand cmdModificar = new SqlCommand("UPDATE multas SET data_multa = @dataMulta, auto_infracao = @autoInfracao, descricao_infracao = @descricaoInfracao, local_multa = @local, data_vencimento = @dataVencimento, data_pagamento = @dataPagamento, situacao = @situacao, placa = @placa, cpf = @cpf, valor = @valor, gravidade = @gravidade  WHERE placa = @placaConsultada AND id_multa = @idMulta");
                cmdModificar.Parameters.AddWithValue("@dataMulta", this.data);
                cmdModificar.Parameters.AddWithValue("@autoInfracao", this.autoInfracao);
                cmdModificar.Parameters.AddWithValue("@descricaoInfracao", this.descricaoInfracao);
                cmdModificar.Parameters.AddWithValue("@local", this.local);
                cmdModificar.Parameters.AddWithValue("@gravidade", this.gravidade);
                cmdModificar.Parameters.AddWithValue("@dataVencimento", this.dataVencimento);
                cmdModificar.Parameters.AddWithValue("@dataPagamento", this.dataPagamento);
                cmdModificar.Parameters.AddWithValue("@situacao", this.situacao);
                cmdModificar.Parameters.AddWithValue("@placa", this.placa);
                cmdModificar.Parameters.AddWithValue("@cpf", this.cpf);
                cmdModificar.Parameters.AddWithValue("@valor", this.valor);
                cmdModificar.Parameters.AddWithValue("@placaConsultada", this.placaConsultada);
                cmdModificar.Parameters.AddWithValue("@idMulta", this.idMulta);
                cmdModificar.Connection = dbConnection.getSqlConn();
                cmdModificar.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                MessageBox.Show("Erro ao modificar! Campos vazios ou preenchidos incorretamente, tente novamente.", "Erro");
                passou = false;
            }
            finally
            {
                dbConnection.close();
            }
        }

        public void excluirMulta() {
            try
            {
                dbConnection.open();
                SqlCommand cmdExcluir = new SqlCommand("DELETE FROM multas WHERE placa = @placaConsultada");
                cmdExcluir.Parameters.AddWithValue("@placaConsultada", this.placaConsultada);
                cmdExcluir.Connection = dbConnection.getSqlConn();
                cmdExcluir.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
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
