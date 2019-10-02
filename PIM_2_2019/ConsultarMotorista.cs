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
    public partial class ConsultarMotorista : Form
    {
        public ConsultarMotorista()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Motorista motorista = new Motorista();
            motorista.CpfConsultado = txtCpfConsultado.Text;
            motorista.consultarMotorista();

            ResultadoConsultaMotorista ResultadoConsultaMotorista2 = new ResultadoConsultaMotorista();

            ResultadoConsultaMotorista2.txtNomeCompleto.Text = motorista.NomeCompleto;
            ResultadoConsultaMotorista2.txtRg.Text = motorista.Rg;
            ResultadoConsultaMotorista2.txtCpf.Text = motorista.Cpf;
            ResultadoConsultaMotorista2.txtCnh.Text = motorista.Cnh;
            ResultadoConsultaMotorista2.txtVencimentoCnh.Text = motorista.VencimentoCnh;
            ResultadoConsultaMotorista2.txtEmpresa.Text = motorista.Empresa;

            ResultadoConsultaMotorista2.ShowDialog();

            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
