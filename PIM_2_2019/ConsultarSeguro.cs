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
            Seguro seguro = new Seguro();
            seguro.PlacaConsultada = txtPlaca.Text;
            seguro.consultarSeguro();

            ResultadoConsultaSeguro ResultadoConsultaSeguro = new ResultadoConsultaSeguro();

            ResultadoConsultaSeguro.txtNumApolice.Text = seguro.NumeroApolice;
            ResultadoConsultaSeguro.txtSeguradora.Text = seguro.Seguradora;
            ResultadoConsultaSeguro.txtSegurado.Text = seguro.Seguradora;
            ResultadoConsultaSeguro.txtCorretor.Text = seguro.Corretor;
            ResultadoConsultaSeguro.txtDataInicio.Text = seguro.DataInicio;
            ResultadoConsultaSeguro.txtDataVencimento.Text = seguro.DataVencimento;
            ResultadoConsultaSeguro.txtValorTotal.Text = seguro.ValorTotal.ToString();
            ResultadoConsultaSeguro.txtNumParcela.Text = seguro.NumeroParcelas;
            ResultadoConsultaSeguro.txtSituacao.Text = seguro.Situacao;
            ResultadoConsultaSeguro.txtPlaca.Text = seguro.PlacaSeguro;

            ResultadoConsultaSeguro.ShowDialog();

            this.Close();
        }

        private void ConsultarSeguro_Load(object sender, EventArgs e)
        {

        }
    }
}
