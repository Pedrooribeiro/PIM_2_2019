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
    public partial class ConsultarUsuario : Form
    {
        public ConsultarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.CpfConsultado = txtCpfConsultado.Text;
            usuario.UsernameConsultado = txtCpfConsultado.Text.Replace(",", "").Replace("-", "");
            usuario.consultarUsuario();
            
            if (!String.IsNullOrEmpty(usuario.NomeCompleto))
            {
                ResultadoConsultaUsuario ResultadoConsultaUsuario2 = new ResultadoConsultaUsuario();

                ResultadoConsultaUsuario2.txtNomeCompleto.Text = usuario.NomeCompleto;
                ResultadoConsultaUsuario2.txtRg.Text = usuario.Rg;
                ResultadoConsultaUsuario2.txtCpf.Text = usuario.Cpf;

                ResultadoConsultaUsuario2.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente.", "Erro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
