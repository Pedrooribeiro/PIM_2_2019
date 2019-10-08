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
    public partial class ResultadoConsultaQuilometragem : Form
    {
        public ResultadoConsultaQuilometragem()
        {
            InitializeComponent();
            txtDataInicio.Enabled = false;
            txtDataAtual.Enabled = false;
            txtPlaca.Enabled = false;
            txtQuilometrosRodados.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar a consulta? ", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Consulta finalizada");
                this.Close();
            }
            else
            {
                MessageBox.Show("Operação cancelada");
                this.Close();
            }
        }
    }
}
