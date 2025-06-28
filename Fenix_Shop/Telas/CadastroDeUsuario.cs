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


namespace Fenix_Shop.Telas
{
    public partial class CadastroDeUsuario : UserControl
    {
        public CadastroDeUsuario()
        {
            InitializeComponent();
        }

        private void CadastroDeUsuario_Load(object sender, EventArgs e)
        {

            comboBoxNivelPermissão.DataSource = Enum.GetValues(typeof(NivelAcesso));
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
                    usuario.Senha =  textBox3Senha.Text.Equals(textBox4ConfirmarSenha.Text)? textBox3Senha.Text: null;
                    if (comboBoxNivelPermissão.Text .Equals("ADMINISTRADOR"))
                    {
                        usuario.Nivelusuario = NivelAcesso.ADMINISTRADOR.ToString();
                    }
                    else if (comboBoxNivelPermissão.Text.Equals("GERENTE"))
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
                        return;
                    }
                    usuario.Cpf = TextBoxMasCpf.Text;
                    usuario.NomeLoja = textBox5NomeLoja.Text;
                    usuario.Telefone = TextBoxMaskTelefone.Text;

                    usuario.CadastroUsuario();
                    MessageBox.Show("Cadastro realizado com suceso..");
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
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente.");

                    textBox1Nome.Clear();
                    textBox2Email.Clear();
                    textBox3Senha.Clear();
                    textBox4ConfirmarSenha.Clear();
                    TextBoxMasCpf.Clear();
                    textBox5NomeLoja.Clear();
                    TextBoxMaskTelefone.Clear();
                    comboBoxNivelPermissão.Text = NivelAcesso.NENHUM.ToString();
                    textBox1Nome.Focus();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao relizar cadastro "+ex.Message);
            }
        }
    }
}
