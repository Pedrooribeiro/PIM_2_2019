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
    public class Viagem
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


        private String data;

        public String Data
        {
            get { return data; }
            set { data = value; }
        }

        private String dataEntregar;

        public String DataEntregar
        {
            get { return dataEntregar; }
            set { dataEntregar = value; }
        }

        private String dataEntregue;

        public String DataEntregue
        {
            get { return dataEntregue; }
            set { dataEntregue = value; }
        }

        private String motivo;

        public String Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        private String situacao;

        public String Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        private double kmInicial;

        public double KmInicial
        {
            get { return kmInicial; }
            set { kmInicial = value; }
        }

        private double kmFinal;

        public double KmFinal
        {
            get { return kmFinal; }
            set { kmFinal = value; }
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

        public Viagem()
        {

        }

        public void cadastrarViagem()
        {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO viagens (data_viagem, data_entregar, data_entregue, motivo, situacao, km_inicial, km_final, placa, cpf) VALUES (@data, @dataEntregar, @dataEntregue, @motivo, @situacao, @kmInicial, @kmFinal, @placa, @cpf)");
                cmdCadastrar.Parameters.AddWithValue("@data", this.data);
                cmdCadastrar.Parameters.AddWithValue("@dataEntregar", this.dataEntregar);
                cmdCadastrar.Parameters.AddWithValue("@dataEntregue", this.dataEntregue);
                cmdCadastrar.Parameters.AddWithValue("@motivo", this.motivo);
                cmdCadastrar.Parameters.AddWithValue("@situacao", this.situacao);
                cmdCadastrar.Parameters.AddWithValue("@kmInicial", this.kmInicial);
                cmdCadastrar.Parameters.AddWithValue("@kmFinal", this.kmFinal);
                cmdCadastrar.Parameters.AddWithValue("@placa", this.placa);
                cmdCadastrar.Parameters.AddWithValue("@cpf", this.cpf);
                cmdCadastrar.Connection = dbConnection.getSqlConn();
                cmdCadastrar.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException sqlException) { 
            
                MessageBox.Show("Erro ao cadastrar! Campos vazios ou preenchidos incorretamente, tente novamente.", "Erro");
                this.passou = false;
            }
            finally
            {
                dbConnection.close();
            }
}

        public void consultarViagem()
        {
            try
            {
                dbConnection.open();
                SqlCommand cmdConsultar = new SqlCommand("SELECT data_viagem, data_entregar, data_entregue, motivo, situacao, km_inicial, km_final, placa, cpf FROM viagens WHERE placa = @placaConsultada", dbConnection.getSqlConn());
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
    }
}
