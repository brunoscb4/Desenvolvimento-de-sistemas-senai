using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_05.Programação;

namespace Projeto_05.Telas
{
    public partial class NovoCadastro : UserControl
    {
        public NovoCadastro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            panelNovoCadastro.Controls.Clear();
            form1.PanelLogin().Dock = DockStyle.Fill;
            panelNovoCadastro.Controls.Add(form1.PanelLogin());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            try
            {
                if (textBoxNome.Text != "" && textBoxEmail.Text != "" && TextBoxMaskCpf.Text != "" && TextBoxMaskTelefone.Text != "" && textBoxSenha.Text != "")
                {

                    usuario.Nome = textBoxNome.Text;
                    usuario.Email = textBoxEmail.Text;
                    usuario.Cpf = TextBoxMaskCpf.Text;
                    usuario.Telefone = TextBoxMaskTelefone.Text;
                    usuario.Senha = textBoxSenha.Text;

                    usuario.InsertCadastro();

                    MessageBox.Show("Cadastro realizado...");

                    Form1 form1 = new Form1();

                    panelNovoCadastro.Controls.Clear();
                    form1.PanelLogin().Dock = DockStyle.Fill;
                    panelNovoCadastro.Controls.Add(form1.PanelLogin());

                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente...");

                    textBoxNome.Clear();
                    textBoxEmail.Clear();
                    TextBoxMaskCpf.Clear();
                    TextBoxMaskTelefone.Clear();
                    textBoxSenha.Clear();

                    textBoxNome.Focus();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
