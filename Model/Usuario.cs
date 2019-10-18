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
    public class Usuario
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

        private string cpfConsultado;

        public string CpfConsultado
        {
            get { return cpfConsultado; }
            set { cpfConsultado = value; }
        }

        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string usernameConsultado;

        public string UsernameConsultado
        {
            get { return usernameConsultado; }
            set { usernameConsultado = value; }
        }

        private Boolean passou = true;

        public Boolean Passou
        {
            get { return passou; }
            set { passou = value; }
        }


        public Usuario()
        {

        }

        public void cadastrarUsuario() {
            try
            {
                dbConnection.open();
                SqlCommand cmdCadastrarUsuario = new SqlCommand("INSERT INTO usuarios (nome_completo, rg, cpf) VALUES (@nomeCompleto, @rg, @cpf)");
                SqlCommand cmdCadastrarLogin = new SqlCommand("INSERT INTO login (username, password) VALUES (@username, @password)");
                cmdCadastrarUsuario.Parameters.AddWithValue("@nomeCompleto", this.nomeCompleto);
                cmdCadastrarUsuario.Parameters.AddWithValue("@rg", this.rg);
                cmdCadastrarUsuario.Parameters.AddWithValue("@cpf", this.cpf);
                cmdCadastrarUsuario.Connection = dbConnection.getSqlConn();

                cmdCadastrarLogin.Parameters.AddWithValue("@username", this.username);
                cmdCadastrarLogin.Parameters.AddWithValue("@password", this.senha);
                cmdCadastrarLogin.Connection = dbConnection.getSqlConn();

                cmdCadastrarUsuario.ExecuteNonQuery();
                cmdCadastrarLogin.ExecuteNonQuery(); 
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
        public void consultarUsuario() {
            try
            {
                dbConnection.open();
                SqlCommand cmdConsultar = new SqlCommand("SELECT * FROM usuarios WHERE cpf = @cpfConsultado");
                cmdConsultar.Parameters.AddWithValue("@cpfConsultado", this.cpfConsultado);
                cmdConsultar.Connection = dbConnection.getSqlConn();

                SqlCommand cmdConsultarSenha = new SqlCommand("SELECT password FROM login WHERE username = @usernameConsultado");
                cmdConsultarSenha.Parameters.AddWithValue("@usernameConsultado", this.usernameConsultado);
                cmdConsultarSenha.Connection = dbConnection.getSqlConn();

                SqlDataReader dr = cmdConsultar.ExecuteReader();
                while (dr.Read())
                {
                    this.nomeCompleto = dr["nome_completo"].ToString();
                    this.rg = dr["rg"].ToString();
                    this.cpf = dr["cpf"].ToString();    
                }
                dr.Close();

                dr = cmdConsultarSenha.ExecuteReader();
                while (dr.Read())
                {
                    this.senha = dr["password"].ToString();
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
        public void modificarUsuario() {
            try
            {
                dbConnection.open();
                SqlCommand cmdModificarUsuario = new SqlCommand("UPDATE usuarios SET nome_completo = @nomeCompleto, rg = @rg, cpf = @cpf WHERE cpf = @cpfConsultado");
                SqlCommand cmdModificarLogin = new SqlCommand("UPDATE login SET username = @username, password = @password WHERE username = @usernameConsultado");

                cmdModificarUsuario.Parameters.AddWithValue("@nomeCompleto", this.nomeCompleto);
                cmdModificarUsuario.Parameters.AddWithValue("@rg", this.rg);
                cmdModificarUsuario.Parameters.AddWithValue("@cpf", this.cpf);
                cmdModificarUsuario.Parameters.AddWithValue("@cpfConsultado", this.cpfConsultado);
                cmdModificarUsuario.Connection = dbConnection.getSqlConn();

                cmdModificarLogin.Parameters.AddWithValue("@username", this.username);
                cmdModificarLogin.Parameters.AddWithValue("@password", this.senha);
                cmdModificarLogin.Parameters.AddWithValue("@usernameConsultado", this.usernameConsultado);
                cmdModificarLogin.Connection = dbConnection.getSqlConn();

                cmdModificarUsuario.ExecuteNonQuery();
                cmdModificarLogin.ExecuteNonQuery();
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
        public void excluirUsuario() {
            try
            {
                dbConnection.open();
                SqlCommand cmdExcluir = new SqlCommand("DELETE FROM usuarios WHERE cpf = @cpfConsultado");
                cmdExcluir.Parameters.AddWithValue("@cpfConsultado", this.cpfConsultado);
                cmdExcluir.Connection = dbConnection.getSqlConn();

                SqlCommand cmdExcluirLogin = new SqlCommand("DELETE FROM login WHERE username = @usernameConsultado");
                cmdExcluirLogin.Parameters.AddWithValue("@usernameConsultado", this.usernameConsultado);
                cmdExcluirLogin.Connection = dbConnection.getSqlConn();

                cmdExcluir.ExecuteNonQuery();
                cmdExcluirLogin.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
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
