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
  ListaDeVendas list = new ListaDeVendas();
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxCodigoBuscar_Click(object sender, EventArgs e)
        {
            TextBoxIdBuscar.Select(0, 0);
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

            dataGridView1Vendas.Columns.Add("Id", "ID");
            dataGridView1Vendas.Columns.Add("Produto", "Produto");
            dataGridView1Vendas.Columns.Add("Quantidade", "Quantidade");
            dataGridView1Vendas.Columns.Add("Valor", "Valor");
            dataGridView1Vendas.Columns.Add("Foto", "Foto");
        }

        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                label11NomeDoProduto.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                label11NumeroDoId.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                label11ValorProduto.Text = Convert.ToDouble(dataGridViewProdutos.Rows[e.RowIndex].Cells["ValorDeVenda"].Value).ToString("C2");

                if (dataGridViewProdutos.Rows[e.RowIndex].Cells["Foto"].Value != DBNull.Value)
                {

                    byte[] imageBytes = (byte[])dataGridViewProdutos.Rows[e.RowIndex].Cells["Foto"].Value;


                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {

                        pictureBox1Vendas.Image = Image.FromStream(ms);
                    }
                }
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxQuantidade.Text))
                {
                    ListVendas listVendas = new ListVendas();
                  
                    listVendas.Id =Convert.ToInt32(label11NumeroDoId.Text);
                    listVendas.Produto = label11NomeDoProduto.Text;
                    listVendas.Quantidade =Convert.ToInt32(textBoxQuantidade.Text);
                    listVendas.Valor =  label11ValorProduto.Text;
                    using (var bmp = new Bitmap(pictureBox1Vendas.Image))
                    {
                        var converter = new ImageConverter();
                        byte[] imageBytes = (byte[])converter.ConvertTo(pictureBox1Vendas.Image, typeof(byte[]));
                        listVendas.Foto = imageBytes;
                    }

                    

                    list.add(listVendas);
                    list.ExibirVendas(dataGridView1Vendas);
                    
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
