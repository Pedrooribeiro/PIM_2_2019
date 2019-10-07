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
    public class Manutencao
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

        private string motivo;

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        private string estabelecimento;

        public string Estabelecimento
        {
            get { return estabelecimento; }
            set { estabelecimento = value; }
        }

        private string valorTotal;

        public string ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
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

        private int idManutencao;

        public int IdManutencao
        {
            get { return idManutencao; }
            set { idManutencao = value; }
        }


        public Manutencao()
        {

        }

        public void cadastrarManutencao() {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO manutencoes (data_manutencao, motivo, estabelecimento, placa, valor_total) VALUES (@dataManutencao, @motivo, @estabelecimento, @placa, @valorTotal)");
                cmdCadastrar.Parameters.AddWithValue("@dataManutencao", this.data);
                cmdCadastrar.Parameters.AddWithValue("@motivo", this.motivo);
                cmdCadastrar.Parameters.AddWithValue("@estabelecimento", this.estabelecimento);
                cmdCadastrar.Parameters.AddWithValue("@placa", this.placa);
                cmdCadastrar.Parameters.AddWithValue("@valorTotal", this.valorTotal);
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

        public void consultarManutencao() {
            try
            {
                dbConnection.open();
                SqlCommand cmdConsultar = new SqlCommand("SELECT id_manutencao, data_manutencao, motivo, estabelecimento, placa, valor_total FROM manutencoes WHERE placa = @placaConsultada", dbConnection.getSqlConn());
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

        public void modificarManutencao() {
            try
            {
                dbConnection.open();
                SqlCommand cmdModificar = new SqlCommand("UPDATE manutencoes SET data_manutencao = @dataManutencao, motivo = @motivo, estabelecimento = @estabelecimento, placa = @placa, valor_total = @valorTotal WHERE placa = @placaConsultada AND id_manutencao = @idManutencao");
                cmdModificar.Parameters.AddWithValue("@dataManutencao", this.data);
                cmdModificar.Parameters.AddWithValue("@motivo", this.motivo);
                cmdModificar.Parameters.AddWithValue("@estabelecimento", this.estabelecimento);
                cmdModificar.Parameters.AddWithValue("@placa", this.placa);
                cmdModificar.Parameters.AddWithValue("@valorTotal", this.valorTotal);
                cmdModificar.Parameters.AddWithValue("@placaConsultada", this.placaConsultada);
                cmdModificar.Parameters.AddWithValue("@idManutencao", this.idManutencao);
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
