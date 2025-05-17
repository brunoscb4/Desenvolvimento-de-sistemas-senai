using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace TrabalhoSenai.Programas
{
    internal class Usuario
    {
        private string nome;
        private string email;
        private string cpf;
        private string usuario1;
        private string telefone;
        private string senha;

        public string Nome
            { get { return nome; } set { nome = value; } }
        public string Email
            { get { return email; } set { email = value; } }
        public string Cpf
            { get { return cpf; } set { cpf = value; } }
        public string Usuario1
        { get { return usuario1; } set { usuario1 = value; } }
        public string Telefone
        { get { return telefone; } set { telefone = value; } }
        public string Senha
            { get { return senha; } set { senha = value; } }

        private string GerarHashSHA256(string senha)
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


        public bool NovoCadastro()
        {

            try
            {
                using (MySqlConnection sqlConnection = new MySqlConnection(BancoConexao.ConexaoBancoDados)) 
                {
                    sqlConnection.Open();
                   
                   
                    string insert = "INSERT INTO CadastroUsuario (NOME,EMAIL,CPF,USUARIO,TELEFONE,SENHA) values( @Nome,@Email,@Cpf,@Usuario1,@Telefone,@Senha)";

                    using MySqlCommand cmd = new MySqlCommand(insert, sqlConnection);

                            string senhaHash = GerarHashSHA256(Senha);

                    cmd.Parameters.AddWithValue("@Nome",Nome);
                    cmd.Parameters.AddWithValue("@Email",Email);
                    cmd.Parameters.AddWithValue("@Cpf",Cpf);
                    cmd.Parameters.AddWithValue("@Usuario1", Usuario1);
                    cmd.Parameters.AddWithValue("@Telefone",Telefone);
                    cmd.Parameters.AddWithValue("@Senha", senhaHash);
                    cmd.ExecuteNonQuery();
                        
                return true;
                }

                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco " + ex.Message);
                return false;
            }
        }

        public bool VerificarSenha()
        {
            try
            {
                using (MySqlConnection sqlConnection = new MySqlConnection(BancoConexao.ConexaoBancoDados))
                {
                    sqlConnection.Open();

                    string senhaHash = GerarHashSHA256(Senha);

                    string select = "SELECT * FROM CadastroUsuario WHERE  EMAIL = @Email AND SENHA = @Senha ";

                    MySqlCommand cmd = new MySqlCommand(@select, sqlConnection);

                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Senha", senhaHash );

                    using MySqlDataReader reader = cmd.ExecuteReader();
                     return reader.HasRows;
                }


                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a senha no banco" + ex.Message);
                return false;
            }
        }


    }
}
