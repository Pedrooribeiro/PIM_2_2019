using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ResultadoConsultaAbastecimento ResultadoConsultaAbastecimento2 = new ResultadoConsultaAbastecimento();
            ResultadoConsultaAbastecimento2.ShowDialog();
        }
    }
}
