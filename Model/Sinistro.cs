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
    public class Sinistro
    {
        DBConnection dbConnection = new DBConnection();

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

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

        private string descricaoOcorrido;

        public string DescricaoOcorrido
        {
            get { return descricaoOcorrido; }
            set { descricaoOcorrido = value; }
        }

        private string local;

        public string Local
        {
            get { return local; }
            set { local = value; }
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

        private int idSinistro;

        public int IdSinistro
        {
            get { return idSinistro; }
            set { idSinistro = value; }
        }


        public Sinistro()
        {

        }

        public void cadastrarSinistro() {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO sinistros (data_sinistro, descricao_ocorrido, local_sinistro, placa, cpf) VALUES (@data, @descricaoOcorrido, @localSinistro, @placa, @cpf)");
                cmdCadastrar.Parameters.AddWithValue("@data", this.data);
                cmdCadastrar.Parameters.AddWithValue("@descricaoOcorrido", this.descricaoOcorrido);
                cmdCadastrar.Parameters.AddWithValue("@localSinistro", this.local);
                cmdCadastrar.Parameters.AddWithValue("@placa", this.placa);
                cmdCadastrar.Parameters.AddWithValue("@cpf", this.cpf);
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

        public void consultarSinistro() {
            try
            {
                dbConnection.open();
                SqlCommand cmdConsultar = new SqlCommand("SELECT id_sinistro, data_sinistro, descricao_ocorrido, local_sinistro, placa, cpf FROM sinistros WHERE placa = @placaConsultada", dbConnection.getSqlConn());
                cmdConsultar.Parameters.AddWithValue("@placaConsultada", this.placaConsultada);

                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = cmdConsultar;
                adaptador.Fill(this.dataTable);
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

        public void modificarSinistro() {
            try
            {
                dbConnection.open();
                SqlCommand cmdModificar = new SqlCommand("UPDATE sinistros SET data_sinistro = @dataSinistro, descricao_ocorrido = @descricaoOcorrido, local_sinistro = @localSinistro,  placa = @placa, cpf = @cpf WHERE placa = @placaConsultada AND id_sinistro = @idSinistro");
                cmdModificar.Parameters.AddWithValue("@dataSinistro", this.data);
                cmdModificar.Parameters.AddWithValue("@descricaoOcorrido", this.descricaoOcorrido);
                cmdModificar.Parameters.AddWithValue("@localSinistro", this.local);
                cmdModificar.Parameters.AddWithValue("@placa", this.placa);
                cmdModificar.Parameters.AddWithValue("@cpf", this.cpf);
                cmdModificar.Parameters.AddWithValue("@placaConsultada", this.placaConsultada);
                cmdModificar.Parameters.AddWithValue("@idSinistro", this.idSinistro);
                cmdModificar.Connection = dbConnection.getSqlConn();
                cmdModificar.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
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
