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
    public partial class ExcluirMotorista : Form
    {
        public ExcluirMotorista()
        {
            InitializeComponent();
            txtNomeCompleto.Enabled = false;
            txtRg.Enabled = false;
            txtCpf.Enabled = false;
            txtCnh.Enabled = false;
            txtVencimentoCnh.Enabled = false;
            txtEmpresa.Enabled = false;
            btnExcluir.Enabled = false;
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Motorista motoristaConsultar = new Motorista();
            motoristaConsultar.CpfConsultado = txtCpfConsultado.Text;
            motoristaConsultar.consultarMotorista();

            txtNomeCompleto.Text = motoristaConsultar.NomeCompleto;
            txtRg.Text = motoristaConsultar.Rg;
            txtCpf.Text = motoristaConsultar.Cpf;
            txtCnh.Text = motoristaConsultar.Cnh;
            txtVencimentoCnh.Text = motoristaConsultar.VencimentoCnh;
            txtEmpresa.Text = motoristaConsultar.Empresa;

            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o motorista?", "Confirmação exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Motorista motoristaExcluir = new Motorista();
                motoristaExcluir.CpfConsultado = txtCpfConsultado.Text;
                motoristaExcluir.excluirMotorista();
                
                if(motoristaExcluir.Passou == true)
                {
                    MessageBox.Show("Motorista excluído com sucesso");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso");
                this.Close();
            }
        }
    }
}
