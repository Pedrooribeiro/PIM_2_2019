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

        private string nomeCompleto;

        public string NomeCompleto
        {
            get { return nomeCompleto; }
            set { nomeCompleto = value; }
        }

        private string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string cnh;

        public string Cnh
        {
            get { return cnh; }
            set { cnh = value; }
        }

        private string vencimentoCnh;

        public string VencimentoCnh
        {
            get { return vencimentoCnh; }
            set { vencimentoCnh = value; }
        }

        private string empresa;

        public string Empresa
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

        private Boolean passou = true;

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
            }
        }
        public void modificarMotorista() {
            try
            {
                dbConnection.open();
                SqlCommand cmdModificar = new SqlCommand("UPDATE motoristas SET nome_completo = @nomeCompleto, rg = @rg, cpf = @cpf, cnh = @cnh, vencimento_cnh = @vencimentoCnh, empresa = @empresa WHERE cpf = @cpfConsultado");
                cmdModificar.Parameters.AddWithValue("@nomeCompleto", this.nomeCompleto);
                cmdModificar.Parameters.AddWithValue("@rg", this.rg);
                cmdModificar.Parameters.AddWithValue("@cpf", this.cpf);
                cmdModificar.Parameters.AddWithValue("@cnh", this.cnh);
                cmdModificar.Parameters.AddWithValue("@vencimentoCnh", this.vencimentoCnh);
                cmdModificar.Parameters.AddWithValue("@empresa", this.empresa);
                cmdModificar.Parameters.AddWithValue("@cpfConsultado", this.cpfConsultado);
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
        public void excluirMotorista() {
            try
            {
                dbConnection.open();
                SqlCommand cmdExcluir = new SqlCommand("DELETE FROM motoristas WHERE cpf = @cpfConsultado");
                cmdExcluir.Parameters.AddWithValue("@cpfConsultado", this.cpfConsultado);
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
