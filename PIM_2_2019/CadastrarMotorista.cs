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
    public partial class CadastrarMotorista : Form
    {
        public CadastrarMotorista()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Motorista motorista = new Motorista();

            motorista.NomeCompleto = txtNomeCompleto.Text;
            motorista.Rg = txtRg.Text;
            motorista.Cpf = txtCpf.Text;
            motorista.Cnh = txtCnh.Text;
            motorista.VencimentoCnh = txtVencimentoCnh.Text;
            motorista.Empresa = txtEmpresa.Text;

            motorista.cadastrarMotorista();


            if (motorista.Passou == true)
            {
                if (MessageBox.Show("Tem certeza que deseja cadastrar o motorista?", "Confirmação Cadastro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Motorista cadastrado com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                    this.Close();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
