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
    public partial class ExcluirMulta : Form
    {
        public ExcluirMulta()
        {
            InitializeComponent();
            btnExcluir.Enabled = false;
        }

        private string placaConsultada;

        public string PlacaConsultada
        {
            get { return placaConsultada; }
            set { placaConsultada = value; }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir todas as multas deste veículo?", "Confirmação Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Multa multaExcluir = new Multa();
                multaExcluir.PlacaConsultada = txtPlacaConsultada.Text;
                multaExcluir.excluirMulta();

                if (multaExcluir.Passou == true)
                {
                    MessageBox.Show("Multas excluídas com sucesso");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            Multa multaConsultar = new Multa();
                       
            multaConsultar.PlacaConsultada = txtPlacaConsultada.Text;
            multaConsultar.consultarMulta();

            dgvDados.DataSource = multaConsultar.DataTable;
            dgvDados.Columns["id_multa"].ReadOnly = true;
            if (dgvDados.Rows.Count <= 0)
            {
                MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
            }

            btnExcluir.Enabled = true;
        }
    }
}
