
using MySql.Data.MySqlClient;
using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace Cadastro
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {


            try
            {
                string nome = textNome.Text;
                string data = textData.Text;
                string curso = textCurso.Text;
                string telefone = textTelefone.Text;

                string conexaoBanco = "Server = localhost; database = CadastroAluno; Uid = root; Pwd = '';";
                MySqlConnection conexao = new MySqlConnection(conexaoBanco);
                conexao.Open();

                string Query = " INSERT INTO cadastro  (nome, datas, curso, telefone) values (@nome, @datas, @curso ,@telefone)";

                using (MySqlCommand cmd = new MySqlCommand(Query, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", textNome.Text);
                    cmd.Parameters.AddWithValue("@datas", textData.Text);
                    cmd.Parameters.AddWithValue("@curso", textCurso.Text);
                    cmd.Parameters.AddWithValue("@telefone", textTelefone.Text);

                    cmd.ExecuteNonQuery();
                }
                ;

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Não foi possivel realizar o cadastro " + ex.Message, "Erro - Cadastro não realizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
