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
    public class Motorista
    {
        DBConnection dbConnection = new DBConnection();

        private String nomeCompleto;

        public String NomeCompleto
        {
            get { return nomeCompleto; }
            set { nomeCompleto = value; }
        }

        private String rg;

        public String Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        private String cpf;

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private String cnh;

        public String Cnh
        {
            get { return cnh; }
            set { cnh = value; }
        }

        private String vencimentoCnh;

        public String VencimentoCnh
        {
            get { return vencimentoCnh; }
            set { vencimentoCnh = value; }
        }

        private String empresa;

        public String Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        private string cpfConsultado;

        public string CpfConsultado
        {
            get { return cpfConsultado; }
            set { cpfConsultado = value; }
        }

        private Boolean passou;

        public Boolean Passou
        {
            get { return passou; }
            set { passou = value; }
        }


        public Motorista()
        {

        }

        public void cadastrarMotorista() {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrar = new SqlCommand("INSERT INTO motoristas (nome_completo, rg, cpf, cnh, vencimento_cnh, empresa) VALUES (@nomeCompleto, @rg, @cpf, @cnh, @vencimentoCnh, @empresa)");
                cmdCadastrar.Parameters.AddWithValue("@nomeCompleto", this.nomeCompleto);
                cmdCadastrar.Parameters.AddWithValue("@rg", this.rg);
                cmdCadastrar.Parameters.AddWithValue("@cpf", this.cpf);
                cmdCadastrar.Parameters.AddWithValue("@cnh", this.cnh);
                cmdCadastrar.Parameters.AddWithValue("@vencimentoCnh", this.vencimentoCnh);
                cmdCadastrar.Parameters.AddWithValue("@empresa", this.empresa);
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
                passou = true;
                dbConnection.close();
            }
        }
        public void consultarMotorista() {
            try
            {
                dbConnection.open();
                SqlCommand cmdConsultar = new SqlCommand("SELECT * FROM motoristas WHERE cpf = @cpfConsultado");
                cmdConsultar.Parameters.AddWithValue("@cpfConsultado", this.cpfConsultado);
                cmdConsultar.Connection = dbConnection.getSqlConn();
                SqlDataReader dr = cmdConsultar.ExecuteReader();
                while (dr.Read())
                {
                    this.nomeCompleto = dr["nome_completo"].ToString();
                    this.rg = dr["rg"].ToString();
                    this.cpf = dr["cpf"].ToString();
                    this.cnh = dr["cnh"].ToString();
                    this.vencimentoCnh = dr["vencimento_cnh"].ToString();
                    this.empresa = dr["empresa"].ToString();    
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
                passou = true;
            }
        }
        public Boolean modificarMotorista() { return true;  }
        public Boolean excluirMotorista() { return true; }
    }
}
