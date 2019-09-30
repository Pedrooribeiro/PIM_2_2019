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
    public partial class CadastrarSeguro : Form
    {
        public CadastrarSeguro()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cadastrar um novo seguro ?", "Confirmação Seguro", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                MessageBox.Show("Seguro cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Cancelado com sucesso");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
