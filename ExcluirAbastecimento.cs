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
    public partial class ExcluirAbastecimento : Form
    {
        public ExcluirAbastecimento()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir a abastecimento?", "Confirmação exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Abastecimento excluído com sucesso");
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
    }
}
