using Fenix_Shop.programação;
using Fenix_Shop.Telas;

namespace Fenix_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Login_Click_1(object sender, EventArgs e)
        {
            try
            {
                CadastroNovoUsuario usuario = new CadastroNovoUsuario();

                if (textBox1Email.Text != "" && textBox2Senha.Text != "")
                {
                    usuario.Email = textBox1Email.Text;
                    usuario.Senha = textBox2Senha.Text;

                    if (usuario.FazerLogin())
                    {
                        UsuarioLogado usuarioLogado = new UsuarioLogado();
                        usuarioLogado.Email = usuario.Email;
                        if (usuarioLogado.UsuarioAtivo())
                        {
                        Tela_Inicial tela_Inicial = new Tela_Inicial(usuarioLogado);
                        PanelLogin.Controls.Clear();
                        tela_Inicial.Dock = DockStyle.Fill;
                        PanelLogin.Controls.Add(tela_Inicial);
                        }
                        

                    }
                    else { MessageBox.Show("Email ou senha inválidos."); }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer login: " + ex.Message);

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CadastroNovoUsuario usuario = new CadastroNovoUsuario();
            BancoSQLite.CriarBancoETabela();
            CadastroDeUsuario cadastroDeUsuario = new CadastroDeUsuario();


            if (usuario.VerificarUsuario())
            {
                PanelDeLogin.Size = new Size(800, 827);
                PanelDeLogin.Controls.Clear();
                cadastroDeUsuario.Dock = DockStyle.Fill;
                PanelDeLogin.Controls.Add(cadastroDeUsuario);
            }

        }
    }
}
