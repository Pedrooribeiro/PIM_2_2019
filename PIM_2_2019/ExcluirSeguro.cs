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
    public partial class ExcluirSeguro : Form
    {
        public ExcluirSeguro()
        {
            InitializeComponent();
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Seguro seguroExcluir = new Seguro();
            seguroExcluir.PlacaConsultada = txtPlacaConsultada.Text;
            seguroExcluir.excluirSeguro();
            if(seguroExcluir.Passou == true){
                if(MessageBox.Show("Tem certeza que deseja excluir o seguro do sistema?", "Confirmação Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Seguro excluído com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operação cancelada com sucesso");
                    this.Close();
                }
            }
            this.Close();
        }
     

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Seguro seguroConsultar = new Seguro();

            seguroConsultar.PlacaConsultada = txtPlacaConsultada.Text;
            seguroConsultar.consultarSeguro();

            txtNumApolice.Text = seguroConsultar.NumeroApolice;
            txtSeguradora.Text = seguroConsultar.Seguradora;
            txtSegurado.Text = seguroConsultar.Segurado;
            txtCorretor.Text = seguroConsultar.Corretor;
            txtDataInicio.Text = seguroConsultar.DataInicio;
            txtDataVencimento.Text = seguroConsultar.DataVencimento;
            txtValorTotal.Text = seguroConsultar.ValorTotal.ToString();
            txtNumeroParcela.Text = seguroConsultar.NumeroParcelas;
            txtSituacao.Text = seguroConsultar.Situacao;
            txtPlaca.Text = seguroConsultar.PlacaSeguro;
        }
    }
}
