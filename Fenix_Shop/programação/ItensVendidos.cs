using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Fenix_Shop.programação
{
    internal class ItensVendidos 
    {
        private static int iduser;
        private decimal valorTotal;
        private string formaPagamento = "DINHEIRO";
        private string saida {  get; set; }
        

      public static int IdUser { get { return iduser; } set { iduser = value; } }   
        public decimal ValorTotal { get { return valorTotal; } set { valorTotal = value; } }
        public string FormaPagamento { get { return formaPagamento; } set { formaPagamento = value; } }
        
        private List<ListVendas> lista { get; set; } = new List<ListVendas> { };
        public bool AddProduto (ListVendas feitas)
        {
            if (feitas != null)
            {
                lista.Add(feitas);
                return true;
            }
            return false;
        }

        public List<ListVendas> ObterLista()
        {
            return lista;
        }
        public decimal TotalVenda()
        {
            return lista.Sum(i => i.Valor * i.Quantidade);
        }
        public int QuantidadeVendidos()
        {
            return lista.Sum(i => i.Quantidade );
        }
        public void ApagarLista()
        {
            lista.Clear();
        }
        public void ExibirVendas(DataGridView dataGridView)
        {
            if (dataGridView == null) return;
            {
                 dataGridView.Rows.Clear();
            foreach (var item in lista)
            {
                dataGridView.Rows.Add(item.Id,item.Produto, item.Quantidade, item.Valor, item.Total);
            }
            }
           
        }
        

        
          
        
        
            public bool CadastrarItensVendidos()
            {
                try
                {
                    using (var connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                    {
                        connection.Open();
                        using (var transaction = connection.BeginTransaction())
                        {
                            string insert = @"INSERT INTO Vendas(IdUsuario,Total,FormaDePagamento) 
                                          VALUES(@IdUser,@ValorTotal,@FormaPagamento) RETURNING Id";
                            using (var cmd = new SQLiteCommand(insert, connection,transaction))
                            {
                                cmd.Parameters.AddWithValue("@IdUser", IdUser);
                                cmd.Parameters.AddWithValue("@ValorTotal", ValorTotal.ToString("F2"));
                                cmd.Parameters.AddWithValue("@FormaPagamento", FormaPagamento);

                                int IdVendas = Convert.ToInt32(cmd.ExecuteScalar());
                                string insertItensVendidos = @"INSERT INTO ItensVendidos(IdVenda,IdProduto,Quantidade,PrecoUnitario) 
                                                            VALUES(@IdVenda,@IdProduto,@Quantidade,@PrecoUnitario)";

                                string estoque = @"INSERT INTO Estoque( IdProduto,Tipo ,Quantidade,ValorUnitario) VALUES (@IdProduto,@saida,@Quantidade,@PrecoUnitario)";
                            foreach (var item in lista)
                            {
                                using (var cmdItens = new SQLiteCommand(insertItensVendidos, connection,transaction))
                                {
                                    using (var cmdSaida = new SQLiteCommand(estoque, connection, transaction))
                                    {
                                        

                                        cmdItens.Parameters.AddWithValue("@IdVenda", IdVendas);
                                        cmdItens.Parameters.AddWithValue("@IdProduto", item.Id);
                                        cmdItens.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                                        cmdItens.Parameters.AddWithValue("@PrecoUnitario", item.Valor.ToString(CultureInfo.InvariantCulture) );
                                        cmdItens.ExecuteNonQuery();
                                        
                                        cmdSaida.Parameters.AddWithValue("@IdProduto",item.Id);
                                        cmdSaida.Parameters.AddWithValue("@saida", saida = "SAIDA");
                                        cmdSaida.Parameters.AddWithValue("@Quantidade",item.Quantidade);
                                        cmdSaida.Parameters.AddWithValue("@PrecoUnitario",item.Valor.ToString(CultureInfo.InvariantCulture));
                                        cmdSaida.ExecuteNonQuery();

                                    }
                                }
                            }
                                                                                
                            }
                            transaction.Commit();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao cadastrar itens vendidos: {ex.Message}");
                    return false;
                }
            }

        public int QtVendidas()
        {
            try
            { 
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
            {
                    connection.Open();

                    string qtVendidos = @"SELECT SUM(Quantidade )FROM ItensVendidos";
                    using (SQLiteCommand cmd = new SQLiteCommand(qtVendidos, connection))
                    {
                         object resultado = cmd.ExecuteScalar();

                        if (resultado != DBNull.Value && resultado != null)
                        {
                            return Convert.ToInt32(resultado);
                        }
                        else
                        {
                            return 0;
                        }
                    }

                    
                   
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar Quantidade "+ ex.Message);
                return 0;
            }
           
        }

        public int QtItemsCadastrados()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    string Cadastrados = @"SELECT COUNT(*) FROM CadastroProduto";
                    using (SQLiteCommand cmd = new SQLiteCommand(Cadastrados,connection))
                    {
                        object resultado = cmd.ExecuteScalar() ;
                        if (resultado != DBNull.Value && resultado != null)
                        {
                            return Convert.ToInt32(resultado);
                        }
                        else
                        {
                            return 0;
                        }
                        
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao fazer a contagem produtos cadastrados " +ex.Message);
                return 0;
            }
        }

        public decimal TotalVendidos()
        {
            try
            {
                using (SQLiteConnection connetion = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connetion.Open();

                    string Totalvendods = @"SELECT COALESCE (SUM(CAST(Total AS REAL)),0)FROM Vendas";

                    using (SQLiteCommand cmd = new SQLiteCommand(Totalvendods, connetion))
                    {
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != DBNull.Value && resultado != null)
                        {
                            decimal valor = Convert.ToDecimal(resultado);
                            
                            return Math.Round(valor, 2);
                        }
                        else
                        {
                            return 0;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar valor total vendido "+ ex.Message);
                return 0;
            }
        }

        public int VendasRealizadas()
        {
            try
            {
                using ( SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();
                    string VendasRealizadas = @"SELECT COUNT(*) FROM Vendas";

                    using (SQLiteCommand cmd = new SQLiteCommand(VendasRealizadas, connection))
                    {
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != DBNull.Value && resultado != null)
                        {
                            return Convert.ToInt32(resultado);
                        }
                        else
                        {
                            return 0;
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao buscar vendas realizadas " + ex.Message);
                return 0;
            }
        }


        public decimal TotalCustoProdutos()
        {
            try {
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    string TotalCusto = @"SELECT SUM(c.ValorDeCusto * i.Quantidade)
                                    FROM ItensVendidos i
                                    JOIN CadastroProduto c ON i.IdProduto = c.Id ";

                    using (SQLiteCommand cmd = new SQLiteCommand(TotalCusto, connection))
                    {
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != DBNull.Value && resultado != null)
                        {
                            return Convert.ToDecimal(resultado);
                        }
                        else
                        { return 0; }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar total valor do valor de custo " + ex.Message);
                return 0;
            }
        }

        public DataTable TotalPorProduto()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                  
                    DataTable dt = new DataTable();  string TotalCusto = @"SELECT c.Foto AS FOTO ,c.Nome AS PRODUTO,SUM(i.Quantidade ) AS VENDIDOS,c.ValorDeVenda AS VALOR,
                                    SUM (CAST(c.ValorDeVenda AS REAL) * i.Quantidade)  AS TOTAL
                                    FROM ItensVendidos i
                                    JOIN CadastroProduto c ON i.IdProduto = c.Id
                                    GROUP BY c.Id";
                    using (SQLiteCommand cmd = new SQLiteCommand(TotalCusto, connection))
                    {
                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                            return dt;
                        }
                        
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar total valor do valor de custo " + ex.Message);
                return null;
            }
        }


    }
}
