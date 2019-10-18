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

namespace PrototipoTelas
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cadastrar o usuário?", "Confirmação Cadastro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Usuario usuario = new Usuario();

                usuario.NomeCompleto = txtNomeCompleto.Text;
                usuario.Rg = txtRg.Text;
                usuario.Cpf = txtCpf.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Username = txtCpf.Text.Replace(",","").Replace("-","");

                usuario.cadastrarUsuario();

                if (usuario.Passou == true)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
