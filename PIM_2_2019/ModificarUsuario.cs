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
    public partial class ModificarUsuario : Form
    {
        public void txtEnabled(Boolean boolean)
        {
            if (boolean == false)
            {
                txtNomeCompleto.Enabled = false;
                txtRg.Enabled = false;
                txtCpf.Enabled = false;
                txtSenha.Enabled = false;
            }
            else
            {
                txtNomeCompleto.Enabled = true;
                txtRg.Enabled = true;
                txtCpf.Enabled = true;
                txtSenha.Enabled = true;
            }
        }

        public ModificarUsuario()
        {
            InitializeComponent();
            txtEnabled(false);
            txtSenha.PasswordChar = '*';
            btnModificar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja modificar o usuário?", "Confirmação Modificação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Usuario usuarioModificar = new Usuario();

                usuarioModificar.CpfConsultado = txtCpfConsultado.Text;
                usuarioModificar.NomeCompleto = txtNomeCompleto.Text;
                usuarioModificar.Rg = txtRg.Text;
                usuarioModificar.Cpf = txtCpf.Text;
                usuarioModificar.Senha = txtSenha.Text;
                usuarioModificar.Username = txtCpf.Text.Replace(",","").Replace("-","");
                usuarioModificar.UsernameConsultado = txtCpfConsultado.Text.Replace(",", "").Replace("-", "");

                usuarioModificar.modificarUsuario();

                if (usuarioModificar.Passou == true)
                {
                    MessageBox.Show("Usuário modificado com sucesso");
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Usuario usuarioConsultar = new Usuario();
            usuarioConsultar.CpfConsultado = txtCpfConsultado.Text;
            usuarioConsultar.UsernameConsultado = txtCpfConsultado.Text.Replace(",", "").Replace("-", "");
            usuarioConsultar.consultarUsuario();

            txtNomeCompleto.Text = usuarioConsultar.NomeCompleto;
            txtRg.Text = usuarioConsultar.Rg;
            txtCpf.Text = usuarioConsultar.Cpf;
            txtSenha.Text = usuarioConsultar.Senha;


            if (usuarioConsultar.Passou == true)
            {
                txtCpfConsultado.Enabled = false;
                txtEnabled(true);
                btnModificar.Enabled = true;
            }
        }
    }
}
