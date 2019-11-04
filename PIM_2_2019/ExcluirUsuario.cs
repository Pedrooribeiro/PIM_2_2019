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
    public partial class ExcluirUsuario : Form
    {
        public ExcluirUsuario()
        {
            InitializeComponent();
            txtNomeCompleto.Enabled = false;
            txtRg.Enabled = false;
            txtCpf.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o usuário?", "Confirmação exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Usuario usuarioExcluir = new Usuario();
                usuarioExcluir.CpfConsultado = txtCpfConsultado.Text;
                usuarioExcluir.UsernameConsultado = txtCpfConsultado.Text.Replace(",", "").Replace("-", "");
                usuarioExcluir.excluirUsuario();

                if (usuarioExcluir.Passou == true)
                {
                    MessageBox.Show("Usuário excluído com sucesso");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso");
                this.Close();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Usuario usuarioConsultar = new Usuario();
            usuarioConsultar.CpfConsultado = txtCpfConsultado.Text;
            usuarioConsultar.UsernameConsultado = txtCpfConsultado.Text.Replace(",", "").Replace("-", ""); 
            usuarioConsultar.consultarUsuario();

            if (!String.IsNullOrEmpty(usuarioConsultar.NomeCompleto))
            {
                txtNomeCompleto.Text = usuarioConsultar.NomeCompleto;
                txtRg.Text = usuarioConsultar.Rg;
                txtCpf.Text = usuarioConsultar.Cpf;

                btnExcluir.Enabled = true;
            }
            else
            {
                MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente", "Erro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
