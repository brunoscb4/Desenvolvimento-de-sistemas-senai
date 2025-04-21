using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Lista_15
{
    internal class Setor
    {
        private int id;
        private string nameSetor;
        private string buscar;
        private int idBanco;

        public int ID { 
            get {  return id; }
            set { id = value; }
        }

        public string NameSetor 
        { 
            get { return nameSetor; }
            set { nameSetor = value; }
        }

        public string Buscar
        {
            get { return buscar; }
            set { buscar = value; }
        }

        public int IDBanco
        {
            get { return idBanco; }
            set { idBanco = value; }
                
        }

        public bool inserirSetor ()
        {
            try
            {
                MySqlConnection mysqlConexao = new MySqlConnection(ConexaoBanco.conexaoBancoDados);
                mysqlConexao.Open();


                string insert = " INSERT INTO setor (idUsuario, NomeSetor) VALUES(@id , @nomeSetor) ";

                MySqlCommand cmd = new MySqlCommand(insert , mysqlConexao);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue ("@NomeSetor", NameSetor);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar " + ex.Message);
                return false;
            }
        }

        public DataTable ListarTodosSetrores()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(ConexaoBanco.conexaoBancoDados);
                mySqlConnection.Open();

                string select = "SELECT * FROM setor";

                MySqlDataAdapter adapter = new MySqlDataAdapter(select , mySqlConnection);
                
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao buscar a lista no banco !" + ex.Message);
                return null!;
            }
        }

        public DataTable ListarSetorPorNome()
        {
          
            try
            {
                
                MySqlConnection mySqlConnection = new MySqlConnection(ConexaoBanco.conexaoBancoDados);
                mySqlConnection.Open();

              
                string select = "SELECT * FROM setor WHERE nomeSetor LIKE @Buscar";
                MySqlCommand cmd = new MySqlCommand(select, mySqlConnection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@Buscar", "%" +Buscar +"%");

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao buscar a lista no banco !" + ex.Message);
                return null!;
            }
        }

        public bool AtualizarSetor()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(ConexaoBanco.conexaoBancoDados);
                mySqlConnection.Open();

                string atualizar = "UPDATE setor SET NomeSetor = @NameSetor , idUsuario = @ID WHERE id = @IDBanco";

                MySqlCommand cmd = new MySqlCommand(atualizar, mySqlConnection);
                cmd.Parameters.AddWithValue("@NameSetor", NameSetor);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@IDBanco", IDBanco);

                cmd.ExecuteNonQuery();

                  
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possivel atualizar o setor " + ex.Message );
                return false;
            }
        }

    }
}
