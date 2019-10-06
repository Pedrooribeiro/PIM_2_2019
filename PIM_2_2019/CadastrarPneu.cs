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
    public partial class CadastrarPneu : Form
    {
        public CadastrarPneu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cadastrar o pneu?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Pneu pneu = new Pneu();

                pneu.NumeroSerie = txtNumeroSerie.Text;
                pneu.Situacao = txtSituacao.Text;
                pneu.Marca = txtMarca.Text;
                pneu.Modelo = txtModelo.Text;
                pneu.Dimensao = txtDimensao.Text;
                pneu.Placa = txtPlaca.Text;

                pneu.cadastrarPneu();

                if(pneu.Passou == true)
                {
                    MessageBox.Show("Pneu cadastrado com sucesso");
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
    }
}
