using Fenix_Shop.programação;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fenix_Shop.Enums;
using System.Net.Mail;


namespace Fenix_Shop.Telas
{
    public partial class CadastroDeUsuario : UserControl
    {
        public CadastroDeUsuario()
        {
            InitializeComponent();

        }
        private static bool EmailValido(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void CadastroDeUsuario_Load(object sender, EventArgs e)
        {

            comboBoxNivelPermissão.DataSource = Enum.GetValues(typeof(NivelAcesso));
        }

        private void LimparCampo()
        {
            textBox1Nome.Clear();
            textBox2Email.Clear();
            textBox3Senha.Clear();
            textBox4ConfirmarSenha.Clear();
            TextBoxMasCpf.Clear();
            textBox5NomeLoja.Clear();
            TextBoxMaskTelefone.Clear();
            comboBoxNivelPermissão.Text = NivelAcesso.VENDEDOR.ToString();
            textBox1Nome.Focus();

        }
        private void Salvar_Click(object sender, EventArgs e)
        {
            CadastroNovoUsuario usuario = new CadastroNovoUsuario();

            try
            {
                if (textBox1Nome.Text != "" && textBox2Email.Text != "" && textBox3Senha.Text != "" && comboBoxNivelPermissão.Text != "")

                {


                    usuario.Nome = textBox1Nome.Text;
                    if (EmailValido(textBox2Email.Text))
                    {
                        usuario.Email = textBox2Email.Text;

                       

                         
                            if (textBox3Senha.Text.Equals(textBox4ConfirmarSenha.Text))
                            {
                                usuario.Senha = textBox3Senha.Text;
                                usuario.Cpf = TextBoxMasCpf.Text;
                                usuario.NomeLoja = textBox5NomeLoja.Text;
                                usuario.Telefone = TextBoxMaskTelefone.Text;
                                if (pictureBox1Usuario.Image != null)
                                {
                                    usuario.Imagem = CadastroProdutos.ConverterImagemParaBytes(pictureBox1Usuario.Image);

                                }
                                else
                                {
                                    usuario.Imagem = CadastroProdutos.ConverterImagemParaBytes(Properties.Resources.img_Fenix_Shop);
                                }
                                   
                            if (comboBoxNivelPermissão.Text.Equals("GERENTE"))
                                   {
                                        usuario.Nivelusuario = NivelAcesso.GERENTE.ToString();
                                   }
                                   else if (comboBoxNivelPermissão.Text.Equals("VENDEDOR"))
                                   {
                                        usuario.Nivelusuario = NivelAcesso.VENDEDOR.ToString();
                                   }
                                   else
                                   {
                                      MessageBox.Show("Selecione um nível de permissão válido.");
                                   }
                            {

                            }
                                usuario.CadastroUsuario();
                                MessageBox.Show("Cadastro realizado com suceso..");
                                var form1 = this.FindForm() as Form1;
                                form1.PanelInicioLogin();
                                LimparCampo();

                            }
                            else
                            {
                                MessageBox.Show("As senhas não conferem. Por favor, verifique e tente novamente.");
                                textBox3Senha.Clear();
                                textBox4ConfirmarSenha.Clear();
                                textBox3Senha.Focus();
                            }




                        

                        
                    }
                    else
                    {
                        MessageBox.Show("E-mail inválido. Por favor, insira um e-mail válido.");
                        textBox2Email.Clear();
                        textBox2Email.Focus();
                    }






                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente.");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao relizar cadastro " + ex.Message);
            }
        }


        private void pictureBox1Usuario_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Selecione uma imagem";
                open.Filter = "Imagens(*.jpg;*.jpeg;*.png;*.bmp|*.jpg;*.jpeg;*.png;*.bmp)";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1Usuario.Image = Image.FromFile(open.FileName);

                    pictureBox1Usuario.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
        }

        private void TextBoxMaskTelefone_Click(object sender, EventArgs e)
        {
            TextBoxMaskTelefone.Select(0, 0);
        }

        private void TextBoxMasCpf_Click(object sender, EventArgs e)
        {
            TextBoxMasCpf.Select(0, 0);
        }
    }
}
