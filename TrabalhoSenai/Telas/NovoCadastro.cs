using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoSenai.Programas;

namespace TrabalhoSenai.Telas
{
    public partial class NovoCadastro : UserControl
    {
        public NovoCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void NovoCadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();

                if (textNome.Text != "" && textEmail.Text != "" && textCpf.Text != "" && textNomeUsuario.Text != "" && textTelefone.Text != "" && textSenha.Text == textConfSenha.Text)
                {
                    usuario.Nome = textNome.Text;
                    usuario.Email = textEmail.Text;
                    usuario.Cpf = textCpf.Text;
                    usuario.Usuario1 = textNomeUsuario.Text;
                    usuario.Telefone = textTelefone.Text;
                    usuario.Senha = textSenha.Text;

                    usuario.NovoCadastro();

                    MessageBox.Show("Cadastro Realzado...");

                     Form1 form1 = new Form1();
                     this.Controls.Clear();
                     form1.pubPanel.Dock = DockStyle.Fill;
                     this.Controls.Add(form1.pubPanel);
                }
                else
                {
                    MessageBox.Show("Prencha os campos corretamente ...");
                }

           
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possivel realizar o cadsatro" + ex.Message);
;            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Controls.Clear();
            form1.pubPanel.Dock = DockStyle.Fill;
            this.Controls.Add(form1.pubPanel);
        }
    }
}
