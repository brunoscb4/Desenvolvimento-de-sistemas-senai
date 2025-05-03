using SenaiGerenciadorProdutos.Progamação;
using SenaiGerenciadorProdutos.Resources.Paineis;

namespace SenaiGerenciadorProdutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.TopLevel = false;
            main.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(main);
            main.Show();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();

                login.Email = textUsuarioEmail.Text;
                login.NomeUsuario = textUsuarioEmail.Text;
                login.Senha = textSenha.Text;

                bool acessoLiberado = login.VerifarLiberacao();

                if (acessoLiberado)
                {
                    Pagina_inicial pagina_Inicial = new Pagina_inicial();
                    pagina_Inicial.Dock = DockStyle.Fill;
                    panel2.Controls.Clear();
                    panel2.Controls.Add(pagina_Inicial);
                    pagina_Inicial.Show();
                }
               
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show("Email, Usuario ou senha incoretos");
                
            }
        }
    }
}
