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
    public partial class Vendas : UserControl
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxCodigoBuscar_Click(object sender, EventArgs e)
        {
            TextBoxCodigoBuscar.Select(0, 0);
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            CadastroDeProduto cadastroDeProduto = new CadastroDeProduto();
            dataGridViewProdutos.DataSource = cadastroDeProduto.ProdutosRegistradosVendas();
            dataGridViewProdutos.RowTemplate.Height = 40;
            dataGridViewProdutos.Columns["Foto"].Width = 40;

            if (dataGridViewProdutos.Columns["Foto"] is DataGridViewImageColumn imageColumn)
            {
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch; 
            }
        }
    }
}
