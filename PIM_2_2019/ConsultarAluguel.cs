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
    public partial class ConsultarAluguel : Form
    {
        public ConsultarAluguel()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AluguelVeiculos aluguel = new AluguelVeiculos();
            aluguel.CpfConsultado = txtCPF.Text;
            aluguel.consultarAluguel();

            ResultadoConsultaAluguel ResultadoConsultaAluguel2 = new ResultadoConsultaAluguel();

            ResultadoConsultaAluguel2.dgvDados.DataSource = aluguel.DataTable;

            if (aluguel.Passou == true)
            {
                if (ResultadoConsultaAluguel2.dgvDados.Rows.Count <= 0)
                {
                    MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
                }
                else
                {
                    ResultadoConsultaAluguel2.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
