using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Projeto_03.programação
{
    internal class Usuario
    {
        private string nome;
        private string email;
        private string usuario;
        private string cpf;
        private string telefone;
        private string senha;


        public string Nome
        { get { return nome; } set { nome = value; } }

        public string Email
            { get { return email; } set { email = value; } }

        public string Usuario1
        { get { return usuario; } set { usuario = value; } }

        public string Cpf
            { get { return cpf; } set { cpf = value; } }

        public string Telefone
        { get { return telefone; } set { telefone = value; } }

            public string Senha
            { get { return senha; } set { senha = value; } }


        public string GerarHash (string senha)
        {
            using(SHA256    sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes (senha);
                byte[] hash = sha256.ComputeHash (bytes);
                return Convert.ToBase64String (hash);
            }
        }

        public bool CadastroNovo()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.conexao))
                {
                    conexao.Open();

                    string insert = "INSERT INTO usuario (NOME,EMAIL,USUARIO,CPF,TELEFONE,SENHA) VALUES (@Nome,@Email,@Usuario1,@Cpf,@Telefone,@Senha)";
                    string senhaHash = GerarHash(Senha);
                    using( MySqlCommand cmd = new MySqlCommand (insert,conexao))
                    {
                        cmd.Parameters.AddWithValue("@Nome",Nome);
                        cmd.Parameters.AddWithValue("@Email",Email);
                        cmd.Parameters.AddWithValue("@Usuario1",Usuario1);
                        cmd.Parameters.AddWithValue("@Cpf",Cpf);
                        cmd.Parameters.AddWithValue("@Telefone",Telefone);
                        cmd.Parameters.AddWithValue("@Senha",senhaHash);
                        cmd.ExecuteNonQuery();
                        return true;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados" + ex.Message);
                return false;
            }
        }


        public bool Login()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.conexao))
                {
                    conexao.Open();

                    string Login = "SELECT * FROM usuario WHERE EMAIL= @Email AND SENHA=@Senha";
                    string senhaHash = GerarHash(Senha);

                    using (MySqlCommand cmd = new MySqlCommand(Login, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Email",Email);
                        cmd.Parameters.AddWithValue("@Senha",senhaHash);

                        using MySqlDataReader reader = cmd.ExecuteReader();

                        return reader.Read();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro ao procurar no banco de dados " + ex.Message);
                return false;
            }
        }


        public int Chave(string email, string senha )
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.conexao))
                {
                    conexao.Open();

                    string Login = "SELECT ID FROM usuario WHERE EMAIL= @Email AND SENHA=@Senha";
                    string senhaHash = GerarHash(senha);

                    using (MySqlCommand cmd = new MySqlCommand(Login, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Senha", senhaHash);

                        using MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            return reader.GetInt32("ID");
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
                MessageBox.Show(" Erro ao procurar no banco de dados " + ex.Message);
                return 0;
            }
        }




    }
}
