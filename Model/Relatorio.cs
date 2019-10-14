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
