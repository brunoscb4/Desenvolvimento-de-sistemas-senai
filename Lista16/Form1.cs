namespace Lista16
{
    public partial class Form1 : Form
    {

        private int idfuncionario;
        private string nome;
        private string cpf;
        private DateTime data;
        private string cargo;
        private string setor;
        private float salario;
        private string sexo;

        private bool editar = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void radioButtonFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            try
            {
                funcionarios.IDFuncionario = Convert.ToInt32(textID.Text);
                funcionarios.Nome = textNome.Text;
                funcionarios.CPF = textCpf.Text;
                funcionarios.Data = DateTime.Parse(textData.Text);
                funcionarios.Cargo = textCargo.Text;
                funcionarios.Setor = textSetor.Text;
                funcionarios.Salario = float.Parse(textSalario.Text);
                if (radioButtonFeminino.Checked)
                {
                    funcionarios.Sexo = "Feminino";
                }
                else
                {
                    funcionarios.Sexo = "Masculino";
                }


                if (funcionarios.InserirFuncionario())
                {

                    dataGridView1.DataSource = funcionarios.ListarTodosFuncionarios();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi posivel realiar o cadastro " + ex.Message);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            editar = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 0 && e.ColumnIndex > 0)
            {


                idfuncionario = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["idFuncionario"].Value.ToString());
                nome = dataGridView1.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                cpf = dataGridView1.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                data = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["dataNascimento"].Value.ToString());
                cargo = dataGridView1.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
                setor = dataGridView1.Rows[e.RowIndex].Cells["setor"].Value.ToString();
                salario = float.Parse(dataGridView1.Rows[e.RowIndex].Cells["salario"].Value.ToString());
                sexo = dataGridView1.Rows[e.RowIndex].Cells["sexo"].Value.ToString();

                if (editar)
                {
                    textID.Text = idfuncionario.ToString();
                    textNome.Text = nome;
                    textCpf.Text = cpf;
                    textData.Text = data.ToString("yyyy-MM-dd");
                    textCargo.Text = cargo;
                    textSetor.Text = setor;
                    textSalario.Text = salario.ToString("F2");


                    if (sexo.Equals("Feminino"))
                    {
                        radioButtonFeminino.Checked = true;
                    }
                    else
                    {
                        radioButtonMasculino.Checked = true;
                    }

                }

            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            dataGridView1.DataSource = funcionarios.ListarTodosFuncionarios();

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            try
            {
                funcionarios.IDFuncionario = idfuncionario;
                funcionarios.Nome = nome;
                funcionarios.CPF = cpf;
                funcionarios.Data = data;
                funcionarios.Cargo = cargo;
                funcionarios.Setor = setor;
                funcionarios.Salario = salario;
                
                if (sexo.Equals("Feminino"))
                {
                    funcionarios.Sexo = sexo;
                }
                else if (sexo.Equals("Masculino"))
                {
                    funcionarios.Sexo = sexo;
                }


                funcionarios.ExcluirFuncionario();
                MessageBox.Show("Exluido com sucesso");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = funcionarios.ListarTodosFuncionarios();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao excluir funcionario");

            }


        }
    }
}
