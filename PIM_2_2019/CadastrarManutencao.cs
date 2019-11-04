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
    public partial class CadastrarManutencao : Form
    {
        public CadastrarManutencao()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cadastrar a manutenção?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Manutencao manutencao = new Manutencao();

                manutencao.Data = txtData.Text;
                manutencao.Motivo = txtMotivo.Text;
                manutencao.Estabelecimento = txtEstabelecimento.Text;
                manutencao.Placa = txtPlaca.Text;
                manutencao.ValorTotal = txtValorTotal.Text;

                manutencao.cadastrarManutencao();

                if(manutencao.Passou == true)
                {
                    MessageBox.Show("Manutenção cadastrada com sucesso");
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

        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
