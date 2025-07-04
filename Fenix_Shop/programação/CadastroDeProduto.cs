using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix_Shop.programação
{
    internal class CadastroDeProduto
    {
        private byte[] imagem;
        private string nome, categoria, marca, descricao, movimentacaoEstoque;
        private double valorCusto, valorVenda;
        private int estoque, codigoBarras, sku, esMinimo;
        private DateTime dataCadastro;

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
        public int CodigoBarras
            { get { return codigoBarras; } set { codigoBarras = value; } }
        public int Sku
            { get { return sku; } set { sku = value; } }
        public int EsMinimo
            { get { return esMinimo; } set { esMinimo = value; } }
        public DateTime DataCadastro
            { get { return dataCadastro; } set { dataCadastro = value; } }


        public bool CadastroProdutoEstoque ()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        UsuarioLogado usuarioLogado = new UsuarioLogado();
                        int id = usuarioLogado.Id;
                        string insert = @"INSERT INTO CadastroProduto(IdUsuario,Nome,Categoria,Descricao,Marca,ValorDeCusto,ValorDeVenda,CodigoDeBarras,Sku,Foto)" +
                            "VALUES(@Id,@Nome,@Categoria,@Marca,@Descricao,@ValorCusto,@ValorVenda,@CodigoBarras,@Sku,@Imagem) RETURNING Id";

                        double ValorDeCustoFormatado = Math.Round(ValorCusto, 2);
                        double ValorDeVendaFormatado = Math.Round(ValorVenda,2);
                        using (SQLiteCommand cmd = new SQLiteCommand(insert, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@Nome", Nome);
                            cmd.Parameters.AddWithValue("@Categoria", Categoria);
                            cmd.Parameters.AddWithValue("@Marca", Marca);
                            cmd.Parameters.AddWithValue("@Descricao", Descricao);
                            cmd.Parameters.AddWithValue("@ValorCusto", ValorDeCustoFormatado);
                            cmd.Parameters.AddWithValue("@ValorVenda", ValorDeVendaFormatado);
                            cmd.Parameters.AddWithValue("@CodigoBarras", CodigoBarras);
                            cmd.Parameters.AddWithValue("@Sku", Sku);
                            cmd.Parameters.AddWithValue("@Imagem", Imagem);

                            int idProduto = Convert.ToInt32(cmd.ExecuteScalar());

                            string insertEstoque = @"INSERT INTO Estoque (IdProduto,Tipo,Quantidade,ValorUnitario) VALUES (@IdProduto,@MovimentacaoEstoque,@Estoque,@ValorVenda) ";
                            using (SQLiteCommand cmdEstoque = new SQLiteCommand(insertEstoque, connection))
                            {
                                cmdEstoque.Parameters.AddWithValue("@IdProduto",idProduto);
                                cmdEstoque.Parameters.AddWithValue("@MovimentacaoEstoque", MovimentacaoEstoque);
                                cmdEstoque.Parameters.AddWithValue("@Estoque", Estoque);
                                cmdEstoque.Parameters.AddWithValue("@ValorVenda", ValorVenda);
                             
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
                MessageBox.Show("Erro não foi possivel realizar  o cadastro "+ ex.Message);
                return false;
            }
        }
       
       

        public DataTable ProdutosRegistrados()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection (BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    string select = "SELECT cp.Nome, cp.ValorDeVenda,cp.DataDeCadastro, e.Quantidade AS Estoque FROM CadastroProduto cp " +
                        "JOIN  Estoque e ON cp.Id = e.IdProduto";

                   DataTable dt = new DataTable();

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(select,connection))
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aceesar dados "+ ex.Message);
                return null;
            }
        }
        
        


        
    }
}
