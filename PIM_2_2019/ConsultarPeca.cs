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
    public partial class ConsultarPeca : Form
    {
        public ConsultarPeca()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Peca peca = new Peca();
            peca.NomeConsultado = txtNome.Text;
            peca.consultarPeca();

            ResultadoConsultaPeca ResultadoConsultaPeca2 = new ResultadoConsultaPeca();

            ResultadoConsultaPeca2.dgvDados.DataSource = peca.DataTable;
            
            if(peca.Passou == true)
            {
                if (ResultadoConsultaPeca2.dgvDados.Rows.Count <= 0)
                {
                    MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
                } else
                {
                    ResultadoConsultaPeca2.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
