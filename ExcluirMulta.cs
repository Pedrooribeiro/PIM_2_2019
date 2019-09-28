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
    public partial class ExcluirMulta : Form
    {
        public ExcluirMulta()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir a multa?", "Confirmação Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Multa excluída com sucesso");
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
