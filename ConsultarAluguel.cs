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
            ResultadoConsultaAluguel ResultadoConsultaAluguel2 = new ResultadoConsultaAluguel();
            ResultadoConsultaAluguel2.ShowDialog();
        }
    }
}
