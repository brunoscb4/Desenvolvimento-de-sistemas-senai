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
        ItensVendidos ItensVendidos = new ItensVendidos();
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
            dataGridView1Vendas.Columns.Add("Total", "Total");
        }

        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                label11NomeDoProduto.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                label11NumeroDoId.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                label11ValorProduto.Text = Convert.ToDouble(dataGridViewProdutos.Rows[e.RowIndex].Cells["ValorDeVenda"].Value).ToString("F2");

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
                if (!string.IsNullOrEmpty(textBoxQuantidade.Text) && int.TryParse(textBoxQuantidade.Text, out int quantidade) && quantidade > 0)
                {
                    double total = double.Parse(label11ValorProduto.Text) * quantidade;
                    
                    ListVendas listVendas = new ListVendas
                    {

                        Id = Convert.ToInt32(label11NumeroDoId.Text),
                        Produto = label11NomeDoProduto.Text,
                        Quantidade = Convert.ToInt32(textBoxQuantidade.Text),
                        Valor = decimal.Parse(label11ValorProduto.Text),
                        Total = decimal.Parse(total.ToString("F2")),

                    };
                    ItensVendidos.AddProduto(listVendas);
                    ItensVendidos.ExibirVendas(dataGridView1Vendas);
                    label11ValorTotalCompra.Text = ItensVendidos.TotalVenda().ToString("F2");
                    label11QuantidadeVendidos.Text = ItensVendidos.QuantidadeVendidos().ToString();
                    textBoxQuantidade.Clear();
                    textBoxQuantidade.Focus();
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void dataGridViewProdutos_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex >= 0 && dataGridViewProdutos != null)
            {
                DataGridViewRow row = dataGridViewProdutos.Rows[e.RowIndex];
                if (row.Cells["Nome"].Value != DBNull.Value && row.Cells["Id"].Value != DBNull.Value && row.Cells["ValorDeVenda"].Value != DBNull.Value)
                {


                    label11NomeDoProduto.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                    label11NumeroDoId.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    label11ValorProduto.Text = Convert.ToDouble(dataGridViewProdutos.Rows[e.RowIndex].Cells["ValorDeVenda"].Value).ToString("F2");

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
        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ItensVendidos.ObterLista().Any())
                {
                    MessageBox.Show("Nenhuma lista encontrada");
                    return;
                }

                ItensVendidos.ValorTotal = decimal.Parse(label11ValorTotalCompra.Text);

                if (ItensVendidos.CadastrarItensVendidos())
                {
                    dataGridView1Vendas.Rows.Clear();
                    label11ValorTotalCompra.Text = "0,00";
                    label11QuantidadeVendidos.Text = "0";
                    textBoxQuantidade.Clear();

                }
                else
                {
                    MessageBox.Show("Erro ao cadastara venda");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro inesperado: "+ex.Message);
            }
        }
    }
}
