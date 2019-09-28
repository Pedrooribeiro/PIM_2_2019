using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoTelas
{
    public partial class ExcluirVeiculo : Form
    {
        public ExcluirVeiculo()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o veículo do sistema?","Confirmação Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                MessageBox.Show("Veículo excluído com sucesso");
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso");
            }
        }
    }
}
