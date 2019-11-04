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
    public partial class ConsultarQuilometragem : Form
    {
        public ConsultarQuilometragem()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Quilometragem quilometragem = new Quilometragem();
            quilometragem.PlacaConsultada = txtPlacaConsultada.Text;
            quilometragem.consultarQuilometragem();

            if (!String.IsNullOrEmpty(quilometragem.QuilometrosRodados))
            {
                ResultadoConsultaQuilometragem ResultadoConsultaQuilometragem2 = new ResultadoConsultaQuilometragem();

                ResultadoConsultaQuilometragem2.txtDataInicio.Text = quilometragem.DataInicio;
                ResultadoConsultaQuilometragem2.txtDataAtual.Text = quilometragem.DataAtual;
                ResultadoConsultaQuilometragem2.txtPlaca.Text = quilometragem.Placa;
                ResultadoConsultaQuilometragem2.txtQuilometrosRodados.Text = quilometragem.QuilometrosRodados;

                ResultadoConsultaQuilometragem2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente", "Erro");
            }

            this.Close();
        }
    }
}
