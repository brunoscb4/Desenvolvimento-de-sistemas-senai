using ControContatos.Programação;
using ControContatos.Telas;

namespace ControContatos
{
    public partial class Form1 : Form
    {
        public Panel PanelLogin()
        { return panelLogin; }
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

        private void label6_Click(object sender, EventArgs e)
        {
            NovoCadastro novoCadastro = new NovoCadastro();

            panelLogin.Controls.Clear();
            novoCadastro.Dock = DockStyle.Fill;
            panelLogin.Controls.Add(novoCadastro);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (textBoxEmail.Text != "" && textBoxSenha.Text != "")
            {
            usuario.Email = textBoxEmail.Text;
            usuario.Senha = textBoxSenha.Text;

            if (usuario.VerificarLogin())
            {
                TelaMain telaMain = new TelaMain();

                panelLogin.Controls.Clear();

                telaMain.panelMain().Dock = DockStyle.Fill;
                panelLogin.Controls.Add(telaMain.panelMain());
            }
            else
                {
                    MessageBox.Show("Senha incorreta ..");
                }

            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente..");

                textBoxEmail.Clear();
                textBoxSenha.Clear();
                textBoxEmail.Focus();
                   
            }
            
        }
    }
}
