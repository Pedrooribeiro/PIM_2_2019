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
    public partial class ConsultarManutencao : Form
    {
        public ConsultarManutencao()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Manutencao manutencao = new Manutencao();
            manutencao.PlacaConsultada = txtPlacaConsultada.Text;
            manutencao.consultarManutencao();

            ResultadoConsultaManutencao ResultadoConsultaManutencao = new ResultadoConsultaManutencao();

            ResultadoConsultaManutencao.dgvDados.DataSource = manutencao.DataTable;

            if (manutencao.Passou == true)
            {
                if (ResultadoConsultaManutencao.dgvDados.Rows.Count <= 0)
                {
                    MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
                }
                else
                {
                    ResultadoConsultaManutencao.ShowDialog();
                    this.Close();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarManutencao_Load(object sender, EventArgs e)
        {

        }
    }
}
