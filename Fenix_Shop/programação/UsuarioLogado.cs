using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fenix_Shop.programação
{
    public class UsuarioLogado
    {

        private string nome, email, nivelusuario,nomeLoja;
        private  int id;
        private byte[] foto;
        public  int Id
        { get { return id; } set { id = value; } }
        public string Nome
        { get { return nome; } set { nome = value; } }
        public string Email
        { get { return email; } set { email = value; } }
        public string Nivelusuario
        { get { return nivelusuario; } set { nivelusuario = value; } }
        public string NomeLoja
        { get { return nomeLoja; } set { nomeLoja = value; } }
        public byte[] Foto
        { get { return foto; } set { foto = value; } }

        public bool UsuarioAtivo()
        {
            try
            {
                using(var connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    string Logado = "SELECT Id,Nome,Email,NivelUsuario,NomeLoja,Foto FROM usuario WHERE Email = @Email";
                    using (var cmd = new SQLiteCommand(Logado, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Id = Convert.ToInt32(reader["Id"]);
                                nome = reader["Nome"].ToString();
                                email = reader["Email"].ToString();
                                nivelusuario = reader["NivelUsuario"].ToString();
                                nomeLoja = reader["NomeLoja"].ToString();
                                foto = reader["Foto"] as byte[]; 
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public DataTable Usuarios()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(BancoSQLite.ConexaoSQlite))
                {
                    connection.Open();

                    string select = @"SELECT Id AS CODIGO, Nome AS NOME , NivelUsuario AS NIVEL , Telefone AS TELEFONE, DataDeCadastro AS ENTRADA FROM Usuario WHERE Status = 'ATIVO'";

                    using (SQLiteCommand cmd = new SQLiteCommand(select, connection))
                    {
                        DataTable dt = new DataTable();
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                            return dt;
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao buscar usuarios " + ex.Message);
                return null;
            }


        }


        
    }


   
}
