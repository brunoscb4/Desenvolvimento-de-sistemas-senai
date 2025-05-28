using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_05.Programação
{
    internal class CadastroAgenda
    {

        private DateTime data;
        private TimeSpan hora;
        private string descricao;
        private int idUser = 1;
        private int id;
        public DateTime Data
        { get { return data; } set { data = value; } }

        public TimeSpan Hora
            { get { return hora; } set { hora = value; } }

        public string Descricao
            { get { return descricao; } set { descricao = value; } }
        public int IdUser
        { get { return idUser; } }
        public int Id
            { get { return id; } set { id = value; } }


        public bool Cadastro()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection (BancoConexao.Conexao))
                {
                    conexao.Open ();


                    string insert = "INSERT INTO registros (CALENDARIO,HORA,DESCRICAO,ID_USER) VALUES (@Data,@Hora,@Descricao,@IdUser)";

                    using (MySqlCommand cmd = new MySqlCommand(insert, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Data",Data);
                        cmd.Parameters.AddWithValue("@Hora",Hora);
                        cmd.Parameters.AddWithValue("@Descricao",Descricao);
                        cmd.Parameters.AddWithValue("@IdUser", IdUser);

                        cmd.ExecuteNonQuery();
                        return true;
                    }

                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aceesar banco de dados" + ex.Message);
               return false;
            }
        
        }


        public DataTable Datagrid()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                    conexao.Open();

                    string select = "SELECT ID,CALENDARIO,HORA,DESCRICAO FROM registros";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(select, conexao))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;

                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados " + ex.Message);
                throw;
            }
        }

        public bool Editar()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                    conexao.Open();

                    string update = " UPDATE registros SET CALENDARIO=@Data, HORA=@Hora,DESCRICAO=@Descricao WHERE ID=@Id";

                    using (MySqlCommand cmd = new MySqlCommand(update, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Data",Data);
                        cmd.Parameters.AddWithValue("@Hora", Hora);
                        cmd.Parameters.AddWithValue("@Descricao", Descricao);
                        cmd.Parameters.AddWithValue("@Id", Id);

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


        public bool Excluir()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                    conexao.Open();

                    string delete = " DELETE FROM  registros  WHERE ID=@Id";

                    using (MySqlCommand cmd = new MySqlCommand(delete, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Data", Data);
                        cmd.Parameters.AddWithValue("@Hora", Hora);
                        cmd.Parameters.AddWithValue("@Descricao", Descricao);
                        cmd.Parameters.AddWithValue("@Id", Id);

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

        public DataTable Buscar()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.Conexao))
                {
                    conexao.Open();

                    string select = "SELECT ID,CALENDARIO,HORA,DESCRICAO FROM registros WHERE CALENDARIO = @Data";

                    using MySqlCommand cmd = new MySqlCommand(@select, conexao);
                    cmd.Parameters.AddWithValue("@Data", Data.Date);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;

                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados " + ex.Message);
                throw;
            }
        }

    }
}
