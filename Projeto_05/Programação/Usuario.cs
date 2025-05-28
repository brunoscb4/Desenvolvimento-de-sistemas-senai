using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace Projeto_05.Programação
{
    internal class Usuario
    {

        private string nome;
        private string email;
        private string cpf;
        private string telefone;
        private string senha;

        public string Nome
        { get { return nome; } set { nome = value; } }

        public string Email
        { get { return email; } set { email = value; } }

        public string Cpf
        { get { return cpf; } set { cpf = value; } }    

        public string Telefone
        { get { return telefone; } set { telefone = value; } }

        public string Senha
        { get { return senha; } set { senha = value; } }



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

        public bool InsertCadastro()
        {
            try
            {

                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                    conexao.Open();

                    string insert = " INSERT INTO usuario (NOME,EMAIL,CPF,TELEFONE,SENHA) VALUES (@Nome,@Email,@Cpf,@Telefone,@Senha)";
                    string senhaHash = GerarHashsha256(Senha);

                    using MySqlCommand cmd = new MySqlCommand(insert, conexao);

                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Cpf", Cpf);
                    cmd.Parameters.AddWithValue("@Telefone", Telefone);
                    cmd.Parameters.AddWithValue("@Senha", senhaHash);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realozado..");

                    return true;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar banco de dados " + ex.Message);
                return false;
            }
        }

        public bool VerificarLogin()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                    conexao.Open();
                    string senhaHash = GerarHashsha256(Senha);

                    string verificar = " SELECT * FROM  usuario WHERE  EMAIL=@Email AND SENHA= @Senha";

                    using MySqlCommand cmd = new MySqlCommand(verificar, conexao);

                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Senha", senhaHash);

                    using MySqlDataReader reader = cmd.ExecuteReader();

                    return reader.HasRows;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conecatar ao abnco de dados " + ex.Message);
                return false;
            }
        }
    }
}
