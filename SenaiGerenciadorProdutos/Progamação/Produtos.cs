using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SenaiGerenciadorProdutos.Progamação
{
    internal class Produtos
    {
        private string nomeProduto;
        private double preco;
        private int estoque;
        private string categoria;
        private int idBanco;
        private string pesquisa;

        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }
        public double Preco
            {
            get { return preco; } 
            set { preco = value; } 
        }
        public int Estoque
        { 
            get { return estoque; }
            set { estoque = value; }
        }
        public string Categoria
            {
            get { return categoria; }
            set { categoria = value; }
                
            }
        public int IdBanco
        {
            get { return idBanco; }
            set { idBanco = value; }
        }
        public string Pesquisa
        {
            get { return pesquisa; }
            set { pesquisa = value; }
        }

        public bool CadastroProduto()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(BancoConection.ConexaoBanco);
                conexao.Open();

                string insert = "INSERT INTO CadastroProduto (PRODUTO,PRECO,ESTOQUE,CATEGORIA) VALUE (@NomeProduto,@Preco,@Estoque,@Categoria)";

                MySqlCommand cmd = new MySqlCommand(insert, conexao);
                cmd.Parameters.AddWithValue("@NomeProduto", NomeProduto);
                cmd.Parameters.AddWithValue("@Preco",Preco);
                cmd.Parameters.AddWithValue("@Estoque",Estoque);
                cmd.Parameters.AddWithValue("@Categoria", categoria);
                cmd.ExecuteNonQuery();
                MessageBox.Show("cadastro realizado...");
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar banco "+ ex.Message);
                return false;
            }


            
        }

        public DataTable Listar()
        {
            DataTable dataTable = new DataTable();
            try
            {
                MySqlConnection conexao = new MySqlConnection(BancoConection.ConexaoBanco);
            conexao.Open();

            string listar = "SELECT id, PRODUTO,PRECO,ESTOQUE,CATEGORIA FROM CadastroProduto";
            MySqlDataAdapter adapter = new MySqlDataAdapter(listar, conexao);

               adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Erro acessar o banco "+ ex.Message);
                return null!;
            }
            
           

        }

        public bool Editar()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(BancoConection.ConexaoBanco);
                conexao.Open();

                string editar = "UPDATE CadastroProduto SET PRODUTO=@NomeProduto,PRECO=@Preco,ESTOQUE=@Estoque,CATEGORIA=@Categoria WHERE id = @IdBanco";

                MySqlCommand cmd = new MySqlCommand(editar, conexao);
                cmd.Parameters.AddWithValue("@NomeProduto",NomeProduto);
                cmd.Parameters.AddWithValue("@Preco",Preco);
                cmd.Parameters.AddWithValue("@Estoque",Estoque);
                cmd.Parameters.AddWithValue("@Categoria", Categoria);
                cmd.Parameters.AddWithValue("@IdBanco",IdBanco);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco" + ex.Message);
                return false;
            }
        }


        public DataTable Seach()
        {
            DataTable dataTable = new DataTable();
            try
            {
                MySqlConnection conexao = new MySqlConnection(BancoConection.ConexaoBanco);
                conexao.Open();

                string listar = "SELECT PRODUTO,PRECO,ESTOQUE,CATEGORIA FROM CadastroProduto WHERE PRODUTO = @Pesquisa";
                MySqlCommand cmd = new MySqlCommand (listar, conexao);

                cmd.Parameters.AddWithValue("@Pesquisa",Pesquisa);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao acessar o banco " + ex.Message);
                return null!;
            }

        }


        public bool Excluir()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(BancoConection.ConexaoBanco);
                conexao.Open();

                string editar = "DELETE FROM CadastroProduto  WHERE id = @IdBanco";

                MySqlCommand cmd = new MySqlCommand(editar, conexao);
                cmd.Parameters.AddWithValue("@NomeProduto", NomeProduto);
                cmd.Parameters.AddWithValue("@Preco", Preco);
                cmd.Parameters.AddWithValue("@Estoque", Estoque);
                cmd.Parameters.AddWithValue("@Categoria", Categoria);
                cmd.Parameters.AddWithValue("@IdBanco", IdBanco);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco" + ex.Message);
                return false;
            }
        }



        public DataTable ListarCategoria()
        {

            DataTable dataTable = new DataTable();
            try
            {
                MySqlConnection conexao = new MySqlConnection(BancoConection.ConexaoBanco);
                conexao.Open();

                string listar = "SELECT DISTINCT CATEGORIA FROM CadastroProduto ";
                MySqlCommand cmd = new MySqlCommand(listar, conexao);

               
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao acessar o banco " + ex.Message);
                return null!;
            }
        }

    }
}
