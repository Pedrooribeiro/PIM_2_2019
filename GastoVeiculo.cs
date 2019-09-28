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
    public partial class GastoVeiculo : Form
    {
        public GastoVeiculo()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RelatorioGastoVeiculo RelatorioGastoVeiculo2 = new RelatorioGastoVeiculo();
            RelatorioGastoVeiculo2.ShowDialog();
        }
    }
}
