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
    public class Abastecimento
    {
        DBConnection dbConnection = new DBConnection();

        private string placa;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private string data;

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        private string tipoCombustivel;

        public string TipoCombustivel
        {
            get { return tipoCombustivel; }
            set { tipoCombustivel = value; }
        }

        private string posto;

        public string Posto
        {
            get { return posto; }
            set { posto = value; }
        }

        private string valorLitro;

        public string ValorLitro
        {
            get { return valorLitro; }
            set { valorLitro = value; }
        }

        private string valorTotal;

        public string ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        private string litros;

        public string Litros
        {
            get { return litros; }
            set { litros = value; }
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

        private int idAbastecimento;

        public int IdAbastecimento
        {
            get { return idAbastecimento; }
            set { idAbastecimento = value; }
        }

        public Abastecimento()
        {

        }

        public void cadastrarAbastecimento() {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO abastecimentos (data_abastecimento, tipo_combustivel, posto, placa, valor_litro, valor_total, litros) VALUES (@dataAbastecimento, @tipoCombustivel, @posto, @placa, @valorLitro, @valorTotal, @litros)");
                cmdCadastrar.Parameters.AddWithValue("@dataAbastecimento", this.data);
                cmdCadastrar.Parameters.AddWithValue("@tipoCombustivel", this.tipoCombustivel);
                cmdCadastrar.Parameters.AddWithValue("@posto", this.posto);
                cmdCadastrar.Parameters.AddWithValue("@placa", this.placa);
                cmdCadastrar.Parameters.AddWithValue("@valorLitro", this.valorLitro);
                cmdCadastrar.Parameters.AddWithValue("@valorTotal", this.valorTotal);
                cmdCadastrar.Parameters.AddWithValue("@litros", this.litros);
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

        public void consultarAbastecimento() {
            try
            {
                dbConnection.open();
                SqlCommand cmdConsultar = new SqlCommand("SELECT id_abastecimento, data_abastecimento, tipo_combustivel, posto, placa, valor_litro, valor_total, litros FROM abastecimentos WHERE placa = @placaConsultada", dbConnection.getSqlConn());
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

        public void modificarAbastecimento() {
            try
            {
                dbConnection.open();
                SqlCommand cmdModificar = new SqlCommand("UPDATE abastecimentos SET data_abastecimento = @dataAbastecimento, tipo_combustivel = @tipoCombustivel, posto = @posto, placa = @placa, valor_litro = @valorLitro, valor_total = @valorTotal, litros = @litros WHERE placa = @placaConsultada AND id_abastecimento = @idAbastecimento");
                cmdModificar.Parameters.AddWithValue("@dataAbastecimento", this.data);
                cmdModificar.Parameters.AddWithValue("@tipoCombustivel", this.tipoCombustivel);
                cmdModificar.Parameters.AddWithValue("@posto", this.posto);
                cmdModificar.Parameters.AddWithValue("@placa", this.placa);
                cmdModificar.Parameters.AddWithValue("@valorLitro", this.valorLitro);
                cmdModificar.Parameters.AddWithValue("@valorTotal", this.valorTotal);
                cmdModificar.Parameters.AddWithValue("@litros", this.litros);
                cmdModificar.Parameters.AddWithValue("@placaConsultada", this.PlacaConsultada);
                cmdModificar.Parameters.AddWithValue("@idAbastecimento", this.idAbastecimento);
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
    }
}
