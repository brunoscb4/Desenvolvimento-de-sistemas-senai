using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Data;
using Mysqlx.Crud;

namespace Lista16
{
    class Funcionarios
    {
        private int idfuncionario;
        private string nome;
        private string cpf;
        private DateTime data;
        private string cargo;
        private string setor;
        private float salario;
        private string sexo;

        public int IDFuncionario
        {
            get { return idfuncionario; }
            set { idfuncionario = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public DateTime Data
       
        {
            get { return data; }
            set { data = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }

        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public bool InserirFuncionario ()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(conexaoBanco.conexaoBancoDados);
                conexao.Open();

                string insert = "INSERT INTO cadastro (idFuncionario,nome,cpf,dataNascimento,cargo,setor,salario,sexo) VALUES (@IDFuncionario,@Nome,@CPF,@Data,@Cargo,@Setor,@Salario,@Sexo)";
                MySqlCommand cmd = new MySqlCommand(insert, conexao);
                cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                cmd.Parameters.AddWithValue("@Nome" , Nome);
                cmd.Parameters.AddWithValue("@CPF", CPF);
                cmd.Parameters.AddWithValue("@Data",Data);
                cmd.Parameters.AddWithValue("@Cargo", Cargo);
                cmd.Parameters.AddWithValue("@Setor", Setor);
                cmd.Parameters.AddWithValue("@Salario", Salario);
                cmd.Parameters.AddWithValue("@Sexo", Sexo);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastar no banco de dados "+ ex.Message);
                return false;
            }
        }

        public DataTable ListarTodosFuncionarios ()
        {
            try
            {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco.conexaoBancoDados);
            conexao.Open();
             
            string select = " SELECT  idFuncionario,nome,cpf,dataNascimento,cargo,setor,salario,sexo FROM cadastro " ;
            MySqlDataAdapter adapter = new MySqlDataAdapter(select, conexao);
            DataTable datatable = new DataTable();

            adapter.Fill(datatable);

            return datatable;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar tabela banco" + ex.Message);
                return null !;
            }
            
        }

        public bool AtualizarFuncionario ()
        {
           

            try
            {
                MySqlConnection conexao = new MySqlConnection(conexaoBanco.conexaoBancoDados);
                conexao.Open();

                string update = "UPDATE cadasatro SET idFuncionari=IDFuncionario,nome=Nome,cpf=CPF,data=Data,cargo=Cargo,setor=Setor,salario=Salario,sexo=Sexo WHERE cpf = CPF ";

                MySqlCommand cmd = new MySqlCommand(update, conexao);
                cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@CPF", CPF);
                cmd.Parameters.AddWithValue("@Data", Data);
                cmd.Parameters.AddWithValue("@Cargo", Cargo);
                cmd.Parameters.AddWithValue("@Setor", Setor);
                cmd.Parameters.AddWithValue("@Salario", Salario);
                cmd.Parameters.AddWithValue("@Sexo", Sexo);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar funciomnario" + ex.Message);
                return false;
            }
        }

        public bool ExcluirFuncionario ()
        {

            try
            {
                MySqlConnection conexao = new MySqlConnection(conexaoBanco.conexaoBancoDados);
                conexao.Open();

                string update = "DELETE FROM cadastro WHERE cpf = @CPF ";

                MySqlCommand cmd = new MySqlCommand(update, conexao);
                cmd.Parameters.AddWithValue("@IDFuncionario", IDFuncionario);
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@CPF", CPF);
                cmd.Parameters.AddWithValue("@Data", Data);
                cmd.Parameters.AddWithValue("@Cargo", Cargo);
                cmd.Parameters.AddWithValue("@Setor", Setor);
                cmd.Parameters.AddWithValue("@Salario", Salario);
                cmd.Parameters.AddWithValue("@Sexo", Sexo);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aceessar banco");
                return false;
            }
        }
    }
}