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
    public partial class ModificarManutencao : Form
    {
        private string placaConsultada;

        public ModificarManutencao()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Manutencao manutencao = new Manutencao();
            manutencao.PlacaConsultada = txtPlacaConsultada.Text;
            this.placaConsultada = txtPlacaConsultada.Text;
            manutencao.consultarManutencao();

            dgvDados.DataSource = manutencao.DataTable;
            dgvDados.Columns["id_manutencao"].ReadOnly = true;

            if (dgvDados.Rows.Count <= 0)
            {
                MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja modificar a manutenção?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int linhas = dgvDados.Rows.Count;
                Manutencao manutencaoModificar = new Manutencao();
                manutencaoModificar.PlacaConsultada = this.placaConsultada;

                for (int i = 0; i < linhas; i++)
                {
                    manutencaoModificar.IdManutencao = Convert.ToInt32(dgvDados.Rows[i].Cells[0].Value.ToString());
                    manutencaoModificar.Data = dgvDados.Rows[i].Cells[1].Value.ToString();
                    manutencaoModificar.Motivo = dgvDados.Rows[i].Cells[2].Value.ToString();
                    manutencaoModificar.Estabelecimento = dgvDados.Rows[i].Cells[3].Value.ToString();
                    manutencaoModificar.Placa = dgvDados.Rows[i].Cells[4].Value.ToString();
                    manutencaoModificar.ValorTotal = dgvDados.Rows[i].Cells[5].Value.ToString();
                    manutencaoModificar.modificarManutencao();
                }

                if (manutencaoModificar.Passou == true)
                {
                    MessageBox.Show("Manutenção modificada com sucesso");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
