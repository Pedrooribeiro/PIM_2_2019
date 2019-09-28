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
    public partial class CadastrarMotorista : Form
    {
        public CadastrarMotorista()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cadastrar o motorista ?","Confirmação Cadastro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Motorista cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Operação cancelada ");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
