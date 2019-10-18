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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            txtPassword.PasswordChar = '*';
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
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
                    username = dr["username"].ToString();
                    password = dr["password"].ToString();
                }
            } catch(SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
            if(txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Campos vazios, tente novamente.");
            } else if(txtUsername.Text.Equals(username) && txtPassword.Text.Equals(password)) {
                MessageBox.Show("Login efetuado com sucesso!");
                Crud Crud2 = new Crud();
                Crud2.ShowDialog();
                txtPassword.Text = "";
            } else
            {
                MessageBox.Show("Usuário ou senha incorretos, tente novamente.");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            LoginUsuarios loginUsuarios = new LoginUsuarios();
            loginUsuarios.ShowDialog();
        }
    }
}
