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
    public partial class CadastrarEntrada : Form
    {
        public CadastrarEntrada()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EntradaSaida entradaSaida = new Model.EntradaSaida();

            entradaSaida.DataEntrada = txtData.Text;
            entradaSaida.HorarioEntrada = txtHorarioEntrada.Text;
            entradaSaida.Cpf = txtCPF.Text;
            entradaSaida.Placa = txtPlaca.Text;

            entradaSaida.cadastrarEntrada();

            if (entradaSaida.Passou == true)
            {
                if (MessageBox.Show("Tem certeza que deseja a cadastrar entrada do veículo?", "Confirmação cadastro de entrada", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Entrada cadastrada com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                    this.Close();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtHorarioEntrada_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
