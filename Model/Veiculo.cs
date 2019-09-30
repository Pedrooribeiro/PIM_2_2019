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
    public class Veiculo
    {
        SqlConnection sqlConn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=dbControleFrotasDev;Trusted_Connection=True;");

        private string cor;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        private string placa;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string marca;

        public string Marca
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

        private string motorizacao;

        public string Motorizacao
        {
            get { return motorizacao; }
            set { motorizacao = value; }
        }

        private string tipoCombustivel;

        public string TipoCombustivel
        {
            get { return tipoCombustivel; }
            set { tipoCombustivel = value; }
        }

        public Veiculo()
        {

        }

        public void cadastrarVeiculo() {
            try
            {
                sqlConn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO veiculos (cor,placa,modelo,marca,ano_fabricacao,motorizacao,tipo_combustivel) VALUES (@cor,@placa,@modelo,@marca,@anoFabricacao,@motorizacao,@tipoCombustivel)");
                Console.Write(cmd);
                cmd.Parameters.AddWithValue("@cor", this.cor);
                cmd.Parameters.AddWithValue("@placa", this.placa);
                cmd.Parameters.AddWithValue("@modelo", this.modelo);
                cmd.Parameters.AddWithValue("@marca", this.marca);
                cmd.Parameters.AddWithValue("@anoFabricacao", this.anoFabricacao);
                cmd.Parameters.AddWithValue("@motorizacao", this.motorizacao);
                cmd.Parameters.AddWithValue("@tipoCombustivel", this.tipoCombustivel);
                Console.Write(cmd);
                cmd.Connection = this.sqlConn;
                int cmdResult = cmd.ExecuteNonQuery();
             }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                MessageBox.Show("Erro ao cadastrar! Campos vazios ou preenchidos incorretamente, tente novamente.", "Erro");
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public Boolean consultarVeiculo() { return true; }
        public Boolean modificarVeiculo() { return true; }
        public Boolean excluirVeiculo() { return true; }
    }
}
