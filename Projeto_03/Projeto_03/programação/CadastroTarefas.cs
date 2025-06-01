using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_03.programação
{
    internal class CadastroTarefas
    {
        private int id;
        private string descricao;
        private DateTime data;
        private string status;
        private int idtf = 1;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descricao
        { get  { return descricao; } set { descricao = value; } }

        public DateTime Data
            { get { return data; } set { data = value; } }

        public string Status
            { get { return status; } set { status = value; } }

        public int Idtf
        { get { return idtf; } set { idtf = value; } }


        public bool tarefasCadastradas()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.conexao))
                {
                    conexao.Open();

                    string cadastro = "INSERT INTO cadastrotarefas(DESCRICAO,DATACONCLUSAO,SITUACAO,ID_TAREFA ) VALUES (@Descricao,@Data,@Status,@Idtf)";

                    using (MySqlCommand cmd = new MySqlCommand(cadastro,conexao))   
                    {
                        cmd.Parameters.AddWithValue("@Descricao",Descricao);
                        cmd.Parameters.AddWithValue("Data",Data);
                        cmd.Parameters.AddWithValue("@Status",Status);
                        cmd.Parameters.AddWithValue("@Idtf",idtf);

                        cmd.ExecuteNonQuery();
                        return true;
                    
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados no  banco de dados " + ex.Message);
                return false;
            }
        }


        public DataTable Select()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.conexao))
                {
                    conexao.Open();

                    string select = "SELECT ID,DESCRICAO,DATACONCLUSAO,SITUACAO FROM cadastrotarefas  WHERE ID_TAREFA = @Idtf";

                    using (MySqlCommand cmd = new MySqlCommand(select,conexao))
                    {
                        cmd.Parameters.AddWithValue("@Idtf",Idtf);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }

                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("Erro ao acessar banco de dados");
                return null;
            }
        }
        
        public bool Editar()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.conexao))
                {
                    conexao.Open();

                    string updete = "UPDATE cadastrotarefas SET ID=@Id,DESCRICAO=@Descricao,DATACONCLUSAO=@Data,SITUACAO=@Status WHERE ID=@Id";

                    using (MySqlCommand cmd = new MySqlCommand (updete,conexao))
                    {
                        cmd.Parameters.AddWithValue("@Id",Id);
                        cmd.Parameters.AddWithValue("@Descricao",Descricao);
                        cmd.Parameters.AddWithValue("@Data",Data);
                        cmd.Parameters.AddWithValue("@Status",Status);
                        cmd.ExecuteNonQuery();
                        return true;

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar banco"+ ex.Message);
                return false;
            }
        }

        public bool Excluir()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(BancoConexao.conexao))
                {
                    conexao.Open();

                    string delete = "DELETE FROM cadastrotarefas  WHERE ID=@Id";

                    using (MySqlCommand cmd = new MySqlCommand(delete, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.Parameters.AddWithValue("@Descricao", Descricao);
                        cmd.Parameters.AddWithValue("@Data", Data);
                        cmd.Parameters.AddWithValue("@Status", Status);
                        cmd.ExecuteNonQuery();
                        return true;

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir banco" + ex.Message);
                return false;
            }
        }


    }
}
