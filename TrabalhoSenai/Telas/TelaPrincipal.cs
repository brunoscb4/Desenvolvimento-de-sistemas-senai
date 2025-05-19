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
    public partial class TelaPrincipal : UserControl
    {

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            Usuario usuario = new Usuario();



            PanelMain.Controls.Clear();
            cadastro.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(cadastro);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            panel2.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(panel2);


        }

        private void label8_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            PanelMain.Controls.Clear();
            produtos.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(produtos);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();

            PanelMain.Controls.Clear();
            vendas.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(vendas);
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            CadastroProduto produto = new CadastroProduto();

            DataTable dadosUsuario = usuario.SelectUsuario();

            if (dadosUsuario != null && dadosUsuario.Rows.Count > 0)
            {
                labelUsuario.Text = dadosUsuario.Rows[0]["USUARIO"].ToString();
                labelIdUser.Text = dadosUsuario.Rows[0]["ID"].ToString();
                
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
                labelUsuario.Text = "-";
                labelIdUser.Text = "-";
                produto.IdUsuario = "";
            }


        }
    }
}
