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
                if (string.IsNullOrWhiteSpace(textBox1Nome.Text) && 
                    string.IsNullOrWhiteSpace(textBox2Email.Text)&&
                    string.IsNullOrWhiteSpace(textBox3Senha.Text)&&
                    string.IsNullOrWhiteSpace(textBox4ConfirmarSenha.Text)&&
                    string.IsNullOrWhiteSpace(TextBoxMasCpf.Text)&&
                    string.IsNullOrWhiteSpace(comboBoxNivelPermissão.Text))
                {
                    NivelAcesso escolhodo = (NivelAcesso)comboBoxNivelPermissão.SelectedItem;

                    usuario.Nome = textBox1Nome.Text;
                    usuario.Email = textBox2Email.Text;
                    usuario.Senha =  textBox3Senha.Text == textBox4ConfirmarSenha.Text ? textBox3Senha.Text: null;
                    usuario.Nivelusuario = escolhodo.ToString();

                    usuario.CadastroUsuario();
                    MessageBox.Show("Cadastro realizado com suceso..");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao relizar cadastro "+ex.Message);
            }
        }
    }
}
