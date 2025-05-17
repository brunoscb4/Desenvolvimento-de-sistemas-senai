using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;


namespace TrabalhoSenai.Programas
{
    internal class CadastroProduto
    {
        private byte [] imagem;
        private string produto;
        private string categoria;
        private int estoque;
        private int codigo;
        private double valorCompra;
        private double valorVenda;
        private int idUsuario;


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
        public int IdUsuario
        { get { return idUsuario; } set { idUsuario = value; } }

        

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
    }
}
