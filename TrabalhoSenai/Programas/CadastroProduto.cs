using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;


namespace TrabalhoSenai.Programas
{
    internal class CadastroProduto
    {
        private int idBusca;
        private byte [] imagem;
        private string produto;
        private string categoria;
        private int estoque;
        private int codigo;
        private double valorCompra;
        private double valorVenda;
        private string idUsuario;
       private string nome;


        public int IdBusca
        { get { return idBusca; } set { idBusca = value; } }
        public byte [] Imagem
        {  get { return imagem; } set { imagem = value; } }
        public string Produto
            { get { return produto; } set { produto = value; } }
        public string Categoria
            { get { return categoria; } set { categoria = value; } }
        public int Estoque
            { get { return estoque; } set { estoque = value; } }
        public int Codigo
            { get { return codigo; } set { codigo = value; } }
        public double ValorCompra
        { get { return valorCompra; } set { valorCompra = value; } }
            public double ValorVenda
        { get { return valorVenda; } set {valorVenda = value; } }
        public string IdUsuario
        { get { return idUsuario; } set { idUsuario = value; } }
        public string Nome
        { get { return nome; } set { nome = value; } }
        

        public bool CadastroP()
        {

            try
            {
                using (MySqlConnection conecxao = new MySqlConnection(BancoConexao.ConexaoBancoDados))
                {
                    conecxao.Open();

                    string insert = "INSERT INTO CadastroProduto(IMAGEM_URL,PRODUTO,CATEGORIA,ESTOQUE,CODIGO,VALOR_DA_COMPRA,VALOR_DE_VENDA,ID_USUARIO) values (@Imagem,@Produto,@Categoria,@Estoque,@Codigo,@ValorCompra,@ValorVenda,@IdUsuario) ";

                    using MySqlCommand cmd = new MySqlCommand(insert, conecxao);

                    cmd.Parameters.AddWithValue("@Imagem", Imagem);
                    cmd.Parameters.AddWithValue("@Produto", Produto);
                    cmd.Parameters.AddWithValue("@Categoria",Categoria);
                    cmd.Parameters.AddWithValue("@Estoque",Estoque);
                    cmd.Parameters.AddWithValue("@Codigo",Codigo);
                    cmd.Parameters.AddWithValue("@ValorCompra",ValorCompra);
                    cmd.Parameters.AddWithValue("@ValorVenda",ValorVenda);
                    cmd.Parameters.AddWithValue("@IdUsuario" , IdUsuario);
                    
                    cmd.ExecuteNonQuery();

                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar informações no banco" + ex.Message);
                return false;
            }

        }


        public DataTable TableProduto ()
        {

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.ConexaoBancoDados))
                {
                
                    conexao.Open();
                    string select = "SELECT IMAGEM_URL ,PRODUTO,CATEGORIA,ESTOQUE,CODIGO,VALOR_DA_COMPRA,VALOR_DE_VENDA FROM CadastroProduto";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(select, conexao);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados"  +ex.Message);
                return null;
            }
        }

        public DataTable BuscarProduto( )
        {

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.ConexaoBancoDados))
                {

                    conexao.Open();
                    string select = "SELECT * FROM CadastroProduto WHERE CODIGO=@IdBusca OR PRODUTO LIKE  @nome";

                    MySqlCommand cmd = new MySqlCommand(select, conexao);
                    cmd.Parameters.AddWithValue("@IdBusca", IdBusca);
                    cmd.Parameters.AddWithValue("@nome","%"+nome+"%");
                    cmd.Parameters.AddWithValue("@Categoria", Categoria);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados" + ex.Message);
                return null;
            }
        }

        public DataTable BuscarCategorias()
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.ConexaoBancoDados))
                {
                    conexao.Open();

                    string query = "SELECT DISTINCT CATEGORIA FROM CadastroProduto ORDER BY CATEGORIA";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(tabela);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
            }

            return tabela;
        }

        public DataTable BuscarCategoria()
        {

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.ConexaoBancoDados))
                {

                    conexao.Open();
                    string select = "SELECT * FROM CadastroProduto WHERE CATEGORIA LIKE @Categoria ";

                    MySqlCommand cmd = new MySqlCommand(select, conexao);
                    
                    cmd.Parameters.AddWithValue("@Categoria", Categoria);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados" + ex.Message);
                return null;
            }
        }

    }
}
