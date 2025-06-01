using Projeto_03.programação;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03.Telas
{
    public partial class NovoCadastro : UserControl
    {
        public NovoCadastro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            panelCadastro.Controls.Clear();
            form.PanelLogin().Dock = DockStyle.Fill;
            panelCadastro.Controls.Add(form.PanelLogin());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            Form1 form = new Form1();

            try
            {
                
                if (textBoxNome.Text != "" && textBoxEmail.Text != "" && textBoxNomeUser.Text != "" && TextBoxMaskCpf.Text != "" && TextBoxTelefone.Text != "" && textBoxSenha.Text != "")
                {
                    usuario.Nome = textBoxNome.Text;
                    usuario.Email = textBoxEmail.Text;
                    usuario.Usuario1 = textBoxNomeUser.Text;
                    usuario.Cpf = TextBoxMaskCpf.Text;
                    usuario.Telefone = TextBoxTelefone.Text;
                    usuario.Senha = textBoxSenha.Text;

                    usuario.CadastroNovo();

                    MessageBox.Show("Cadastro realizado..");
                    panelCadastro.Controls.Clear();
                    form.PanelLogin().Dock = DockStyle.Fill;
                    panelCadastro.Controls.Add(form.PanelLogin());
                }
                else 
                {
                    MessageBox.Show("prencha os campos corretamente");

                    textBoxNome.Clear();
                    textBoxEmail.Clear();
                    textBoxNomeUser.Clear();
                    TextBoxMaskCpf.Clear();
                    TextBoxTelefone.Clear();
                    textBoxSenha.Clear();

                    textBoxNome.Focus();

                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar cadasroo - cadastro não realizado" + ex.Message);
               
            }
        }
    }
}
