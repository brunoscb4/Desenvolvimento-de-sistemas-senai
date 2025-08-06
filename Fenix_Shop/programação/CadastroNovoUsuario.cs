using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;

namespace Fenix_Shop.programação
{
    public class CadastroNovoUsuario
    {

        private string nome, email, senha, nivelusuario, cpf, nomeloja, telefone, statusUser;
        private byte[] imagem;
        public string Nome
        { get { return nome; } set { nome = value; } }
        public string Email
        { get { return email; } set { email = value; } }
        public string Senha
        { get { return senha; } set { senha = value; } }
        public string Nivelusuario
        { get { return nivelusuario; } set { nivelusuario = value; } }
        public string Cpf
        { get { return cpf; } set { cpf = value; } }
        public string NomeLoja
        { get { return nomeloja; } set { nomeloja = value; } }
        public string Telefone
        { get { return telefone; } set { telefone = value; } }
        public byte[] Imagem
        { get { return imagem; } set { imagem = value; } }

        public string StatusUser
        { get { return statusUser; } set { statusUser = value; } }



        public static string GerarHash(string senha)
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 100000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(32);

            byte[] hashBytes = new byte[48];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 32);

            return Convert.ToBase64String(hashBytes);

        }


        public static bool VerificarSenha(string SenhaDigitada, string HashArmazenado)
        {
            byte[] hashBytes = Convert.FromBase64String(HashArmazenado);
            byte[] salt = new byte[16];

            Array.Copy(hashBytes, 0, salt, 0, 16);


            var pbk2f2 = new Rfc2898DeriveBytes(SenhaDigitada, salt, 100000, HashAlgorithmName.SHA256);
            byte[] hash = pbk2f2.GetBytes(32);

            for (int i = 0; i < 32; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                    return false;
            }
            return true;
        }


        public bool CadastroUsuario()
        {
            try
            {
                using (var connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();
                    string SenhaHash = GerarHash(Senha);
                    string insert = "INSERT INTO Usuario (Nome,Email,Senha,NivelUsuario,Cpf,NomeLoja,Telefone,Foto,Status) VALUES (@Nome,@Email,@Senha,@Nivelusuario,@Cpf,@NomeLoja,@Telefone,@Imagem,@StatusUser)";

                    using (var cmd = new SQLiteCommand(insert, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nome", Nome);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Senha", SenhaHash);
                        cmd.Parameters.AddWithValue("@Nivelusuario", Nivelusuario);
                        cmd.Parameters.AddWithValue("@Cpf", Cpf);
                        cmd.Parameters.AddWithValue("@NomeLoja", NomeLoja);
                        cmd.Parameters.AddWithValue("@Telefone", Telefone);
                        cmd.Parameters.AddWithValue("@Imagem", Imagem);
                        cmd.Parameters.AddWithValue("@StatusUser",StatusUser);
                        cmd.ExecuteNonQuery();

                        return true;

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuario no banco de dados " + ex.Message);
                return false;
            }
        }


        public bool FazerLogin()
        {
            try
            {
                using (var connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();


                    string login = " SELECT Senha FROM Usuario WHERE Email = @Email";

                    using (var cmd = new SQLiteCommand(login, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", Email);
                        var resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            string hashSalvo = resultado.ToString();
                            return VerificarSenha(Senha, hashSalvo);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer a verificação no banco de dados " + ex.Message);
                return false;
            }
        }


        public bool VerificarUsuario()
        {
            try
            {
                using (var connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();
                    string adiministrador = "SELECT COUNT (*) FROM Usuario WHERE NivelUsuario =  'ADMINISTRADOR'";

                    using (var cmd = new SQLiteCommand(adiministrador, connection))
                    {
                        long resul = (long)cmd.ExecuteScalar();

                        if (resul == 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar usuario adimin no banco de dados " + ex.Message);
                return false;
            }

        }
        public string Status(string email)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    string status = @"SELECT Status FROM Usuario WHERE Email = @email";
                    using (SQLiteCommand cmd = new SQLiteCommand(status, connection))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            return resultado.ToString();
                        }
                        return "Usuario nao encontrado";
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao buscar status do usuario " + ex.Message);
                return null;
            }
        }





        public bool ExcluirUser(int Id)
        {
            try
            {
                using (SQLiteConnection connecion = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connecion.Open();

                    string delete = @"UPDATE Usuario SET Status = @StatusUser WHERE Id = @Id";

                    using (SQLiteCommand cmd = new SQLiteCommand(delete, connecion))
                    {
                        cmd.Parameters.AddWithValue("@StatusUser",StatusUser);
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cadastro " + ex.Message);
                return false;
            }   }
        }
}
