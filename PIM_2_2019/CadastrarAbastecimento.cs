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
    public partial class CadastrarAbastecimento : Form
    {
        public CadastrarAbastecimento()
        {
            InitializeComponent();
        }

        private void CadastrarAbastecimento_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cadastrar abastecimento?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Abastecimento abastecimento = new Abastecimento();

                abastecimento.Data = txtData.Text;
                abastecimento.TipoCombustivel = txtTipoCombustivel.Text;
                abastecimento.Posto = txtPosto.Text;
                abastecimento.Placa = txtPlaca.Text;
                abastecimento.ValorLitro = txtValorLitro.Text;
                abastecimento.ValorTotal = txtValorTotal.Text;
                abastecimento.Litros = txtLitros.Text;

                abastecimento.cadastrarAbastecimento();

                if(abastecimento.Passou == true)
                {
                    MessageBox.Show("Abastecimento cadastrado com sucesso");
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
