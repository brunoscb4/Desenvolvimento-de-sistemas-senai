namespace CadastroProdutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lista lista = new Lista();
        private void Adicionar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();


            string categoria = textCategoria.Text;
            string nome = textNome.Text;
            double preco = Convert.ToInt32(textPreco.Text);

            if (categoria != "" && nome != "" && preco != 0)
            {
                cadastro.Categoria = textCategoria.Text;
                cadastro.Nome = textNome.Text;
                cadastro.Preco = Convert.ToInt32(textPreco.Text);
                lista.Add(cadastro);

                textCategoria.Clear();
                textNome.Clear();
                textPreco.Clear();

                TextRealizado.Text = "Cadastro realizado";
            }
            else
            {
                TextRealizado.Text = " Cadastro não realizado";
            }
        }

        private void Listar_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista.ListarCadastrados();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buscar = textBuscar.Text;
            if (lista.ListarCadastrados().Equals(buscar))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista.ListarCadastrados();
            }
            else { dataGridView1.DataSource = null; }
        }
    }
}
