using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix_Shop.programação
{
    internal class CadastroDeProduto
    {
        private byte[] imagem;
        private string nome, categoria, marca, descricao, movimentacaoEstoque, codigoBarras, sku;
        private double valorCusto, valorVenda;
        private int estoque, esMinimo;
        private DateTime dataCadastro;
        private static int id;
        public byte[] Imagem
        { get { return imagem; } set { imagem = value; } }
        public string Nome
        { get { return nome; } set { nome = value; } }
        public string Categoria
        { get { return categoria; } set { categoria = value; } }
        public string Marca
        { get { return marca; } set { marca = value; } }
        public string Descricao
        { get { return descricao; } set { descricao = value; } }
        public string MovimentacaoEstoque
        { get { return movimentacaoEstoque; } set { movimentacaoEstoque = value; } }
        public double ValorCusto
        { get { return valorCusto; } set { valorCusto = value; } }
        public double ValorVenda
        { get { return valorVenda; } set { valorVenda = value; } }
        public int Estoque
        { get { return estoque; } set { estoque = value; } }
        public string CodigoBarras
        { get { return codigoBarras; } set { codigoBarras = value; } }
        public string Sku
        { get { return sku; } set { sku = value; } }
        public int EsMinimo
        { get { return esMinimo; } set { esMinimo = value; } }
        public static int Id
        { get { return id; } set { id = value; } }
        public DateTime DataCadastro
        { get { return dataCadastro; } set { dataCadastro = value; } }


        public bool CadastroProdutoEstoque()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {


                        string insert = @"INSERT INTO CadastroProduto(IdUsuario,Nome,Categoria,Descricao,Marca,ValorDeCusto,ValorDeVenda,CodigoDeBarras,Sku,Foto)" +
                            "VALUES(@Id,@Nome,@Categoria,@Descricao,@Marca,@ValorCusto,@ValorVenda,@CodigoBarras,@Sku,@Imagem) RETURNING Id";

                        double ValorDeCustoFormatado = Math.Round(ValorCusto, 2);
                        double ValorDeVendaFormatado = Math.Round(ValorVenda, 2);
                        using (SQLiteCommand cmd = new SQLiteCommand(insert, connection))
                        {
                            cmd.Parameters.AddWithValue("@Id", Id);
                            cmd.Parameters.AddWithValue("@Nome", Nome);
                            cmd.Parameters.AddWithValue("@Categoria", Categoria);
                            cmd.Parameters.AddWithValue("@Marca", Marca);
                            cmd.Parameters.AddWithValue("@Descricao", Descricao);
                            cmd.Parameters.AddWithValue("@ValorCusto", ValorDeCustoFormatado.ToString(CultureInfo.InvariantCulture));
                            cmd.Parameters.AddWithValue("@ValorVenda", ValorDeVendaFormatado.ToString(CultureInfo.InvariantCulture));
                            cmd.Parameters.AddWithValue("@CodigoBarras", CodigoBarras);
                            cmd.Parameters.AddWithValue("@Sku", Sku);
                            cmd.Parameters.AddWithValue("@Imagem", Imagem);

                            int idProduto = Convert.ToInt32(cmd.ExecuteScalar());

                            string insertEstoque = @"INSERT INTO Estoque (IdProduto,Tipo,Quantidade,ValorUnitario) VALUES (@IdProduto,@MovimentacaoEstoque,@Estoque,@ValorVenda) ";
                            using (SQLiteCommand cmdEstoque = new SQLiteCommand(insertEstoque, connection))
                            {
                                cmdEstoque.Parameters.AddWithValue("@IdProduto", idProduto);
                                cmdEstoque.Parameters.AddWithValue("@MovimentacaoEstoque", MovimentacaoEstoque);
                                cmdEstoque.Parameters.AddWithValue("@Estoque", Estoque);
                                cmdEstoque.Parameters.AddWithValue("@ValorVenda", ValorVenda.ToString(CultureInfo.InvariantCulture));

                                cmdEstoque.ExecuteNonQuery();
                            }

                            transaction.Commit();

                        }
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro não foi possivel realizar  o cadastro " + ex.Message);
                return false;
            }
        }



        public DataTable ProdutosRegistrados()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    string select = @"SELECT u.Nome AS USUARIO, p.Nome AS PRODUTO,p.Id AS CODIGO, p.ValorDeVenda AS VALOR,
                   SUM(CASE WHEN Tipo = 'ENTRADA' THEN Quantidade ELSE 0 END) -
                   SUM(CASE WHEN Tipo = 'SAIDA' THEN Quantidade ELSE 0 END) AS ESTOQUE FROM Usuario u 
                    JOIN CadastroProduto p ON p.IdUsuario = u.Id
                    JOIN Estoque e ON e.IdProduto = p.Id  GROUP BY IdProduto " ;

                    DataTable dt = new DataTable();

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(select, connection))
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aceesar dados " + ex.Message);
                return null;
            }
        }

        public static int  PrSemEstoque()
        {
            try
            {
                using ( SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();
                    string SemEstoque = @"SELECT COUNT(*) FROM ( 
                                       SELECT IdProduto 
                                        FROM Estoque
                                        GROUP BY IdProduto
                                        HAVING SUM(CASE WHEN Tipo = 'ENTRADA' THEN Quantidade ELSE 0 END) -
                                          SUM(CASE WHEN Tipo = 'SAIDA' THEN Quantidade ELSE 0 END  ) = 0 
                                          )";
                    using (var cmd = new SQLiteCommand(SemEstoque,connection))
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

                MessageBox.Show("Erro ao buscar produto sem estoque" + ex.Message);
                return 0;   
            }
        
        }


        public DataTable ProdutosRegistradosVendas()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    string select = @"SELECT Id AS CODIGO,Nome AS PRODUTO ,Marca AS MARCA,ValorDeVenda AS VALOR,Foto AS FOTO FROM CadastroProduto";

                    DataTable dt = new DataTable();

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(select, connection))
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aceesar dados " + ex.Message);
                return null;
            }
        }
        public DataTable ProdutosRegisBuscaId(int? id)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    string select = @"SELECT u.Nome AS USUARIO, p.Nome AS PRODUTO,p.Id AS CODIGO, p.ValorDeVenda AS VALOR,e.Quantidade AS ESTOQUE FROM Usuario u 
                    JOIN CadastroProduto p ON p.IdUsuario = u.Id
                    JOIN Estoque e ON e.IdProduto = p.Id WHERE  p.Id = @id";

                    DataTable dt = new DataTable();
                    using SQLiteCommand cmd = new SQLiteCommand(select, connection);

                    cmd.Parameters.AddWithValue("@id",id);


                    using SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                    adapter.Fill(dt);
                    return dt;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aceesar dados " + ex.Message);
                return null;
            }
        }

            public DataTable ProdutosRegisBuscaNome( string nome)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    string select = @"SELECT u.Nome AS USUARIO, p.Nome AS PRODUTO,p.Id AS CODIGO, p.ValorDeVenda AS VALOR,e.Quantidade AS ESTOQUE FROM Usuario u 
                    JOIN CadastroProduto p ON p.IdUsuario = u.Id
                    JOIN Estoque e ON e.IdProduto = p.Id WHERE p.Nome LIKE @nome ";

                    DataTable dt = new DataTable();
                    using SQLiteCommand cmd = new SQLiteCommand(select, connection);

                    cmd.Parameters.AddWithValue("@nome", "%"+nome+"%");


                    using SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                    adapter.Fill(dt);
                    return dt;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aceesar dados " + ex.Message);
                return null;
            }
        }

        public DataTable BuscarPorId( int? id)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    string Select = @"SELECT Id,Nome,Marca,ValorDeVenda,Foto FROM CadastroProduto WHERE @id IS NULL OR Id = @id ";
                    DataTable dt = new DataTable();
                    using SQLiteCommand cmd = new SQLiteCommand(Select, connection);

                    cmd.Parameters.AddWithValue("@id",  id );
                  
                    using SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado ");
                return null;
            }



        }

        public DataTable BuscarPorNome(string nome)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    string Select = @"SELECT Id,Nome,Marca,ValorDeVenda,Foto FROM CadastroProduto WHERE Nome LIKE @nome ";
                    DataTable dt = new DataTable();
                    using SQLiteCommand cmd = new SQLiteCommand(Select, connection);

                    
                    cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                  
                    using SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado ");
                return null;
            }



        }
    }
}
