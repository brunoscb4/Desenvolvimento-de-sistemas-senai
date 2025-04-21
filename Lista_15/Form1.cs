using System.Data;
using MySql.Data.MySqlClient;

namespace Lista_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool editar = false;


        private void Gavar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textID.Text != "" && textSetor.Text != "")
                {
                    Setor setor = new Setor();
                    setor.ID = Convert.ToInt32(textID.Text);
                    setor.NameSetor = textSetor.Text;

                    if (setor.inserirSetor())
                    {

                        MessageBox.Show($"Cadastro realizado com sucesso setor {setor.NameSetor}");
                        textID.Clear();
                        textSetor.Clear();
                        textID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel realizar cadastro !");
                        textID.Clear();
                        textSetor.Clear();
                        textID.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Prencha os campos corretamente !");
                    textID.Clear();
                    textSetor.Clear();
                    textID.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar setor " + ex.Message);
            }
        }



        private void Listar_Click(object sender, EventArgs e)
        {
            try
            {
                Setor setor = new Setor();

                DataTable setores = new DataTable();
                if (setor != null)
                {
                    dataGridView1.DataSource = setor.ListarTodosSetrores();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar setores" + ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                Setor setor = new Setor();
                DataTable setores = new DataTable();

                setor.Buscar = textNomeSetor.Text.Trim();
                dataGridView1.DataSource = null;
                if (setor != null)
                {
                    dataGridView1.DataSource = setor.ListarSetorPorNome();

                }
                else
                {
                    MessageBox.Show("Setor não encontrado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao buscar o setor " + ex.Message);
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Setor setor1 = new Setor();

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string nome = dataGridView1.Rows[e.RowIndex].Cells["nomeSetor"].Value.ToString();
                    string id = dataGridView1.Rows[e.RowIndex].Cells["idUsuario"].Value.ToString();
                    int idtabela = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());

                    if (editar)
                    {
                        textSetor.Text = nome;
                        textID.Text = id; 
                        setor1.IDBanco = idtabela;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel atualizar setor " + ex.Message);
            }


        }


        private void Editar_Click(object sender, EventArgs e)
        {
            editar = true;

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Setor setor = new Setor();
            try
            {
                setor.ID = Convert.ToInt32( textID.Text);
                setor.NameSetor = textSetor.Text;
                setor.IDBanco = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                if (textSetor.Text != "" && textID.Text != "")
                {
                    setor.AtualizarSetor();
                    MessageBox.Show("Atualizado com sucesso");
                    textID.Clear();
                    textSetor.Clear();
                    textID.Focus();
                }
                else
                {
                    MessageBox.Show("Não foi possiavel atualizar");
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.Message);
            }
        }
    }
}
