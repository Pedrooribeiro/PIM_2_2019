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
using System.Globalization;

namespace PrototipoTelas
{
    public partial class CadastrarSeguro : Form
    {
        public CadastrarSeguro()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Seguro seguro = new Seguro();

            seguro.NumeroApolice = txtNumApolice.Text;
            seguro.Seguradora = txtSeguradora.Text;
            seguro.Segurado = txtSegurado.Text;
            seguro.Corretor = txtCorretor.Text;
            seguro.DataInicio = txtDataInicio.Text;
            seguro.DataVencimento = txtDataVencimento.Text;
            seguro.ValorTotal = double.Parse(txtValorTotal.Text, CultureInfo.InvariantCulture);
            seguro.NumeroParcelas = txtNumParcela.Text;
            seguro.Situacao = txtSituacao.Text;
            seguro.PlacaSeguro = txtPlaca.Text;

            seguro.cadastrarSeguro();
            if(seguro.Passou == true)
            {
                if (MessageBox.Show("Tem certeza que deseja cadastrar um novo seguro?", "Confirmação Seguro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Seguro cadastrado com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cancelado com sucesso");
                    this.Close();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
