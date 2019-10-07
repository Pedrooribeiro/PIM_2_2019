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
    public partial class ModificarAbastecimento : Form
    {
        private string placaConsultada;

        public ModificarAbastecimento()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja modificar o abastecimento?", "Confirmação exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int linhas = dgvDados.Rows.Count;
                Abastecimento abastecimentoModificar = new Abastecimento();
                abastecimentoModificar.PlacaConsultada = this.placaConsultada;

                for (int i = 0; i < linhas; i++)
                {
                    abastecimentoModificar.IdAbastecimento = Convert.ToInt32(dgvDados.Rows[i].Cells[0].Value.ToString());
                    abastecimentoModificar.Data = dgvDados.Rows[i].Cells[1].Value.ToString();
                    abastecimentoModificar.TipoCombustivel = dgvDados.Rows[i].Cells[2].Value.ToString();
                    abastecimentoModificar.Posto = dgvDados.Rows[i].Cells[3].Value.ToString();
                    abastecimentoModificar.Placa = dgvDados.Rows[i].Cells[4].Value.ToString();
                    abastecimentoModificar.ValorLitro = dgvDados.Rows[i].Cells[5].Value.ToString();
                    abastecimentoModificar.ValorTotal = dgvDados.Rows[i].Cells[6].Value.ToString();
                    abastecimentoModificar.Litros = dgvDados.Rows[i].Cells[7].Value.ToString();
                    abastecimentoModificar.modificarAbastecimento();
                }

                if (abastecimentoModificar.Passou == true)
                {
                    MessageBox.Show("Abastecimento modificada com sucesso");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Abastecimento abastecimento = new Abastecimento();
            abastecimento.PlacaConsultada = txtPlacaConsultada.Text;
            this.placaConsultada = txtPlacaConsultada.Text;
            abastecimento.consultarAbastecimento();

            dgvDados.DataSource = abastecimento.DataTable;
            dgvDados.Columns["id_abastecimento"].ReadOnly = true;

            if (dgvDados.Rows.Count <= 0)
            {
                MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
            }
        }
    }
}
