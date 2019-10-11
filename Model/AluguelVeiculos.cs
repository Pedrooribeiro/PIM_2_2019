using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Model
{
    public class AluguelVeiculos
    {
        DBConnection dbConnection = new DBConnection();

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }


        private string numeroVeiculos;

        public string NumeroVeiculos
        {
            get { return numeroVeiculos; }
            set { numeroVeiculos = value; }
        }

        private String tipoVeiculo;

        public String TipoVeiculo
        {
            get { return tipoVeiculo; }
            set { tipoVeiculo = value; }
        }


        private string dataInicio;

        public string DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        private string dataEntrega;

        public string DataEntrega
        {
            get { return dataEntrega; }
            set { dataEntrega = value; }
        }

        private double valorTtotal;

        public double ValorTotal
        {
            get { return valorTtotal; }
            set { valorTtotal = value; }
        }

        private string cpfConsultado;

        public string CpfConsultado
        {
            get { return cpfConsultado; }
            set { cpfConsultado = value; }
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

        public AluguelVeiculos()
        {

        }

        public void cadastrarAluguel() {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO aluguel_veiculos (cpf, numero_veiculos, data_inicio, data_entrega) VALUES (@cpf, @numeroVeiculos, @dataInicio, @dataEntrega)");
                cmdCadastrar.Parameters.AddWithValue("@cpf", this.cpf);
                cmdCadastrar.Parameters.AddWithValue("@numeroVeiculos", this.numeroVeiculos);
                cmdCadastrar.Parameters.AddWithValue("@dataInicio", this.dataInicio);
                cmdCadastrar.Parameters.AddWithValue("@dataEntrega", this.dataEntrega);
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

        public void consultarAluguel() {
            try
            {
                dbConnection.open();
                SqlCommand cmdConsultar = new SqlCommand("SELECT cpf, numero_veiculos, data_inicio, data_entrega FROM aluguel_veiculos WHERE cpf = @cpfConsultado", dbConnection.getSqlConn());
                cmdConsultar.Parameters.AddWithValue("@cpfConsultado", this.cpfConsultado);

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
    }
}
