using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using Model;

namespace PrototipoTelas
{
    public partial class ConsultarRota : Form
    {
        public ConsultarRota()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Viagem viagem = new Viagem();
            viagem.PlacaConsultada = txtPlacaConsultada.Text;
            viagem.consultarViagem();
            
            ResultadoConsultaRota ResultadoConsultaRota2 = new ResultadoConsultaRota();

            ResultadoConsultaRota2.dgvDados.DataSource = viagem.DataTable;
          
            ResultadoConsultaRota2.ShowDialog();

            this.Close();
        }
    }
}
