using Fenix_Shop.programação;
using Fenix_Shop.Telas;
using System.Data.SQLite;
using System.Runtime.InteropServices;


namespace Fenix_Shop
{

    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
           
            
        }
       
        public Panel PanelLg()
        {
            return PanelLogin;
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        public bool PanelInicioLogin()
        {
            panel1ControlerPanelLogin.Controls.Clear();
            PanelDeLoginPrincipal.Dock = DockStyle.Fill;
            panel1ControlerPanelLogin.Controls.Add(PanelDeLoginPrincipal);
            panel1ControlerPanelLogin.Size = new Size(646, 717);
            return true;
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
                textBox1Email.Focus();
                if (textBox1Email.Text != "" && textBox2Senha.Text != "")
                {
                    usuario.Email = textBox1Email.Text;
                    usuario.Senha = textBox2Senha.Text;
                    if (usuario.Status(textBox1Email.Text) == "ATIVO")
                    {
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
            CadastroUsuarioAdministrador cadastro = new CadastroUsuarioAdministrador();
            BancoSQLite.CriarBancoETabela();



            if (usuario.VerificarUsuario())
            {
                panel1ControlerPanelLogin.Size = new Size(800, 827);
                panel1ControlerPanelLogin.Controls.Clear();
                cadastro.Dock = DockStyle.Fill;
                panel1ControlerPanelLogin.Controls.Add(cadastro);
            }



        }



        private void parrotGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox2Senha.UseSystemPasswordChar == true)
            {
                  textBox2Senha.UseSystemPasswordChar = false;
            }
            else
            {               
                textBox2Senha.UseSystemPasswordChar = true;
            }

        }
    }
}

