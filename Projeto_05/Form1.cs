using Projeto_05.Programação;
using Projeto_05.Telas;

namespace Projeto_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Panel PanelLogin()
        { return panelLogin; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            NovoCadastro novoCadastro = new NovoCadastro();

            panelLogin.Controls.Clear();
            novoCadastro.Dock = DockStyle.Fill;
            panelLogin.Controls.Add(novoCadastro);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            Agenda agenda = new Agenda();
            try
            {
                if (textBoxEmail.Text != "" && textBoxSenha.Text != "")
                {
                    usuario.Email = textBoxEmail.Text;
                    usuario.Senha = textBoxSenha.Text;

                    if (usuario.VerificarLogin())
                    {
                        
                    panelLogin.Controls.Clear();
                    agenda.Dock = DockStyle.Fill;
                    panelLogin.Controls.Add(agenda);

                    }
                    

                    
                }
                else
                {
                    MessageBox.Show("Preencgha os campos corretamente..");
                    textBoxSenha.Clear();
                    textBoxSenha.Clear();

                    textBoxSenha.Focus();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
