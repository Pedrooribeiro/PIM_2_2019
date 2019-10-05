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
    public partial class ModificarPeca : Form
    {
        private string nomeConsultado;

        public ModificarPeca()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja modificar a peça?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int linhas = dgvDados.Rows.Count;
                Peca pecaModificar = new Peca();
                pecaModificar.NomeConsultado = this.nomeConsultado;

                for (int i = 0; i < linhas; i++) {
                    pecaModificar.IdPeca = Convert.ToInt32(dgvDados.Rows[i].Cells[0].Value.ToString());
                    pecaModificar.Tipo = dgvDados.Rows[i].Cells[1].Value.ToString();
                    pecaModificar.Nome = dgvDados.Rows[i].Cells[2].Value.ToString();
                    pecaModificar.Descricao = dgvDados.Rows[i].Cells[3].Value.ToString();
                    pecaModificar.Quantidade = dgvDados.Rows[i].Cells[4].Value.ToString();
                    pecaModificar.ValorUnitario = dgvDados.Rows[i].Cells[5].Value.ToString();
                    pecaModificar.Veiculo = dgvDados.Rows[i].Cells[6].Value.ToString();
                    pecaModificar.modificarPeca();
                }
                MessageBox.Show("Peça modificada com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Operação cancelada");
                this.Close();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Peca peca = new Peca();
            peca.NomeConsultado = txtNomeConsultado.Text;
            this.nomeConsultado = txtNomeConsultado.Text;
            peca.consultarPeca();

            dgvDados.DataSource = peca.DataTable;
            dgvDados.Columns["id_peca"].ReadOnly = true;
            if (dgvDados.Rows.Count <= 0)
            {
                MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
                this.Close();
            }
        }
    }
}
