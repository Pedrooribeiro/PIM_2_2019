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
    public partial class ModificarMulta : Form
    {
        public ModificarMulta()
        {
            InitializeComponent();
            btnModificar.Enabled = false;
        }

        private string placaConsultada;

        public string PlacaConsultada
        {
            get { return placaConsultada; }
            set { placaConsultada = value; }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja modificar a multa?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int linhas = dgvDados.Rows.Count;
                Multa multaModificar = new Multa();
                multaModificar.PlacaConsultada = this.placaConsultada;

                for (int i = 0; i < linhas; i++)
                {
                    multaModificar.IdMulta = Convert.ToInt32(dgvDados.Rows[i].Cells[0].Value.ToString());
                    multaModificar.Data = dgvDados.Rows[i].Cells[1].Value.ToString();
                    multaModificar.AutoInfracao = dgvDados.Rows[i].Cells[2].Value.ToString();
                    multaModificar.DescricaoInfracao = dgvDados.Rows[i].Cells[3].Value.ToString();
                    multaModificar.Local = dgvDados.Rows[i].Cells[4].Value.ToString();
                    multaModificar.Gravidade = dgvDados.Rows[i].Cells[5].Value.ToString();
                    multaModificar.DataVencimento = dgvDados.Rows[i].Cells[6].Value.ToString();
                    multaModificar.DataPagamento = dgvDados.Rows[i].Cells[7].Value.ToString();
                    multaModificar.Situacao = dgvDados.Rows[i].Cells[8].Value.ToString();
                    multaModificar.Placa = dgvDados.Rows[i].Cells[9].Value.ToString();
                    multaModificar.Cpf = dgvDados.Rows[i].Cells[10].Value.ToString();
                    multaModificar.Valor = dgvDados.Rows[i].Cells[11].Value.ToString();
                    multaModificar.modificarMulta();
                }

                if (multaModificar.Passou == true)
                {
                    MessageBox.Show("Multa modificada com sucesso");
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
            this.Close();        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Multa multaConsultar = new Multa();
            multaConsultar.PlacaConsultada = txtPlacaConsultada.Text;
            this.placaConsultada = txtPlacaConsultada.Text;
            multaConsultar.consultarMulta();

            dgvDados.DataSource = multaConsultar.DataTable;
            dgvDados.Columns["id_multa"].ReadOnly = true;
            if (dgvDados.Rows.Count <= 0)
            {
                MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
            }
            btnModificar.Enabled = true;
        }
    }
}
