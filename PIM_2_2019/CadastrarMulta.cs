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
    public partial class CadastrarMulta : Form
    {
        public CadastrarMulta()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cadastrar multa?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Multa multa = new Multa();

                multa.Data = txtData.Text;
                multa.AutoInfracao = txtAutoInfracao.Text;
                multa.DescricaoInfracao = txtDescricaoInfracao.Text;
                multa.Local = txtLocal.Text;
                multa.Gravidade = txtGravidade.Text;
                multa.DataVencimento = txtDataVencimento.Text;
                multa.DataPagamento = txtDataPagamento.Text;
                multa.Situacao = txtSituacao.Text;
                multa.Placa = txtPlaca.Text;
                multa.Cpf = txtCPF.Text;
                multa.Valor = txtValor.Text;

                multa.cadastrarMulta();

                if (multa.Passou == true)
                {
                    MessageBox.Show("Multa cadastrada com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cancelado com sucesso");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
