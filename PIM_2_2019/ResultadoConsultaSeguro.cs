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
    public partial class ResultadoConsultaSeguro : Form
    {
        public ResultadoConsultaSeguro()
        {
            InitializeComponent();
            txtNumApolice.Enabled = false;
            txtSeguradora.Enabled = false;
            txtSegurado.Enabled = false;
            txtCorretor.Enabled = false;
            txtDataInicio.Enabled = false;
            txtDataVencimento.Enabled = false;
            txtValorTotal.Enabled = false;
            txtNumParcela.Enabled = false;
            txtSituacao.Enabled = false;
            txtPlaca.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar? ", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Consulta finalizada");
                this.Close();
            }
            else
            {
                MessageBox.Show("Consulta cancelada");
                this.Close();
            }
        }
    }
}
