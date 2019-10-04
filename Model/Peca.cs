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
    public class Peca
    {
        DBConnection dbConnection = new DBConnection();

        private string veiculo;

        public string Veiculo
        {
            get { return veiculo; }
            set { veiculo = value; }
        }


        private String tipo;

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private String descricao;

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private string quantidade;

        public string Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        private string valorUnitario;

        public string ValorUnitario
        {
            get { return valorUnitario; }
            set { valorUnitario = value; }
        }

        private string nomeConsultado;

        public string NomeConsultado
        {
            get { return nomeConsultado; }
            set { nomeConsultado = value; }
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

        public Peca()
        {

        }

        public void cadastrarPeca() {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO estoque_peca (tipo, nome, descricao, quantidade, valor_unitario, nome_veiculo) VALUES (@tipo, @nome, @descricao, @quantidade, @valorUnitario, @nomeVeiculo)");
                cmdCadastrar.Parameters.AddWithValue("@tipo", this.tipo);
                cmdCadastrar.Parameters.AddWithValue("@nome", this.nome);
                cmdCadastrar.Parameters.AddWithValue("@descricao", this.descricao);
                cmdCadastrar.Parameters.AddWithValue("@quantidade", this.quantidade);
                cmdCadastrar.Parameters.AddWithValue("@valorUnitario", this.valorUnitario);
                cmdCadastrar.Parameters.AddWithValue("@nomeVeiculo", this.veiculo);
                cmdCadastrar.Connection = dbConnection.getSqlConn();
                cmdCadastrar.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                MessageBox.Show("Erro ao cadastrar! Campos vazios ou preenchidos incorretamente, tente novamente.", "Erro");
                passou = false;
            }
            finally
            {
                dbConnection.close();
            }
        }

        public void consultarPeca() {
            try
            {
                dbConnection.open();
                SqlCommand cmdConsultar = new SqlCommand ("SELECT tipo, nome, descricao, quantidade, valor_unitario, nome_veiculo FROM estoque_peca WHERE nome = @nomeConsultado", dbConnection.getSqlConn());
                cmdConsultar.Parameters.AddWithValue("@nomeConsultado", this.nomeConsultado);

                SqlDataAdapter adaptadorEntrada = new SqlDataAdapter();
                adaptadorEntrada.SelectCommand = cmdConsultar;
                adaptadorEntrada.Fill(this.dataTable);
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

        public void modificarPeca() {
            try
            {
                dbConnection.open();
                SqlCommand cmdModificar = new SqlCommand("UPDATE estoque_peca SET tipo = @tipo, nome = @nome, descricao = @descricao, quantidade = @quantidade, valor_unitario = @valorUnitario, nome_veiculo = @nomeVeiculo WHERE nome = @nomeConsultado");
                cmdModificar.Parameters.AddWithValue("@tipo", this.tipo);
                cmdModificar.Parameters.AddWithValue("@nome", this.nome);
                cmdModificar.Parameters.AddWithValue("@descricao", this.descricao);
                cmdModificar.Parameters.AddWithValue("@quantidade", this.quantidade);
                cmdModificar.Parameters.AddWithValue("@valorUnitario", this.valorUnitario);
                cmdModificar.Parameters.AddWithValue("@nomeVeiculo", this.veiculo);
                cmdModificar.Parameters.AddWithValue("@nomeConsultado", this.NomeConsultado);
                cmdModificar.Connection = dbConnection.getSqlConn();
                cmdModificar.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);

                MessageBox.Show("Erro ao modificar! Campos vazios ou preenchidos incorretamente, tente novamente.", "Erro");
                passou = false;
            }
            finally
            {
                dbConnection.close();
            }
        }
    }
}
