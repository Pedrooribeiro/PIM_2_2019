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
    public partial class ModificarQuilometragem : Form
    {
        public void txtEnabled(Boolean boolean)
        {
            if (boolean == false)
            {
                txtDataInicio.Enabled = false;
                txtDataAtual.Enabled = false;
                txtPlaca.Enabled = false;
                txtQuilometrosRodados.Enabled = false;
            }
            else
            {
                txtDataInicio.Enabled = true;
                txtDataAtual.Enabled = true;
                txtPlaca.Enabled = true;
                txtQuilometrosRodados.Enabled = true;
            }
        }

        public ModificarQuilometragem()
        {
            InitializeComponent();
            txtEnabled(false);
            btnModificar.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja modificar a quilometragem?", "Confirmação Quilometragem", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Quilometragem quilometragemModificar = new Quilometragem();

                quilometragemModificar.PlacaConsultada = txtPlacaConsultada.Text;
                quilometragemModificar.DataInicio = txtDataInicio.Text;
                quilometragemModificar.DataAtual = txtDataAtual.Text;
                quilometragemModificar.Placa = txtPlaca.Text;
                quilometragemModificar.QuilometrosRodados = txtQuilometrosRodados.Text;

                quilometragemModificar.modificarQuilometragem();

                if (quilometragemModificar.Passou == true)
                {
                    MessageBox.Show("Quilometragem modificada com sucesso");
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
            Quilometragem quilometragemConsultar = new Quilometragem();
            quilometragemConsultar.PlacaConsultada = txtPlacaConsultada.Text;
            quilometragemConsultar.consultarQuilometragem();

            if (!String.IsNullOrEmpty(quilometragemConsultar.QuilometrosRodados))
            {
                ResultadoConsultaQuilometragem ResultadoConsultaQuilometragem2 = new ResultadoConsultaQuilometragem();

                ResultadoConsultaQuilometragem2.txtDataInicio.Text = quilometragemConsultar.DataInicio;
                ResultadoConsultaQuilometragem2.txtDataAtual.Text = quilometragemConsultar.DataAtual;
                ResultadoConsultaQuilometragem2.txtPlaca.Text = quilometragemConsultar.Placa;
                ResultadoConsultaQuilometragem2.txtQuilometrosRodados.Text = quilometragemConsultar.QuilometrosRodados;

                ResultadoConsultaQuilometragem2.ShowDialog();

                txtPlacaConsultada.Enabled = false;
                txtEnabled(true);
                btnModificar.Enabled = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente", "Erro");
            }
        }

        private void ModificarQuilometragem_Load(object sender, EventArgs e)
        {

        }
    }
}
