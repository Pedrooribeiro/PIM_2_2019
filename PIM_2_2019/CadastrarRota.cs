﻿using System;
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
    public partial class CadastrarRota : Form
    {
        public CadastrarRota()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja cadastrar uma nova rota?", "Confirmação Cadastro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Viagem viagem = new Viagem();

                viagem.Data = txtData.Text;
                viagem.Placa = txtPlaca.Text;
                viagem.Cpf = txtCpf.Text;
                viagem.DataEntregar = txtDataEntregar.Text;
                viagem.DataEntregue = txtDataEntregue.Text;
                viagem.Motivo = txtMotivo.Text;
                viagem.Situacao = txtSituacao.Text;
                viagem.KmFinal = double.Parse(txtKmInicial.Text);
                viagem.KmInicial = double.Parse(txtKmInicial.Text);

                viagem.cadastrarViagem();

                if (viagem.Passou == true)
                {
                    MessageBox.Show("Rota cadastrado com sucesso");
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

        private void txtKmInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtKmFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
