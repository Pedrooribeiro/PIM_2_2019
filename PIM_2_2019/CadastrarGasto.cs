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
    public partial class CadastrarGasto : Form
    {
        public CadastrarGasto()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cadastrar gasto ?","Confirmação cadastro de gasto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Gasto cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Operação cancelada");
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
