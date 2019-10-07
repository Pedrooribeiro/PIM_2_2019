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
    public class Pneu
    {
        DBConnection dbConnection = new DBConnection();

        private string placa;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }


        private string numeroSerie;

        public string NumeroSerie
        {
            get { return numeroSerie; }
            set { numeroSerie = value; }
        }

        private string situacao;

        public string Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string dimensao;

        public string Dimensao
        {
            get { return dimensao; }
            set { dimensao = value; }
        }

        private Boolean passou = true;

        public Boolean Passou
        {
            get { return passou; }
            set { passou = value; }
        }

        private string placaConsultada;

        public string PlacaConsultada
        {
            get { return placaConsultada; }
            set { placaConsultada = value; }
        }

        private DataTable dataTable = new DataTable();

        public DataTable DataTable
        {
            get { return this.dataTable; }
        }

        public Pneu()
        {

        }

        public void cadastrarPneu() {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO pneus (numero_serie, situacao, marca, modelo, dimensao, placa) VALUES (@numeroSerie, @situacao, @marca, @modelo, @dimensao, @placa)");
                cmdCadastrar.Parameters.AddWithValue("@numeroSerie", this.numeroSerie);
                cmdCadastrar.Parameters.AddWithValue("@situacao", this.situacao);
                cmdCadastrar.Parameters.AddWithValue("@marca", this.marca);
                cmdCadastrar.Parameters.AddWithValue("@modelo", this.dimensao);
                cmdCadastrar.Parameters.AddWithValue("@dimensao", this.dimensao);
                cmdCadastrar.Parameters.AddWithValue("@placa", this.placa);
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
        public void consultarPneu() {
            try
            {
                dbConnection.open();
                SqlCommand cmdConsultar = new SqlCommand("SELECT numero_serie, situacao, marca, modelo, dimensao, placa FROM pneus WHERE placa = @placaConsultada", dbConnection.getSqlConn());
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
                MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente", "Erro");
                passou = false;
            }
            finally
            {
                dbConnection.close();
            }
        }
        public void excluirPneu() {
            try
            {
                dbConnection.open();
                SqlCommand cmdExcluir = new SqlCommand("DELETE FROM pneus WHERE placa = @placaConsultada");
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
