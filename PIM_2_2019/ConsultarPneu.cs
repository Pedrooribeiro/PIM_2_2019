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
    public partial class ConsultarPneu : Form
    {
        public ConsultarPneu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pneu pneu = new Pneu();
            pneu.PlacaConsultada = txtPlacaConsultada.Text;
            pneu.consultarPneu();

            ResultadoConsultaPneu ResultadoConsultaPneu = new ResultadoConsultaPneu();

            ResultadoConsultaPneu.dgvDados.DataSource = pneu.DataTable;

            if (pneu.Passou == true)
            {
                if (ResultadoConsultaPneu.dgvDados.Rows.Count <= 0)
                {
                    MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
                }
                else
                {
                    ResultadoConsultaPneu.ShowDialog();
                    this.Close();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
