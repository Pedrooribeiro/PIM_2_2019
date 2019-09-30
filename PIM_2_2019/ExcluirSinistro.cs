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
    public partial class ExcluirSinistro : Form
    {
        public ExcluirSinistro()
        {
            InitializeComponent();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o sinistro ?", "Confirmação Exclusão de Seguro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Sinistro excluído com sucesso");
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
