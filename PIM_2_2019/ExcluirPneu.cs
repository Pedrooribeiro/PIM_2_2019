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
    public partial class ExcluirPneu : Form
    {
        public ExcluirPneu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja excluir o pneu?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Pneu pneu = new Pneu();
                pneu.PlacaConsultada = txtPlacaConsultada.Text;
                pneu.excluirPneu();
                if(pneu.Passou == true)
                {
                    MessageBox.Show("Pneu excluído com sucesso");
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
    }
}
