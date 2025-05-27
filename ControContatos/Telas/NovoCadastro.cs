using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControContatos.Programação;

namespace ControContatos.Telas
{
    public partial class NovoCadastro : UserControl
    {
        public NovoCadastro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            Form1 form = new Form1();   

            if (textBoxNome.Text != "" && textBoxEmail.Text != "" && TextBoxMaskCpf.Text != ""  && TextBoxMaskTelefone.Text != "" && textBoxSenha.Text != "")
            {
            usuario.Nome = textBoxNome.Text;
            usuario.Email = textBoxEmail.Text;
            usuario.Cpf = TextBoxMaskCpf.Text;
            usuario.Telefone = TextBoxMaskTelefone.Text;
            usuario.Senha = textBoxSenha.Text;

            usuario.InsertCadastro();

                form.PanelLogin().Controls.Clear();
                panel1.Dock = DockStyle.Fill;
                form.PanelLogin().Controls.Add(panel1);



            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente ..");
                textBoxNome.Clear();
                textBoxEmail.Clear();
                TextBoxMaskCpf.Clear();
                TextBoxMaskTelefone.Clear();
                textBoxSenha.Clear();
                textBoxNome.Focus();


            }

            
        }
    }
}
