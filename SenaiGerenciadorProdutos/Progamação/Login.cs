using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using SenaiGerenciadorProdutos.Resources.Paineis;

namespace SenaiGerenciadorProdutos.Progamação
{
    internal class Login

    {
        private string nome;
        private string email;
        private string cpf;
        private string nomeUsuario;
        private string senha;

        public string Nome
            { get { return nome; } set { nome = value; } }
        public string Email 
        {  get { return email; } set { email = value; } }
        public string Cpf
            { get { return cpf; } set { cpf = value; } }

        public string NomeUsuario
            { get { return nomeUsuario; } set { nomeUsuario = value; } }

        public string Senha
            { get { return senha; } set { senha = value; } }


        public bool Cadastro ()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(BancoConection.ConexaoBanco);
                conexao.Open();

                string insert = "INSERT INTO CadastroUsuario (NOME,EMAIL,CPF,USUARIO,SENHA) VALUE (@Nome,@Email,@Cpf,@NomeUsuario,@Senha)";
                MySqlCommand cmd = new MySqlCommand(insert, conexao);

                cmd.Parameters.AddWithValue("@Nome",Nome);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Cpf",Cpf);
                cmd.Parameters.AddWithValue("@NomeUsuario",NomeUsuario);
                cmd.Parameters.AddWithValue("@Senha",Senha);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado...");
                return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar banco "+ ex.Message);
                return false;
            }
        }

        public bool VerifarLiberacao()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(BancoConection.ConexaoBanco);
                conexao.Open();

                string verificar = "SELECT COUNT(*) FROM CadastroUsuario WHERE (EMAIL=@Email OR USUARIO = @NomeUsuario) AND SENHA=@Senha";

                MySqlCommand cmd = new MySqlCommand (verificar, conexao); 
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@NomeUsuario", NomeUsuario);
                cmd.Parameters.AddWithValue("@Senha", Senha);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

            
                   return count > 0;
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar no banco" + ex.Message);
                return false;   
            }
        }

    }
}
