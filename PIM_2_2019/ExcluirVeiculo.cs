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
    public partial class ExcluirVeiculo : Form
    {
        public ExcluirVeiculo()
        {
            InitializeComponent();
            txtCor.Enabled = false;
            txtPlaca.Enabled = false;
            txtModelo.Enabled = false;
            txtMarca.Enabled = false;
            txtAno.Enabled = false;
            txtMotorizacao.Enabled = false;
            txtTipoCombustivel.Enabled = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Veiculo veiculoExcluir = new Veiculo();
            veiculoExcluir.PlacaConsultada = txtPlacaConsultada.Text;
            veiculoExcluir.excluirVeiculo();

            if (MessageBox.Show("Tem certeza que deseja excluir o veículo do sistema?","Confirmação Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                MessageBox.Show("Veículo excluído com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso");
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Veiculo veiculoConsultar = new Veiculo();

            veiculoConsultar.PlacaConsultada = txtPlacaConsultada.Text;
            veiculoConsultar.consultarVeiculo();

            txtCor.Text = veiculoConsultar.Cor;
            txtPlaca.Text = veiculoConsultar.Placa;
            txtModelo.Text = veiculoConsultar.Modelo;
            txtMarca.Text = veiculoConsultar.Marca;
            txtAno.Text = veiculoConsultar.AnoFabricacao.ToString();
            txtMotorizacao.Text = veiculoConsultar.Motorizacao;
            txtTipoCombustivel.Text = veiculoConsultar.TipoCombustivel;
        }

        private void ExcluirVeiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
