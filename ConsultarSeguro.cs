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
    public partial class ConsultarSeguro : Form
    {
        public ConsultarSeguro()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ResultadoConsultaSeguro ResultadoConsultaSeguro2 = new ResultadoConsultaSeguro();
            ResultadoConsultaSeguro2.ShowDialog();
        }
    }
}
