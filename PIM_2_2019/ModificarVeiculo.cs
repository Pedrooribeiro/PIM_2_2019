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
    public partial class ModificarVeiculo : Form
    {
        public void txtEnabled(Boolean boolean)
        {
            if (boolean == false)
            {
                txtCor.Enabled = false;
                txtPlaca.Enabled = false;
                txtModelo.Enabled = false;
                txtMarca.Enabled = false;
                txtAno.Enabled = false;
                txtMotorizacao.Enabled = false;
                txtTipoCombustivel.Enabled = false;
            }
            else
            {
                txtCor.Enabled = true;
                txtPlaca.Enabled = true;
                txtModelo.Enabled = true;
                txtMarca.Enabled = true;
                txtAno.Enabled = true;
                txtMotorizacao.Enabled = true;
                txtTipoCombustivel.Enabled = true;
            }
        }

        public ModificarVeiculo()
        {
            InitializeComponent();
            txtEnabled(false);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja modificar o veículo?", "Confirmação Veiculo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Veiculo veiculoModificar = new Veiculo();

                veiculoModificar.PlacaConsultada = txtPlacaConsultar.Text;
                veiculoModificar.Cor = txtCor.Text;
                veiculoModificar.Placa = txtPlaca.Text;
                veiculoModificar.Modelo = txtModelo.Text;
                veiculoModificar.Marca = txtMarca.Text;
                veiculoModificar.AnoFabricacao = Convert.ToInt32(txtAno.Text);
                veiculoModificar.Motorizacao = txtMotorizacao.Text;
                veiculoModificar.TipoCombustivel = txtTipoCombustivel.Text;

                veiculoModificar.modificarVeiculo();

                if (veiculoModificar.Passou == true)
                {
                    MessageBox.Show("Veiculo modificado com sucesso");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Cancelado com sucesso");
                this.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Veiculo veiculoConsultar = new Veiculo();
            veiculoConsultar.PlacaConsultada = txtPlacaConsultar.Text;
            veiculoConsultar.consultarVeiculo();

            txtCor.Text = veiculoConsultar.Cor;
            txtPlaca.Text = veiculoConsultar.Placa;
            txtModelo.Text = veiculoConsultar.Modelo;
            txtMarca.Text = veiculoConsultar.Marca;
            txtAno.Text = veiculoConsultar.AnoFabricacao.ToString();
            txtMotorizacao.Text = veiculoConsultar.Motorizacao;
            txtTipoCombustivel.Text = veiculoConsultar.TipoCombustivel;

            if (veiculoConsultar.Passou == true)
            {
                txtPlacaConsultar.Enabled = false;
                txtEnabled(true);
            }
        }

        private void ModificarVeiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
