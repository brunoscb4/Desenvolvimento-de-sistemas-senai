using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Projeto02.Programas
{ 
    class Cadastro
    {
        private int id;
        private string jogo;
        private string empresa;
        private string categoria;
        private int estoque;
        private double valor;
        private int id_jogos;

        public int Id
        { get { return id;  } set { id = value; } }
        public string Jogo
        {  get { return jogo; } set { jogo = value; } }
        public string Empresa
            { get { return empresa; } set { empresa = value; } }
        public string Categoria
            { get { return categoria; } set { categoria = value; } }
        public int Estoque
            { get { return estoque; } set { estoque = value; } }
        public double Valor
            { get { return valor; } set { valor = value; } }
        public int Id_jogos
        { get { return id_jogos; } set {  id_jogos = value; } }


        

        public bool Cadastrojogo()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                    conexao.Open();

                    string insert = "INSERT INTO CadastroDeJogos (JOGO,EMPRESA,CATEGORIA,ESTOQUE,VALOR, ID_JOGOS) VALUES (@Jogo,@Empresa,@Categoria,@Estoque,@Valor,@Id_jogos)";

                    using MySqlCommand cmd = new MySqlCommand(insert, conexao);
                    cmd.Parameters.AddWithValue("@Jogo",Jogo);
                    cmd.Parameters.AddWithValue("@Empresa",Empresa);
                    cmd.Parameters.AddWithValue("@Categoria",Categoria);
                    cmd.Parameters.AddWithValue("@Estoque",Estoque);
                    cmd.Parameters.AddWithValue("@Valor", Valor);
                    cmd.Parameters.AddWithValue("@Id_jogos",Id_jogos);
                    cmd.ExecuteNonQuery();
                    return true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastro no banco " + ex.Message);
                return false;
            }
        }


        public DataTable Select()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                    conexao.Open();

                    string select = " SELECT * FROM CadastroDeJogos";

                   MySqlDataAdapter adapter = new MySqlDataAdapter( select, conexao);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar dados cadastrados ..");
                return null;
            }
        }

        public bool Editar()
        {

            try
            {
                using (MySqlConnection conexao = new MySqlConnection (BancoConexao.Conexao))
                {
                    conexao.Open();

                    string update = "UPDATE CadastroDeJogos SET JOGO=@Jogo,EMPRESA=@Empresa,CATEGORIA=@Categoria,ESTOQUE=@Estoque,VALOR=@Valor WHERE ID =@Id";
                    MySqlCommand cmd = new MySqlCommand(update, conexao);
                    cmd.Parameters.AddWithValue("@Jogo", Jogo);
                    cmd.Parameters.AddWithValue("@Empresa",Empresa);
                    cmd.Parameters.AddWithValue("@Categoria", Categoria);
                    cmd.Parameters.AddWithValue("@Estoque", Estoque);
                    cmd.Parameters.AddWithValue("@Valor", valor);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar no banco " + ex.Message);
                return false;
            }
        }
        public bool Excluir()
        {

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                    conexao.Open();

                    string update = "DELETE FROM CadastroDeJogos  WHERE ID =@Id";
                    MySqlCommand cmd = new MySqlCommand(update, conexao);
                   
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar no banco " + ex.Message);
                return false;
            }
        }

        public DataTable Procurar()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection (BancoConexao.Conexao))
                {
                    conexao.Open();

                    string preocura = "SELECT * FROM CadastroDeJogos  WHERE JOGO LIKE @Jogo";
                    MySqlCommand cmd = new MySqlCommand (preocura, conexao);
                    cmd.Parameters.AddWithValue("@Jogo", "%" + Jogo + "%");
                    
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar nome " + ex.Message);
                return null ;
            }

        }




    }
    class Usuario
    {
        
        private string nome;
        private string email;
        private string usuario;
        private string senha;
        private string cpf;
        private string telefone;

       

        
        public string Nome
        { get { return nome; } set { nome = value; } }

        public string Email
        { get { return email; } set { email = value; } }

        public string Usuario1
        { get { return usuario; } set { usuario = value; } }

        public string Senha
        { get { return senha; } set { senha = value; } }
        public string Cpf
        { get { return cpf; } set { cpf = value; } }

        public string Tefelofe
        { get { return telefone; } set { telefone = value; } }
       

        private string GerarHashsha256(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();

            }

        }

        public bool CadastroUsuario()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection (BancoConexao.Conexao))
                {
                    conexao.Open();

                    string insert = "INSERT INTO CadastroUsuario( NOME,EMAIL,USUARIO,SENHA,CPF,TELEFONE) VALUES (@Nome,@Email,@Usuario1,@Senha,@Cpf,@Telefone)";
                    MySqlCommand cmd = new MySqlCommand(insert, conexao);

                    string senhaHash = GerarHashsha256 (Senha);
                  
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Email",Email);
                    cmd.Parameters.AddWithValue("@Usuario1",Usuario1);
                    cmd.Parameters.AddWithValue("@Senha", senhaHash);
                    cmd.Parameters.AddWithValue("@Cpf", Cpf);
                    cmd.Parameters.AddWithValue("@Telefone",telefone);
                    cmd.ExecuteNonQuery();
                    return true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar as informações no banco " + ex.Message);
                return false;
            }
        }

        public bool VerificarLogin()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection (BancoConexao.Conexao))
                {
                    conexao.Open();
                    string senhaHash = GerarHashsha256(Senha);
                    string verifica = " SELECT * FROM CadastroUsuario WHERE EMAIL=@Email and SENHA=@Senha";

                    MySqlCommand cmd = new MySqlCommand(verifica, conexao);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Senha",senhaHash);

                    using MySqlDataReader reader = cmd.ExecuteReader();
                    
                       return reader.HasRows;
                    
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao verificar email e senha " + ex.Message);
                return false;

            }
        }


        public DataTable IdUser()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                conexao.Open();

                string select = "SELECT ID FROM CadastroUsuario WHERE EMAIL=@Email";

                    MySqlCommand cmd = new MySqlCommand (select, conexao);
                    cmd.Parameters.AddWithValue("@Email",Email);
                    
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;

                   
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar id " + ex.Message);
                return null;
            }
            
        }



    }

}
