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
        private static int iduser;
        private decimal valorTotal;
        private string formaPagamento = "DINHEIRO";  
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
        public static int IdUser { get { return iduser; } set { iduser = value; } }   
        public decimal ValorTotal { get { return valorTotal; } set { valorTotal = value; } }
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
                                string insertItensVendidos = @"INSERT INTO ItensVendidos(IdVenda,IdProduto,Quantidade,PrecoUnitario) 
                                                            VALUES(@IdVenda,@IdProduto,@Quantidade,@PrecoUnitario)";

                            foreach (var item in lista)
                            {
                                using (var cmdItens = new SQLiteCommand(insertItensVendidos, connection))
                                {
                                    cmdItens.Parameters.AddWithValue("@IdVenda", IdVendas);
                                    cmdItens.Parameters.AddWithValue("@IdProduto", item.Id);
                                    cmdItens.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                                    cmdItens.Parameters.AddWithValue("@PrecoUnitario", item.Valor);
                                    cmdItens.ExecuteNonQuery();
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
            catch (Exception)
            {

                throw;
            }
           
        }
        
    }
}
