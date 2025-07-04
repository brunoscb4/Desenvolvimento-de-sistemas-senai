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
    }
}
