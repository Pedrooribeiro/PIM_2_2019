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
    public partial class ModificarSinistro : Form
    {
        public ModificarSinistro()
        {
            InitializeComponent();
            btnModificar.Enabled = false;
        }

        private string placaConsultada;

        public string PlacaConsultada
        {
            get { return placaConsultada; }
            set { placaConsultada = value; }
        }


        private void ModificarSinistro_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja modificar o sinistro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int linhas = dgvDados.Rows.Count;
                Sinistro sinistroModificar = new Sinistro();
                sinistroModificar.PlacaConsultada = this.placaConsultada;

                for (int i = 0; i < linhas; i++)
                {
                    sinistroModificar.IdSinistro = Convert.ToInt32(dgvDados.Rows[i].Cells[0].Value.ToString());
                    sinistroModificar.Data = dgvDados.Rows[i].Cells[1].Value.ToString();
                    sinistroModificar.DescricaoOcorrido = dgvDados.Rows[i].Cells[2].Value.ToString();
                    sinistroModificar.Local = dgvDados.Rows[i].Cells[3].Value.ToString();
                    sinistroModificar.Placa = dgvDados.Rows[i].Cells[4].Value.ToString();
                    sinistroModificar.Cpf = dgvDados.Rows[i].Cells[5].Value.ToString();
                    sinistroModificar.modificarSinistro();
                }

                if (sinistroModificar.Passou == true)
                {
                    MessageBox.Show("Sinistro modificado com sucesso");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Sinistro sinistroConsultar = new Sinistro();
            sinistroConsultar.PlacaConsultada = txtPlacaConsultada.Text;
            this.placaConsultada = txtPlacaConsultada.Text;
            sinistroConsultar.consultarSinistro();

            dgvDados.DataSource = sinistroConsultar.DataTable;
            dgvDados.Columns["id_sinistro"].ReadOnly = true;
            if (dgvDados.Rows.Count <= 0)
            {
                MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
            }
            btnModificar.Enabled = true;
        }
    }
}
