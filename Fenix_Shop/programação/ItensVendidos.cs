using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Fenix_Shop.programação
{
    internal class ItensVendidos
    {
        private int iduser, idProduto, quantidadevendidas;
        private decimal valorTotal, precounitario;
        private string formaPagamento;


        public int IdUser { get { return iduser; } set { iduser = value; } }
        public int IdProduto { get { return idProduto; } set { idProduto = value; } }
        public int QuantidadeVendidas { get { return quantidadevendidas; } set { quantidadevendidas = value; } }
        public decimal ValorTotal { get { return valorTotal; } set { valorTotal = value; } }
        public decimal PrecoUnitario { get { return precounitario; } set { precounitario = value; } }
        public string FormaPagamento { get { return formaPagamento; } set { formaPagamento = value; } }


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
                        using (var cmd = new SQLiteCommand(insert, connection))
                        {
                            cmd.Parameters.AddWithValue("@IdUser", IdUser);
                            cmd.Parameters.AddWithValue("@ValorTotal", ValorTotal);
                            cmd.Parameters.AddWithValue("@FormaPagamento", FormaPagamento);

                            int IdVendas = Convert.ToInt32(cmd.ExecuteScalar());
                            string insertItensVendidos = @"INSERT INTO ItensVendidos(IdVenda,IdProduto,QuantidadeVendidas,PrecoUnitario) 
                                                            VALUES(@IdVenda,@IdProduto,@QuantidadeVendidas,@PrecoUnitario)";
                            using (var cmdItens = new SQLiteCommand(insertItensVendidos, connection))
                            {
                                cmdItens.Parameters.AddWithValue("@IdVenda", IdVendas);
                                cmdItens.Parameters.AddWithValue("@IdProduto", IdProduto);
                                cmdItens.Parameters.AddWithValue("@QuantidadeVendidas", QuantidadeVendidas);
                                cmdItens.Parameters.AddWithValue("@PrecoUnitario", PrecoUnitario);
                                cmdItens.ExecuteNonQuery();
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
    }
}
