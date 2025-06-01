using Projeto_03.programação;
using Projeto_03.Telas;

namespace Projeto_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Panel PanelLogin()
        { return panelLogin; }

        private void label4_Click(object sender, EventArgs e)
        {
            NovoCadastro cadastro = new NovoCadastro();

            panelLogin.Controls.Clear();
            cadastro.Dock = DockStyle.Fill;
            panelLogin.Controls.Add(cadastro);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                Tarefas tarefas = new Tarefas();
                CadastroTarefas c = new CadastroTarefas();
                if (textBoxEmail.Text != "" && textBoxSenha.Text != "")
                {
                    usuario.Email = textBoxEmail.Text;
                    usuario.Senha = textBoxSenha.Text;
                    c.Idtf = usuario.Chave(textBoxEmail.Text, textBoxSenha.Text);
                    if (usuario.Login())
                    {
                        panelLogin.Controls.Clear();
                        tarefas.Dock = DockStyle.Fill;
                        panelLogin.Controls.Add(tarefas);
                    }
                    else
                    {
                        MessageBox.Show("Email ou seha incorreto");
                        textBoxEmail.Clear();
                        textBoxSenha.Clear();
                         
                        textBoxEmail.Focus();
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
            catch (Exception ex)
            {

                MessageBox.Show("Cadastro não realizado " + ex.Message);
            }
        }
    }
}
