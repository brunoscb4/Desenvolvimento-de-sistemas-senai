using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ControContatos.Programação
{
    class Usuario
    {
        private int id = 1;
        private string nome;
        private string email;
        private string cpf;
        private string telefone;
        private string senha;
        private string nomeContato;
        private string telCadastro;

        private int Id
        { get { return id; } }
        public string Nome
        { get { return nome; } set { nome = value; } }

        public string Email
        { get { return email; } set { email = value; } }

        public string Cpf
        { get { return cpf; } set { cpf = value; } }

        public string Telefone
        { get { return telefone; } set { telefone = value; } }

        public string Senha
        { get { return senha; }  set { senha = value; } }

        public string NomeContato
        {
            get { return nomeContato; } set { nomeContato = value; }}

        public string TelCadastro
        { get { return telCadastro; } set { telCadastro = value; } }
      
        
        


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

        public bool InsertCadastro ()
        {
            try
            {

                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                    conexao.Open();

                    string insert = " INSERT INTO usuario (NOME,EMAIL,CPF,TEL,SENHA) VALUES (@Nome,@Email,@Cpf,@Telefone,@Senha)";
                    string senhaHash = GerarHashsha256(Senha);

                    using MySqlCommand cmd = new MySqlCommand(insert, conexao);

                    cmd.Parameters.AddWithValue("@Nome",Nome);
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
                MessageBox.Show("Erro ao acessar banco de dados " + ex.Message) ;
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
                    cmd.Parameters.AddWithValue("@Senha",senhaHash);

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


        public bool CadastrarContato()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                    conexao.Open();

                    string Insert = "INSERT INTO contatos (NOME,TEL,ID_TEL) VALUES (@NomeContato,@TelCadastro, @Id)";
                    using MySqlCommand cmd = new MySqlCommand(Insert,conexao);

                    cmd.Parameters.AddWithValue("@NomeContato",NomeContato);
                    cmd.Parameters.AddWithValue("@TelCadastro", TelCadastro);
                    cmd.Parameters.AddWithValue("@Id",Id);
                    cmd.ExecuteNonQuery();

                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao abanco de dados" + ex.Message);
                return false;
            }
        }


        public DataTable DataGrid ()
        {
            try
            {
                using ( MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                    conexao.Open();

                    string select = "SELECT NOME,TEL FROM contatos";

                    using MySqlDataAdapter adapter = new MySqlDataAdapter(select, conexao);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados" + ex.Message);
                return null;
            }
        }

        public bool Excluir()
        {
            try
            {

                MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao);
                conexao.Open();

                string update = "DELETE FROM contatos WHERE TEl = @TelCadastro";

                MySqlCommand cmd = new MySqlCommand(update, conexao);
                cmd.Parameters.AddWithValue("@NomeContato", NomeContato);
                cmd.Parameters.AddWithValue("@TelCadastro", TelCadastro);
                

                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer exclusao no banco de dados " + ex.Message);
                return false;
            }
        }
        public bool Editar()
        {
            try
            {

                MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao);
                conexao.Open();

                string update = "UPDATE contatos SET NOME=@NomeContato,TEL=@TelCadastro WHERE TEl = @TelCadastro";

                MySqlCommand cmd = new MySqlCommand(update, conexao);
                cmd.Parameters.AddWithValue("@NomeContato", NomeContato);
                cmd.Parameters.AddWithValue("@TelCadastro", TelCadastro);


                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer exclusao no banco de dados " + ex.Message);
                return false;
            }
        }

        public DataTable BuscarContato()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                    conexao.Open();

                    string select = "SELECT NOME,TEL FROM contatos WHERE NOME LIKE @NomeContato";

                    using MySqlCommand cmd = new MySqlCommand(@select, conexao);
                    cmd.Parameters.AddWithValue("@NomeContato", "%"+NomeContato +"%");
                    
                    using MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar banco de dados " + ex.Message);
                return null;
            }
        }


    }
}
