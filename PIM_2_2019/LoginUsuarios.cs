using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace PrototipoTelas
{
    public partial class LoginUsuarios : Form
    {
        public LoginUsuarios()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            txtPassword.PasswordChar = '*';
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBConnection dbConnection = new DBConnection();

            string username = "";
            string password = "";

            try
            {
                dbConnection.open();
                SqlCommand cmdConsultar = new SqlCommand("SELECT * FROM login WHERE username = @txtUsername");
                cmdConsultar.Parameters.AddWithValue("@txtUsername", txtUsername.Text);
                cmdConsultar.Connection = dbConnection.getSqlConn();
                SqlDataReader dr = cmdConsultar.ExecuteReader();
                while (dr.Read())
                {
                    password = dr["password"].ToString();
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            if (txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Campos vazios, tente novamente.");
            }
            else if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals(password))
            {
                OperacoesUsuario frmOperacoes = new OperacoesUsuario();
                frmOperacoes.ShowDialog();
                txtPassword.Text = "";
            } else if(!txtUsername.Text.Equals("admin"))
            {
                MessageBox.Show("O seu usuário não possui permissões para realizar esta ação. Por favor utilize o usuário administrador.");
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos, tente novamente.");
            }
        }
    }
}
