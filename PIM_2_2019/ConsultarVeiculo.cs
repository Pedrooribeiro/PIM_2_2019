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
    public partial class ConsultarVeiculo : Form
    {
        public ConsultarVeiculo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.PlacaConsultada = txtPlaca.Text;
            veiculo.consultarVeiculo();

            ResultadoConsultaVeiculo ResultadoConsultaVeiculo2 = new ResultadoConsultaVeiculo();

            ResultadoConsultaVeiculo2.txtCor.Text = veiculo.Cor;
            ResultadoConsultaVeiculo2.txtPlaca.Text = veiculo.Placa;
            ResultadoConsultaVeiculo2.txtModelo.Text = veiculo.Modelo;
            ResultadoConsultaVeiculo2.txtMarca.Text = veiculo.Marca;
            ResultadoConsultaVeiculo2.txtAno.Text = veiculo.AnoFabricacao.ToString();
            ResultadoConsultaVeiculo2.txtMotorizacao.Text = veiculo.Motorizacao;
            ResultadoConsultaVeiculo2.txtTipoCombustivel.Text = veiculo.TipoCombustivel;

            ResultadoConsultaVeiculo2.ShowDialog();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
