using Fenix_Shop.Enums;
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

namespace Fenix_Shop.Telas
{
    public partial class CadastroUsuarioAdministrador : UserControl
    {
        public CadastroUsuarioAdministrador()
        {
            InitializeComponent();
        }
        private void CadastroUsuarioAdministrador_Load(object sender, EventArgs e)
        {
            comboBoxNivelPermissão.DataSource = NivelAcesso.ADMINISTRADOR.ToString();
        }
        private void Salvar_Click(object sender, EventArgs e)
        {
            CadastroNovoUsuario usuario = new CadastroNovoUsuario();

            try
            {
                if (textBox1Nome.Text != "" && textBox2Email.Text != "" && textBox3Senha.Text != "" && comboBoxNivelPermissão.Text != "")

                {


                    usuario.Nome = textBox1Nome.Text;
                    usuario.Email = textBox2Email.Text;
                    usuario.Senha = textBox3Senha.Text.Equals(textBox4ConfirmarSenha.Text) ? textBox3Senha.Text : null;
                    if (comboBoxNivelPermissão.Text.Equals("ADMINISTRADOR"))
                    {
                        usuario.Nivelusuario = NivelAcesso.ADMINISTRADOR.ToString();
                    }

                    else
                    {
                        MessageBox.Show("Selecione um nível de permissão válido.");
                        return;
                    }
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

                    usuario.CadastroUsuario();
                    MessageBox.Show("Cadastro realizado com suceso..");



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

       
    }
}
