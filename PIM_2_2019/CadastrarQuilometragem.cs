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
    public partial class CadastrarQuilometragem : Form
    {
        public CadastrarQuilometragem()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cadastrar quilometragem?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Quilometragem quilometragem = new Quilometragem();

                quilometragem.DataInicio = txtDataInicio.Text;
                quilometragem.DataAtual = txtDataAtual.Text;
                quilometragem.Placa = txtPlaca.Text;
                quilometragem.QuilometrosRodados = txtQuilometrosRodados.Text;

                quilometragem.cadastrarQuilometragem();

                if (quilometragem.Passou == true)
                {
                    MessageBox.Show("Quilometragem cadastrada com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cancelado com sucesso");
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

        private void txtQuilometrosRodados_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuilometrosRodados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
