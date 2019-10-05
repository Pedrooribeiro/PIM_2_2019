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
    public partial class ConsultarEntrada : Form
    {
        public ConsultarEntrada()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EntradaSaida entradaSaida = new EntradaSaida();
            entradaSaida.PlacaConsultada = txtPlacaConsultada.Text;
            entradaSaida.consultarDatas();

            ResultadoConsultaEntrada ResultadoConsultaEntrada2 = new ResultadoConsultaEntrada();

            ResultadoConsultaEntrada2.dgvEntrada.DataSource = entradaSaida.DataTableEntrada;
            ResultadoConsultaEntrada2.dgvSaida.DataSource = entradaSaida.DataTableSaida;
            
            if (entradaSaida.Passou == true)
            {
                if (ResultadoConsultaEntrada2.dgvEntrada.Rows.Count <= 0 && ResultadoConsultaEntrada2.dgvSaida.Rows.Count <= 0) {
                    MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente!", "Erro");
                } else
                {
                    ResultadoConsultaEntrada2.ShowDialog();
                    this.Close();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
