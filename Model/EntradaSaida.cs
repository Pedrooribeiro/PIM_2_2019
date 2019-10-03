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
    public class EntradaSaida
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


        private String dataEntrada;

        public String DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }

        private String dataSaida;
                    
        public String DataSaida
        {
            get { return dataSaida; }
            set { dataSaida = value; }
        }

        private string horarioEntrada;

        public string HorarioEntrada
        {
            get { return horarioEntrada; }
            set { horarioEntrada = value; }
        }

        private string horarioSaida;

        public string HorarioSaida
        {
            get { return horarioSaida; }
            set { horarioSaida = value; }
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

        private DataTable dataTableEntrada = new DataTable();

        public DataTable DataTableEntrada
        {
            get { return this.dataTableEntrada; }
        }

        private DataTable dataTableSaida = new DataTable();

        public DataTable DataTableSaida
        {
            get { return this.dataTableSaida; }
        }

        public EntradaSaida()
        {

        }

        public void cadastrarEntrada() {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO entradas (data_entrada, placa, cpf, horario_entrada) VALUES (@dataEntrada, @placa, @cpf, @horarioEntrada)");
                cmdCadastrar.Parameters.AddWithValue("@dataEntrada", this.dataEntrada);
                cmdCadastrar.Parameters.AddWithValue("@placa", this.placa);
                cmdCadastrar.Parameters.AddWithValue("@cpf", this.cpf);
                cmdCadastrar.Parameters.AddWithValue("@horarioEntrada", this.horarioEntrada);
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
        public void cadastrarSaida() {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO saidas (data_saida, placa, cpf, horario_saida) VALUES (@dataSaida, @placa, @cpf, @horarioSaida)");
                cmdCadastrar.Parameters.AddWithValue("@dataSaida", this.dataSaida);
                cmdCadastrar.Parameters.AddWithValue("@placa", this.placa);
                cmdCadastrar.Parameters.AddWithValue("@cpf", this.cpf);
                cmdCadastrar.Parameters.AddWithValue("@horarioSaida", this.horarioSaida);
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
        public void consultarDatas() {
            try
            {
                dbConnection.open();
                SqlCommand cmdConsultarEntrada = new SqlCommand("SELECT data_entrada, placa, cpf, horario_entrada FROM entradas WHERE placa = @placaConsultada", dbConnection.getSqlConn());
                cmdConsultarEntrada.Parameters.AddWithValue("@placaConsultada", this.placaConsultada);

                SqlDataAdapter adaptadorEntrada = new SqlDataAdapter();
                adaptadorEntrada.SelectCommand = cmdConsultarEntrada;
                adaptadorEntrada.Fill(this.dataTableEntrada);

                SqlCommand cmdConsultarSaida = new SqlCommand("SELECT data_saida, placa, cpf, horario_saida FROM saidas WHERE placa = @placaConsultada", dbConnection.getSqlConn());
                cmdConsultarSaida.Parameters.AddWithValue("@placaConsultada", this.placaConsultada);

                SqlDataAdapter adaptadorSaida = new SqlDataAdapter();
                adaptadorSaida.SelectCommand = cmdConsultarSaida;
                adaptadorSaida.Fill(this.dataTableSaida);
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
    }
}
