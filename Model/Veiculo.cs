﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class Veiculo
    {
        DBConnection dbConnection = new DBConnection();

        private string cor;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        private string placa;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private int anoFabricacao;

        public int AnoFabricacao
        {
            get { return anoFabricacao; }
            set { anoFabricacao = value; }
        }

        private string motorizacao;

        public string Motorizacao
        {
            get { return motorizacao; }
            set { motorizacao = value; }
        }

        private string tipoCombustivel;

        public string TipoCombustivel
        {
            get { return tipoCombustivel; }
            set { tipoCombustivel = value; }
        }

        private String placaConsultada;

        public String PlacaConsultada
        {
            get { return placaConsultada; }
            set { placaConsultada = value; }
        }


        public Veiculo()
        {

        }

        public void cadastrarVeiculo() {
            try
            {
                dbConnection.open();
                SqlCommand cmd = new SqlCommand("INSERT INTO veiculos (cor,placa,modelo,marca,ano_fabricacao,motorizacao,tipo_combustivel) VALUES (@cor,@placa,@modelo,@marca,@anoFabricacao,@motorizacao,@tipoCombustivel)");
                cmd.Parameters.AddWithValue("@cor", this.cor);
                cmd.Parameters.AddWithValue("@placa", this.placa);
                cmd.Parameters.AddWithValue("@modelo", this.modelo);
                cmd.Parameters.AddWithValue("@marca", this.marca);
                cmd.Parameters.AddWithValue("@anoFabricacao", this.anoFabricacao);
                cmd.Parameters.AddWithValue("@motorizacao", this.motorizacao);
                cmd.Parameters.AddWithValue("@tipoCombustivel", this.tipoCombustivel);
                cmd.Connection = dbConnection.getSqlConn();
                cmd.ExecuteNonQuery();
             }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                MessageBox.Show("Erro ao cadastrar! Campos vazios ou preenchidos incorretamente, tente novamente.", "Erro");
            }
            finally
            {
                dbConnection.close();
            }
        }

        public void consultarVeiculo() {
            try
            {
                dbConnection.open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM veiculos WHERE placa = @placa");
                cmd.Parameters.AddWithValue("@placa", this.placa);
                cmd.Connection = dbConnection.getSqlConn();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read()) {
                    this.cor = dr["cor"].ToString();
                    this.placa = dr["placa"].ToString();
                    this.modelo = dr["modelo"].ToString();
                    this.marca = dr["marca"].ToString();
                    this.anoFabricacao = Convert.ToInt32(dr["ano_fabricacao"]);
                    this.motorizacao = dr["motorizacao"].ToString();
                    this.tipoCombustivel = dr["tipo_combustivel"].ToString();
                }
            } catch (System.Data.SqlClient.SqlException sqlException)
            {
               MessageBox.Show("Erro ao consultar! Item não localizado, tente novamente", "Erro");
            } finally
            {
                dbConnection.close();
            }
        }

        public void modificarVeiculo() {
            try
            {
                dbConnection.open();
                SqlCommand cmdModificar = new SqlCommand("UPDATE veiculos SET cor = @cor, placa = @placa, modelo = @modelo, marca = @marca, ano_fabricacao = @anoFabricacao, motorizacao = @motorizacao, tipo_combustivel = @tipoCombustivel WHERE placa = @placaConsultada");
                cmdModificar.Parameters.AddWithValue("@cor", this.cor);
                cmdModificar.Parameters.AddWithValue("@placa", this.placa);
                cmdModificar.Parameters.AddWithValue("@modelo", this.modelo);
                cmdModificar.Parameters.AddWithValue("@marca", this.marca);
                cmdModificar.Parameters.AddWithValue("@anoFabricacao", this.anoFabricacao);
                cmdModificar.Parameters.AddWithValue("@motorizacao", this.motorizacao);
                cmdModificar.Parameters.AddWithValue("@tipoCombustivel", this.tipoCombustivel);
                cmdModificar.Parameters.AddWithValue("@placaConsultada", this.placaConsultada);
                cmdModificar.Connection = dbConnection.getSqlConn();
                cmdModificar.ExecuteNonQuery();
            } catch (System.Data.SqlClient.SqlException sqlException)
            {
                MessageBox.Show("Erro ao modificar! Item não localizado, campos vazios ou preenchidos incorretamente, tente novamente.", "Erro");
            } finally
            {
                dbConnection.close();
            }
        }
        public Boolean excluirVeiculo() { return true; }
    }
}
