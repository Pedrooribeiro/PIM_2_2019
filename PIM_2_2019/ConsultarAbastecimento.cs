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
    public partial class ConsultarAbastecimento : Form
    {
        public ConsultarAbastecimento()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Abastecimento abastecimento = new Abastecimento();
            abastecimento.PlacaConsultada = txtPlacaConsultada.Text;
            abastecimento.consultarAbastecimento();

            ResultadoConsultaAbastecimento ResultadoConsultaAbastecimento = new ResultadoConsultaAbastecimento();

            ResultadoConsultaAbastecimento.dgvDados.DataSource = abastecimento.DataTable;

            if (abastecimento.Passou == true)
            {
                if (ResultadoConsultaAbastecimento.dgvDados.Rows.Count <= 0)
                {
                    MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
                }
                else
                {
                    ResultadoConsultaAbastecimento.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
