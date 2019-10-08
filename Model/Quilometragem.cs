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
    public class Quilometragem
    {
        DBConnection dbConnection = new DBConnection();

        private string placa;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }


        private string dataInicio;

        public string DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        private string dataAtual;

        public string DataAtual
        {
            get { return dataAtual; }
            set { dataAtual = value; }
        }

        private string quilometrosRodados;

        public string QuilometrosRodados
        {
            get { return quilometrosRodados; }
            set { quilometrosRodados = value; }
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

        public Quilometragem()
        {

        }

        public void cadastrarQuilometragem() {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO quilometragem (data_inicio, data_atual, placa, quilometros_rodados) VALUES (@dataInicio, @dataAtual, @placa, @quilometrosRodados)");
                cmdCadastrar.Parameters.AddWithValue("@dataInicio", this.dataInicio);
                cmdCadastrar.Parameters.AddWithValue("@dataAtual", this.dataAtual);
                cmdCadastrar.Parameters.AddWithValue("@placa", this.placa);
                cmdCadastrar.Parameters.AddWithValue("@quilometrosRodados", this.quilometrosRodados);
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

        public void consultarQuilometragem() {
            try
            {
                dbConnection.open();
                SqlCommand cmdConsultar = new SqlCommand("SELECT * FROM quilometragem WHERE placa = @placaConsultada");
                cmdConsultar.Parameters.AddWithValue("@placaConsultada", this.placaConsultada);
                cmdConsultar.Connection = dbConnection.getSqlConn();
                SqlDataReader dr = cmdConsultar.ExecuteReader();
                while (dr.Read())
                {
                    this.dataInicio = dr["data_inicio"].ToString();
                    this.dataAtual = dr["data_atual"].ToString();
                    this.placa = dr["placa"].ToString();
                    this.quilometrosRodados = dr["quilometros_rodados"].ToString();
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
        public void modificarQuilometragem() {
            try
            {
                dbConnection.open();
                SqlCommand cmdModificar = new SqlCommand("UPDATE quilometragem SET data_inicio = @dataInicio, data_atual = @dataAtual, placa = @placa, quilometros_rodados = @quilometrosRodados WHERE placa = @placaConsultada");
                cmdModificar.Parameters.AddWithValue("@dataInicio", this.dataInicio);
                cmdModificar.Parameters.AddWithValue("@dataAtual", this.dataAtual);
                cmdModificar.Parameters.AddWithValue("@placa", this.placa);
                cmdModificar.Parameters.AddWithValue("@quilometrosRodados", this.quilometrosRodados);
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
    }
}
