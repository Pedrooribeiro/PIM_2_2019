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
    public partial class ConsultarSinistro : Form
    {
        public ConsultarSinistro()
        {
            InitializeComponent();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar a consulta?", "Confirmação Exclusão de Seguro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Finalizado com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso");
                this.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sinistro sinistro = new Sinistro();
            sinistro.PlacaConsultada = txtPlacaConsultada.Text;
            sinistro.consultarSinistro();
            

            dgvDados.DataSource = sinistro.DataTable;

            if (sinistro.Passou == true)
            {
                if (dgvDados.Rows.Count <= 0)
                {
                    MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
                    this.Close();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
