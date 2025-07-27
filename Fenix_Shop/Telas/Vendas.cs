using Fenix_Shop.programação;
using ReaLTaiizor.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fenix_Shop.Telas
{
    public partial class Vendas : UserControl
    { 
        CadastroDeProduto cadastroDeProduto = new CadastroDeProduto();
        private Tela_Inicial telaInicial;
        private UsuarioLogado usuariologado;
        public Vendas(UsuarioLogado usuariologado, Tela_Inicial telaInicial) 
        {
            InitializeComponent();
            this.usuariologado = usuariologado;
            this.telaInicial = telaInicial;
        }
        public static string VerificaPagamento = "";
        ItensVendidos ItensVendidos = new ItensVendidos();
        public void CarregarProdutos()
        {
            var dt = cadastroDeProduto.ProdutosRegistradosVendas();

            if (dt != null)
            {
                dataGridViewProdutos.DataSource = dt;
                dataGridViewProdutos.Columns["VALOR"].DefaultCellStyle.Format = "C2";

            }
        }
        public  void AtualizarVenda()
        {
            if (VerificaPagamento.Equals("CARTAO") || VerificaPagamento.Equals("DINHEIRO") || VerificaPagamento.Equals("PIX"))
            {
                ItensVendidos.FormaPagamento = VerificaPagamento;
                ItensVendidos.ValorTotal = int.Parse(label11ValorTotalCompra.Text.Replace("R$", "").Replace(".", "").Replace(",", "").Trim());
                ItensVendidos.IdUser = usuariologado.Id;

                if (ItensVendidos.CadastrarItensVendidos())
                {
                    MessageBox.Show("Venda realizada com sucesso..");
                    cadastroDeProduto.ProdutosRegistradosVendas();
                    telaInicial.AtualizarVendas();
                    dataGridView1Vendas.Rows.Clear();
                    label11ValorTotalCompra.Text = "0,00";
                    label11QuantidadeVendidos.Text = "0";
                    textBoxQuantidade.Clear();
                    ItensVendidos.ApagarLista();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastara venda");
                }
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxCodigoBuscar_Click(object sender, EventArgs e)
        {
            TextBoxIdBuscar.Select(0, 0);
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            label11ValorProduto.Text = "0,00";
            label11ValorTotalCompra.Text = "0,00";
           
            CarregarProdutos();
            dataGridViewProdutos.RowTemplate.Height = 40;
            dataGridViewProdutos.Columns["FOTO"].Width = 40;

            if (dataGridViewProdutos.Columns["FOTO"] is DataGridViewImageColumn imageColumn)
            {
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }

            var index = dataGridView1Vendas.Columns.Add("Id", "ID");
            dataGridView1Vendas.Columns.Add("Produto", "PRODUTO");
            dataGridView1Vendas.Columns.Add("Quantidade", "UNIDADE");
            dataGridView1Vendas.Columns.Add("Valor", "VALOR");
            dataGridView1Vendas.Columns.Add("Total", "TOTAL");
            
             
            
        }
        public void AtualizarValores()
        {
                  dataGridView1Vendas.Columns["VALOR"].DefaultCellStyle.Format = "C2";
                dataGridView1Vendas.Columns["TOTAL"].DefaultCellStyle.Format = "C2";
        }
        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                label11NomeDoProduto.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                label11NumeroDoId.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                decimal precoReal =  Convert.ToDecimal(dataGridViewProdutos.Rows[e.RowIndex].Cells["ValorDeVenda"].Value);
              
                label11ValorProduto.Text = precoReal.ToString("C2", new CultureInfo("pt-BR"));

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
                    
                decimal valor = Convert.ToDecimal(label11ValorProduto.Text.Replace("R$","").Trim());

                decimal total = (valor * quantidade);

                ListVendas listVendas = new ListVendas
                {

                    Id = Convert.ToInt32(label11NumeroDoId.Text),
                    Produto = label11NomeDoProduto.Text,
                    Quantidade = Convert.ToInt32(textBoxQuantidade.Text),
                    Valor = valor,
                    Total = decimal.Parse(total.ToString("F2")),

                };
                ItensVendidos.AddProduto(listVendas);
                ItensVendidos.ExibirVendas(dataGridView1Vendas);
                AtualizarValores();
                label11ValorTotalCompra.Text = ItensVendidos.TotalVenda().ToString("C2");
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
                if (row.Cells["PRODUTO"].Value != DBNull.Value && row.Cells["CODIGO"].Value != DBNull.Value && row.Cells["VALOR"].Value != DBNull.Value)
                {


                    label11NomeDoProduto.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells["PRODUTO"].Value.ToString();
                    label11NumeroDoId.Text = dataGridViewProdutos.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                   decimal precoReal =  Convert.ToDecimal(dataGridViewProdutos.Rows[e.RowIndex].Cells["VALOR"].Value);
                    
                label11ValorProduto.Text = precoReal.ToString("C2", new CultureInfo("pt-BR"));

                    if (dataGridViewProdutos.Rows[e.RowIndex].Cells["Foto"].Value != DBNull.Value)
                    {

                        byte[] imageBytes = (byte[])dataGridViewProdutos.Rows[e.RowIndex].Cells["FOTO"].Value;


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
                else
                { Pagamentos pagamentos = new Pagamentos(this);

                    pagamentos.Anchor = AnchorStyles.Bottom;

                    PanelVendas.Controls.Add(pagamentos);
                    pagamentos.BringToFront();
                       

                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CadastroDeProduto produto = new CadastroDeProduto();
           int? idBuscar = null;
            if (!string.IsNullOrWhiteSpace(TextBoxIdBuscar.Text) && TextBoxIdBuscar.Text != null)
            {
               idBuscar =  int.Parse( TextBoxIdBuscar.Text);
            dataGridViewProdutos.DataSource = null;
            dataGridViewProdutos.DataSource =   produto.BuscarPorId(idBuscar);
            }
            else
            {
                dataGridViewProdutos.DataSource = null;
                dataGridViewProdutos.DataSource = produto.BuscarPorNome(textBoxBuscarNome.Text);
            }

            dataGridViewProdutos.RowTemplate.Height = 40;
            dataGridViewProdutos.Columns["Foto"].Width = 40;

            if (dataGridViewProdutos.Columns["Foto"] is DataGridViewImageColumn imageColumn)
            {
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }
    }
}
