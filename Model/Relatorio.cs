using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Model
{
    public class Relatorio
    {
        DBConnection dbConnection = new DBConnection();

        string userRoot = System.Environment.GetEnvironmentVariable("USERPROFILE");

        private string caminho;

        public string Caminho
        {
            get { return caminho; }
            set { caminho = value; }
        }


        public void gerarRelatorio()
        {
            caminho = userRoot + "\\Desktop\\relatorio.xls";

            using (StreamWriter sw = File.CreateText(caminho))
            {
                try
                {
                    dbConnection.open();
                    SqlDataReader dr;

                    // VEÍCULOS
                    SqlCommand cmdVeiculos = new SqlCommand("SELECT * FROM veiculos");
                    cmdVeiculos.Connection = dbConnection.getSqlConn();

                    dr = cmdVeiculos.ExecuteReader();

                    sw.WriteLine("VEICULOS");
                    sw.WriteLine("ID VEICULO" + "\t" + "COR" + "\t" + "PLACA" + "\t" + "MODELO" + "\t" + "MARCA" + "\t" + "ANO FABRICACAO" + "\t" + "MOTORIZACAO" + "\t" + "TIPO COMBUSTIVEL" + "\t");
                    while (dr.Read())
                    {
                        sw.WriteLine(dr["id_veiculo"].ToString() + "\t" + dr["cor"].ToString() + "\t" + dr["placa"].ToString() + "\t" + dr["modelo"].ToString() + "\t" + dr["marca"].ToString() + "\t" + dr["ano_fabricacao"].ToString() + "\t" + dr["motorizacao"].ToString() + "\t" + dr["tipo_combustivel"].ToString() + "\t");
                    }
                    dr.Close();

                    // ABASTECIMENTOS
                    SqlCommand cmdAbastecimentos = new SqlCommand("SELECT * FROM abastecimentos");
                    cmdAbastecimentos.Connection = dbConnection.getSqlConn();

                    dr = cmdAbastecimentos.ExecuteReader();

                    sw.WriteLine("\n" + "ABASTECIMENTOS");
                    sw.WriteLine("ID ABASTECIMENTO" + "\t" + "DATA ABASTECIMENTO" + "\t" + "TIPO COMBUSTIVEL" + "\t" + "POSTO" + "\t" + "PLACA" + "\t" + "VALOR LITRO" + "\t" + "VALOR TOTAL" + "\t" + "LITROS" + "\t");
                    while (dr.Read())
                    {
                        sw.WriteLine(dr["id_abastecimento"].ToString() + "\t" + dr["data_abastecimento"].ToString() + "\t" + dr["tipo_combustivel"].ToString() + "\t" + dr["posto"].ToString() + "\t" + dr["placa"].ToString() + "\t" + dr["valor_litro"].ToString() + "\t" + dr["valor_total"].ToString() + "\t" + dr["litros"].ToString() + "\t");
                    }
                    dr.Close();

                    // ALUGUEL VEÍCULOS
                    SqlCommand cmdAluguel = new SqlCommand("SELECT * FROM aluguel_veiculos");
                    cmdAluguel.Connection = dbConnection.getSqlConn();

                    dr = cmdAluguel.ExecuteReader();

                    sw.WriteLine("\n" + "ALUGUEL VEICULOS");
                    sw.WriteLine("ID ALUGUEL" + "\t" + "CPF" + "\t" + "NUMERO VEICULOS" + "\t" + "DATA INICIO" + "\t" + "DATA ENTREGA" + "\t");
                    while (dr.Read())
                    {
                        sw.WriteLine(dr["id_aluguel"].ToString() + "\t" + dr["cpf"].ToString() + "\t" + dr["numero_veiculos"].ToString() + "\t" + dr["data_inicio"].ToString() + "\t" + dr["data_entrega"].ToString() + "\t");
                    }
                    dr.Close();

                    // ENTRADAS
                    SqlCommand cmdEntradas = new SqlCommand("SELECT * FROM entradas");
                    cmdEntradas.Connection = dbConnection.getSqlConn();

                    dr = cmdEntradas.ExecuteReader();

                    sw.WriteLine("\n" + "ENTRADAS");
                    sw.WriteLine("ID ENTRADAS" + "\t" + "DATA ENTRADA" + "\t" + "PLACA" + "\t" + "CPF" + "\t" + "HORARIO ENTRADA" + "\t");
                    while (dr.Read())
                    {
                        sw.WriteLine(dr["id_entrada"].ToString() + "\t" + dr["data_entrada"].ToString() + "\t" + dr["placa"].ToString() + "\t" + dr["cpf"].ToString() + "\t" + dr["horario_entrada"].ToString() + "\t");
                    }
                    dr.Close();

                    // ESTOQUE PEÇAS
                    SqlCommand cmdEstoque = new SqlCommand("SELECT * FROM estoque_peca");
                    cmdEstoque.Connection = dbConnection.getSqlConn();

                    dr = cmdEstoque.ExecuteReader();

                    sw.WriteLine("\n" + "ESTOQUE PECAS");
                    sw.WriteLine("ID PECA" + "\t" + "TIPO" + "\t" + "NOME" + "\t" + "DESCRICAO" + "\t" + "QUANTIDADE" + "\t" + "VALOR UNITARIO" + "\t" + "NOME VEICULO" + "\t");
                    while (dr.Read())
                    {
                        sw.WriteLine(dr["id_peca"].ToString() + "\t" + dr["tipo"].ToString() + "\t" + dr["nome"].ToString() + "\t" + dr["descricao"].ToString() + "\t" + dr["quantidade"].ToString() + "\t" + dr["valor_unitario"].ToString() + "\t" + dr["nome_veiculo"].ToString() + "\t");
                    }
                    dr.Close();

                    // MANUTENÇÕES
                    SqlCommand cmdManutencao = new SqlCommand("SELECT * FROM manutencoes");
                    cmdManutencao.Connection = dbConnection.getSqlConn();

                    dr = cmdManutencao.ExecuteReader();

                    sw.WriteLine("\n" + "MANUTENCOES");
                    sw.WriteLine("ID MANUTENCAO" + "\t" + "DATA MANUTENCAO" + "\t" + "MOTIVO" + "\t" + "ESTABELECIMENTO" + "\t" + "PLACA" + "\t" + "VALOR TOTAL" + "\t");
                    while (dr.Read())
                    {
                        sw.WriteLine(dr["id_manutencao"].ToString() + "\t" + dr["data_manutencao"].ToString() + "\t" + dr["motivo"].ToString() + "\t" + dr["estabelecimento"].ToString() + "\t" + dr["placa"].ToString() + "\t" + dr["valor_total"].ToString() + "\t");
                    }
                    dr.Close();

                    // MOTORISTAS
                    SqlCommand cmdMotorista = new SqlCommand("SELECT * FROM motoristas");
                    cmdMotorista.Connection = dbConnection.getSqlConn();

                    dr = cmdMotorista.ExecuteReader();

                    sw.WriteLine("\n" + "MOTORISTAS");
                    sw.WriteLine("ID MOTORISTA" + "\t" + "NOME COMPLETO" + "\t" + "RG" + "\t" + "CPF" + "\t" + "CNH" + "\t" + "VENCIMENTO CNH" + "\t" + "EMPRESA" + "\t");
                    while (dr.Read())
                    {
                        sw.WriteLine(dr["id_motorista"].ToString() + "\t" + dr["nome_completo"].ToString() + "\t" + dr["rg"].ToString() + "\t" + dr["cpf"].ToString() + "\t" + dr["cnh"].ToString() + "\t" + dr["vencimento_cnh"].ToString() + "\t" + dr["empresa"].ToString() + "\t");
                    }
                    dr.Close();

                    // MULTAS
                    SqlCommand cmdMultas = new SqlCommand("SELECT * FROM multas");
                    cmdMultas.Connection = dbConnection.getSqlConn();

                    dr = cmdMultas.ExecuteReader();

                    sw.WriteLine("\n" + "MULTAS");
                    sw.WriteLine("ID MULTA" + "\t" + "DATA MULTA" + "\t" + "AUTO INFRACAO" + "\t" + "DESCRICAO INFRACAO" + "\t" + "LOCAL MULTA" + "\t" + "DATA VENCIMENTO" + "\t" + "DATA PAGAMENTO" + "\t" + "SITUACAO" + "\t" + "PLACA" + "\t" + "CPF" + "\t" + "VALOR" + "\t" + "GRAVIDADE" + "\t");
                    while (dr.Read())
                    {
                        sw.WriteLine(dr["id_multa"].ToString() + "\t" + dr["data_multa"].ToString() + "\t" + dr["auto_infracao"].ToString() + "\t" + dr["descricao_infracao"].ToString() + "\t" + dr["local_multa"].ToString() + "\t" + dr["data_vencimento"].ToString() + "\t" + dr["data_pagamento"].ToString() + "\t" + dr["situacao"].ToString() + "\t" + dr["placa"].ToString() + "\t" + dr["cpf"].ToString() + "\t" + dr["valor"].ToString() + "\t" + dr["gravidade"].ToString() + "\t");
                    }
                    dr.Close();

                    // PNEUS
                    SqlCommand cmdPneus = new SqlCommand("SELECT * FROM pneus");
                    cmdPneus.Connection = dbConnection.getSqlConn();

                    dr = cmdPneus.ExecuteReader();

                    sw.WriteLine("\n" + "PNEUS");
                    sw.WriteLine("ID PNEUS" + "\t" + "NUMERO SERIE" + "\t" + "SITUACAO" + "\t" + "MARCA" + "\t" + "MODELO" + "\t" + "DIMENSAO" + "\t" + "PLACA" + "\t");
                    while (dr.Read())
                    {
                        sw.WriteLine(dr["id_multa"].ToString() + "\t" + dr["numero_serie"].ToString() + "\t" + dr["situacao"].ToString() + "\t" + dr["marca"].ToString() + "\t" + dr["modelo"].ToString() + "\t" + dr["dimensao"].ToString() + "\t" + dr["placa"].ToString() + "\t");
                    }
                    dr.Close();

                    // QUILOMETRAGEM
                    SqlCommand cmdQuilometragem = new SqlCommand("SELECT * FROM quilometragem");
                    cmdQuilometragem.Connection = dbConnection.getSqlConn();

                    dr = cmdQuilometragem.ExecuteReader();

                    sw.WriteLine("\n" + "QUILOMETRAGEM");
                    sw.WriteLine("ID QUILOMETRAGEM" + "\t" + "DATA INICIO" + "\t" + "DATA ATUAL" + "\t" + "PLACA" + "\t" + "QUILOMETROS RODADOS" + "\t");
                    while (dr.Read())
                    {
                        sw.WriteLine(dr["id_quilometragem"].ToString() + "\t" + dr["data_inicio"].ToString() + "\t" + dr["data_atual"].ToString() + "\t" + dr["placa"].ToString() + "\t" + dr["quilometros_rodados"].ToString() + "\t");
                    }
                    dr.Close();
                }
                catch (Exception excpt)
                {              
                    MessageBox.Show(excpt.Message);
                } 
                finally
                {
                    dbConnection.close();
                    sw.Close();
                }

            }
        }
    }
}
