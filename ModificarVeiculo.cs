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
    public partial class ModificarVeiculo : Form
    {
        public ModificarVeiculo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja modificar o veículo?","Confirmação Modificação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Veículo modificado com sucesso");
            }
            else
            {
                MessageBox.Show("Modificação cancelada com sucesso");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
