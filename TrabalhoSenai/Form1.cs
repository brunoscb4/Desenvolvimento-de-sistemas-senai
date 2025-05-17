using TrabalhoSenai.Telas;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using TrabalhoSenai.Programas;

namespace TrabalhoSenai
{
    public partial class Form1 : Form
    {
        public Panel pubPanel
        {
            get { return panel2; }
        }
        public Form1()
        {
            InitializeComponent();

        }

        [DllImport("user32.dll")]

        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                if (textEmail.Text != "" && textSenha.Text != "")
                {
                    usuario.Email = textEmail.Text;
                    usuario.Senha = textSenha.Text;

                    if ( usuario.VerificarSenha())
                    {
                    TelaPrincipal principal = new TelaPrincipal();
                    panel3.Controls.Clear();
                    principal.Dock = DockStyle.Fill;
                    panel3.Controls.Add(principal);
                    }
                    else
                    {
                        textEmail.Clear();  
                        textSenha.Clear();
                        textEmail.Focus();
                        MessageBox.Show("Email ou Senha incorreto ...");
                    }
  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar Email e Senha" + ex.Message);
                
            }
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NovoCadastro novoCadastro = new NovoCadastro();
            panel3.Controls.Clear();
            novoCadastro.Dock = DockStyle.Fill;
            panel3.Controls.Add(novoCadastro);
        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
