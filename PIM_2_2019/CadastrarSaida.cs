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
    public partial class CadastrarSaida : Form
    {
        public CadastrarSaida()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            EntradaSaida entradaSaida = new EntradaSaida();

            entradaSaida.DataSaida = txtData.Text;
            entradaSaida.HorarioSaida = txtHorarioSaida.Text;
            entradaSaida.Cpf = txtCPF.Text;
            entradaSaida.Placa = txtPlaca.Text;

            entradaSaida.cadastrarSaida();

            if (entradaSaida.Passou == true)
            {
                if (MessageBox.Show("Tem certeza que deseja cadastrar a saída do veículo?", "Confirmação cadastro de entrada", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Saída cadastrada com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
