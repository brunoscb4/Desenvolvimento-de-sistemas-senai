using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto02.Programas;

namespace Projeto02.Telas
{
    public partial class NovoCadastro : UserControl
    {
        public NovoCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNome.Text != "" && textBoxEmail.Text != "" && textBoxUsuario.Text != "" && textBoxSenhaUser.Text != "" && TextBoxMaskCpf.Text != "" && TextBoxMaskTelefone.Text != "") 
                {
                    Usuario usuario = new Usuario();

                    usuario.Nome = textBoxNome.Text;
                    usuario.Email = textBoxEmail.Text;
                    usuario.Usuario1 = textBoxUsuario.Text;
                    usuario.Senha = textBoxSenhaUser.Text;
                    usuario.Cpf = TextBoxMaskCpf.Text;
                    usuario.Tefelofe = TextBoxMaskTelefone.Text;

                    usuario.CadastroUsuario();

                    MessageBox.Show("Cadastro realizado com sucesso..");

                    Form1 form = new Form1();
                    this.Controls.Clear();
                    form.panelr02.Dock = DockStyle.Fill;
                    this.Controls.Add(form.panelr02);

                }
                
                else
                {
                    MessageBox.Show("Prencha os campos corretamente..");
                    textBoxNome.Clear();
                    textBoxNome.Clear();
                    textBoxUsuario.Clear();
                    textBoxSenhaUser.Clear();
                    TextBoxMaskCpf.Clear();
                    TextBoxMaskTelefone.Clear();
                    textBoxNome.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errro ao cadastrar novo usuario " + ex.Message);
                throw;
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Controls.Clear();
            form.panelr02.Dock = DockStyle.Fill;
            this.Controls.Add(form.panelr02);
        }
    }
}
