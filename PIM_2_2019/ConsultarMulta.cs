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

            ResultadoConsultaMulta2.ShowDialog();
        }
    }
}
