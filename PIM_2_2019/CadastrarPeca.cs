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
    public partial class CadastrarPeca : Form
    {
        public CadastrarPeca()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cadastrar a peça?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Peca peca = new Peca();

                peca.Tipo = txtTipo.Text;
                peca.Nome = txtNome.Text;
                peca.Descricao = txtDescricao.Text;
                peca.Quantidade = txtQuantidade.Text;
                peca.ValorUnitario = txtValorUnitario.Text;
                peca.Veiculo = txtVeiculo.Text;

                peca.cadastrarPeca();
                MessageBox.Show("Peça cadastrada com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Operação cancelada");
                 this.Close();
            }
        }
    }
}
