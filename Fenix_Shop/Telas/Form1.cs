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

        private void Login_Click(object sender, EventArgs e)
        {
            Tela_Inicial tela_Inicial = new Tela_Inicial();
            PanelLogin.Controls.Clear();
            tela_Inicial.Dock = DockStyle.Fill;
            PanelLogin.Controls.Add(tela_Inicial);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CadastroNovoUsuario usuario = new CadastroNovoUsuario();
            BancoSQLite.CriarBancoETabela();
            Tela_Inicial tela_Inicial = new Tela_Inicial();

            
            if (usuario.VerificarUsuario())
            {
                PanelLogin.Controls.Clear();
                tela_Inicial.Dock = DockStyle.Fill;
                PanelLogin.Controls.Add(tela_Inicial);
            }
        }
    }
}
