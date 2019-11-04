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
    public partial class ModificarSeguro : Form
    {
        public void txtEnabled(Boolean boolean)
        {
            if (boolean == false)
            {
                txtNumApolice.Enabled = false;
                txtSeguradora.Enabled = false;
                txtSegurado.Enabled = false;
                txtCorretor.Enabled = false;
                txtDataInicio.Enabled = false;
                txtDataVencimento.Enabled = false;
                txtValorTotal.Enabled = false;
                txtNumeroParcela.Enabled = false;
                txtSituacao.Enabled = false;
                txtPlaca.Enabled = false;
            }
            else
            {
                txtNumApolice.Enabled = true;
                txtSeguradora.Enabled = true;
                txtSegurado.Enabled = true;
                txtCorretor.Enabled = true;
                txtDataInicio.Enabled = true;
                txtDataVencimento.Enabled = true;
                txtValorTotal.Enabled = true;
                txtNumeroParcela.Enabled = true;
                txtSituacao.Enabled = true;
                txtPlaca.Enabled = true;
            }
        }

        public ModificarSeguro()
        {
            InitializeComponent();
            txtEnabled(false);
            btnModificar.Enabled = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ModificarSeguro_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja modificar o seguro?", "Confirmação Modificação Seguro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Seguro seguroModificar = new Seguro();

                seguroModificar.NumeroApolice = txtNumApolice.Text;
                seguroModificar.Seguradora = txtSeguradora.Text;
                seguroModificar.Segurado = txtSegurado.Text;
                seguroModificar.Corretor = txtCorretor.Text;
                seguroModificar.DataInicio = txtDataInicio.Text;
                seguroModificar.DataVencimento = txtDataVencimento.Text;
                seguroModificar.ValorTotal = double.Parse(txtValorTotal.Text);
                seguroModificar.NumeroParcelas = txtNumeroParcela.Text;
                seguroModificar.Situacao = txtSituacao.Text;
                seguroModificar.PlacaSeguro = txtPlaca.Text;
                seguroModificar.PlacaConsultada = txtPlacaConsultada.Text;

                seguroModificar.modificarSeguro();

                if (seguroModificar.Passou == true)
                {
                    MessageBox.Show("Seguro modificado com sucesso");
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Seguro seguroConsultar = new Seguro();
            seguroConsultar.PlacaConsultada = txtPlacaConsultada.Text;
            seguroConsultar.consultarSeguro();

            if (seguroConsultar.ValorTotal != 0)
            {
                txtNumApolice.Text = seguroConsultar.NumeroApolice;
                txtSeguradora.Text = seguroConsultar.Seguradora;
                txtSegurado.Text = seguroConsultar.Seguradora;
                txtCorretor.Text = seguroConsultar.Corretor;
                txtDataInicio.Text = seguroConsultar.DataInicio;
                txtDataVencimento.Text = seguroConsultar.DataVencimento;
                txtValorTotal.Text = seguroConsultar.ValorTotal.ToString();
                txtNumeroParcela.Text = seguroConsultar.NumeroParcelas;
                txtSituacao.Text = seguroConsultar.Situacao;
                txtPlaca.Text = seguroConsultar.PlacaSeguro;

                txtPlacaConsultada.Enabled = false;
                txtEnabled(true);
                btnModificar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar! Campos vazios ou preenchidos incorretamente, tente novamente.", "Erro");
            }
        }
    }
}