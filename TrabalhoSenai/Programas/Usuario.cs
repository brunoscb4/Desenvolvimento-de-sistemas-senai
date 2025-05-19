using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Data;

namespace TrabalhoSenai.Programas
{
    internal class Usuario
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private string usuario1;
        private string telefone;
        private string senha;
        private string emailVerifica;


        public int Id
        { get { return id; } set { id = value; } }
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
        public string EmailVerifica
        { get { return emailVerifica; } set { emailVerifica = value; } }

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

              
        private void Cadastro_Load(object sender, EventArgs e)
        {
            
        }
        public int  RetornoId()
        {
            try
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(BancoConexao.ConexaoBancoDados))
                {
                    mySqlConnection.Open();
                    string select = "SELECT ID FROM CadastroUsuario WHERE EMAIL = @Email ";

                    MySqlCommand cmd = new MySqlCommand(select,mySqlConnection);

                    cmd.Parameters.AddWithValue("@Email",Email);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }

                     return -1;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao retornar valor de id " + ex.Message);

                return -1;
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


        public DataTable SelectUsuario()
        {
            using (MySqlConnection conexao = new MySqlConnection(BancoConexao.ConexaoBancoDados))
            {
                conexao.Open();

                try
                {
                    string select = "SELECT * FROM CadastroUsuario ";

                    MySqlCommand cmd = new MySqlCommand(select, conexao);
              
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro ao acessar banco"+ ex.Message);
                    return null;
                }

            }
        }




    }
}
