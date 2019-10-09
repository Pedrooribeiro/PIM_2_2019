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
    public partial class ResultadoConsultaMulta : Form
    {
        public ResultadoConsultaMulta()
        {
            InitializeComponent();
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

        private void ResultadoConsultaMulta_Load(object sender, EventArgs e)
        {

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
