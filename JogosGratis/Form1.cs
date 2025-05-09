using JogosGratis.Programa;
using System.Threading.Tasks;

namespace JogosGratis
{
    public partial class Form1 : Form
    {
        private ApiService apiService = new ApiService();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<ApiGame> jogos = await apiService.ObterJogosAsynk();
                dataGridView1.DataSource = jogos;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro so budcsr dsdos da api " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textId.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            textTitulo.Text = dataGridView1.CurrentRow.Cells["title"].Value.ToString();
            string imagem = dataGridView1.CurrentRow.Cells["Thumbnail"].Value.ToString();
            pictureBoxImagem.Load(imagem);
            
            textGenero.Text = dataGridView1.CurrentRow.Cells["genre"].Value.ToString();
            
            textPublicado.Text = dataGridView1.CurrentRow.Cells["publisher"].Value.ToString();
            textDesenvolvedor.Text = dataGridView1.CurrentRow.Cells["developer"].Value.ToString();

           
        }
    }
}
