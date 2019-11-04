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
    public partial class CadastrarAluguel : Form
    {
        public CadastrarAluguel()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cadastrar o aluguel?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AluguelVeiculos aluguel = new AluguelVeiculos();

                aluguel.Cpf = txtCPF.Text;
                aluguel.NumeroVeiculos = txtNumeroVeiculos.Text;
                aluguel.DataInicio = txtDataInicio.Text;
                aluguel.DataEntrega = txtDataEntrega.Text;

                aluguel.cadastrarAluguel();

                if (aluguel.Passou == true)
                {
                    MessageBox.Show("Aluguel cadastrado com sucesso");
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

        private void CadastrarAluguel_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroVeiculos_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNumeroVeiculos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

        }
    }
}
