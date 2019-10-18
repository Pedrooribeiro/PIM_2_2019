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
    public partial class ModificarMotorista : Form
    {
        public void txtEnabled(Boolean boolean)
        {
            if (boolean == false)
            {
                txtNomeCompleto.Enabled = false;
                txtRg.Enabled = false;
                txtCpf.Enabled = false;
                txtCnh.Enabled = false;
                txtVencimentoCnh.Enabled = false;
                txtEmpresa.Enabled = false;
            }
            else
            {
                txtNomeCompleto.Enabled = true;
                txtRg.Enabled = true;
                txtCpf.Enabled = true;
                txtCnh.Enabled = true;
                txtVencimentoCnh.Enabled = true;
                txtEmpresa.Enabled = true;
            }
        }

        public ModificarMotorista()
        {
            InitializeComponent();
            txtEnabled(false);
            btnModificar.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja modificar o motorista?", "Confirmação Modificação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Motorista motoristaModificar = new Motorista();

                motoristaModificar.CpfConsultado = txtCpfConsultado.Text;
                motoristaModificar.NomeCompleto = txtNomeCompleto.Text;
                motoristaModificar.Rg = txtRg.Text;
                motoristaModificar.Cpf = txtCpf.Text;
                motoristaModificar.Cnh = txtCnh.Text;
                motoristaModificar.VencimentoCnh = txtVencimentoCnh.Text;
                motoristaModificar.Empresa = txtEmpresa.Text;

                motoristaModificar.modificarMotorista();
                if (motoristaModificar.Passou == true)
                {
                    MessageBox.Show("Motorista modificado com sucesso");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada");
                this.Close();
            }
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

            if (motoristaConsultar.Passou == true)
            {
                txtCpfConsultado.Enabled = false;
                txtEnabled(true);
                btnModificar.Enabled = true;
            }
        }

        private void ModificarMotorista_Load(object sender, EventArgs e)
        {

        }
    }
}
