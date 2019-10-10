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
    public partial class CadastrarSinistro : Form
    {
        public CadastrarSinistro()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja cadastrar o sinistro?", "Confirmação cadastro de entrada", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Sinistro sinistro = new Sinistro();

                sinistro.Data = txtData.Text;
                sinistro.DescricaoOcorrido = txtDescricao.Text;
                sinistro.Local = txtLocal.Text;
                sinistro.Cpf = txtCpf.Text;
                sinistro.Placa = txtPlaca.Text;

                sinistro.cadastrarSinistro();
                if (sinistro.Passou == true)
                {
                    MessageBox.Show("Sinistro cadastrado com sucesso");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada");
                this.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
