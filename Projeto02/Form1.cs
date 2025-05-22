using Projeto02.Programas;
using Projeto02.Telas;

namespace Projeto02
{
    public partial class Form1 : Form
    {
        public Panel panelr02
        {
            get { return panel02; }
        }
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
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            NovoCadastro novoCadastro = new NovoCadastro();
            panel02.Controls.Clear();
            novoCadastro.Dock = DockStyle.Fill;
            panel02.Controls.Add(novoCadastro);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Main main = new Main();
                Usuario usuario = new Usuario();

                if (textBoxEmail.Text != "" && textBoxSenha.Text != "")
                {
                    
                    usuario.Email = textBoxEmail.Text;
                    usuario.Senha = textBoxSenha.Text;
                     
                    if( usuario.VerificarLogin())
                        
                    {
                       
                        panel02.Controls.Clear();
                        main.Dock = DockStyle.Fill;
                        panel02.Controls.Add(main);

                    }
                   
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar a informação digitada" + ex.Message);
                
            }
            
        }
    }
}
