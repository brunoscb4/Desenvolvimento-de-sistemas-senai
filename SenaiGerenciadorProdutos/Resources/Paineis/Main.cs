using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenaiGerenciadorProdutos.Progamação;

namespace SenaiGerenciadorProdutos.Resources.Paineis
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();

                login.Nome = textNome.Text;
                login.Email = textEmail.Text;
                login.Cpf =TextCpf.Text;
                login.NomeUsuario = textUsuario.Text;
                login.Senha = textSenha.Text;

                if (textNome.Text != "" && textEmail.Text != "" && TextCpf.Text != "" && textUsuario.Text != "" && textSenha.Text != "")
                {
                    login.Cadastro();
                    textNome.Clear();
                    textEmail.Clear();
                    TextCpf.Clear();
                    textUsuario.Clear();
                    textSenha.Clear();
                    textNome.Focus();                   
                   
                  
                }
                else
                {
                    MessageBox.Show("Prencha os campos corretamente ...");
                    textNome.Clear();
                    textEmail.Clear();
                    TextCpf.Clear();
                    textUsuario.Clear();
                    textSenha.Clear();
                    textNome.Focus();
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cadastro não realizado" + ex.Message);
                
            }
        }
    }
}
