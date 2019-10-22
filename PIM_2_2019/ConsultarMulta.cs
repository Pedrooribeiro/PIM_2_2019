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
    public partial class ConsultarMulta : Form
    {
        public ConsultarMulta()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Multa multa = new Multa();
            multa.PlacaConsultada = txtPlacaConsultada.Text;
            multa.consultarMulta();

            ResultadoConsultaMulta ResultadoConsultaMulta2 = new ResultadoConsultaMulta();

            ResultadoConsultaMulta2.dgvDados.DataSource = multa.DataTable;

            if (multa.Passou == true)
            {
                if (ResultadoConsultaMulta2.dgvDados.Rows.Count <= 0)
                {
                    MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
                }
                else
                {
                    ResultadoConsultaMulta2.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
