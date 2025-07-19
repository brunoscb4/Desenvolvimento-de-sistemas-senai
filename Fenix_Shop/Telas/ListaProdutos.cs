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
    public partial class ListaProdutos : UserControl
    {
        public ListaProdutos()
        {
            InitializeComponent();
        }

        private void ListaProdutos_Load(object sender, EventArgs e)
        {
            CadastroDeProduto produto = new CadastroDeProduto();

            dataGridView1.DataSource = produto.ProdutosRegistrados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroDeProduto produto = new CadastroDeProduto();
            int? idBuscar = null;
            if (!string.IsNullOrWhiteSpace(TextBoxCodigoBuscar.Text) && TextBoxCodigoBuscar.Text != null)
            {
                idBuscar = int.Parse( TextBoxCodigoBuscar.Text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = produto.ProdutosRegisBuscaId(idBuscar);
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = produto.ProdutosRegisBuscaNome(textBoxBuscarNome.Text);
            }
        }

        private void TextBoxCodigoBuscar_Click(object sender, EventArgs e)
        {
            TextBoxCodigoBuscar.SelectionStart = TextBoxCodigoBuscar.Text.Length;
            TextBoxCodigoBuscar.SelectionLength = 0;
            TextBoxCodigoBuscar.Focus();
        }
    }
}
