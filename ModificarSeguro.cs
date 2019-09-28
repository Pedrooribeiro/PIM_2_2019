using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoTelas
{
    public partial class ModificarSeguro : Form
    {
        public ModificarSeguro()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ModificarSeguro_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja modificar o seguro atual ?","Confirmação Modificação Seguro", MessageBoxButtons.YesNo) == DialogResult.Yes){
                MessageBox.Show("Modificação realizada com sucesso");
            }
            else
            {
                MessageBox.Show("Operação cancelada com sucesso");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
