﻿using System;
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
    public partial class ResultadoConsultaEntrada : Form
    {
        public ResultadoConsultaEntrada()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar? ", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Consulta finalizada");
                this.Close();
            }
            else
            {
                MessageBox.Show("Consulta cancelada");
                this.Close();
            }
        }
    }
}
