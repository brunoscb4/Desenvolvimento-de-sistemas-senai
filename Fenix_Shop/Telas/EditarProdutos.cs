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
    public partial class EditarProdutos : UserControl
    {
        private CadastroDeProduto cadastro;
        public EditarProdutos(CadastroDeProduto cadastro)
        {
            InitializeComponent();
            this.cadastro = cadastro;
        }
        public static byte[] ConverterImagemParaBytes(Image imagem)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (Bitmap bpm = new Bitmap(imagem))
                
                    {
                    bpm.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                return ms.ToArray();
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                cadastro.Nome = textBox1Nome.Text;
                cadastro.Categoria = textBox2Categoria.Text;
                cadastro.Marca = textBox3Marca.Text;
                cadastro.Descricao = TextBoxDescricao.Text;
                cadastro.ValorCusto = int.Parse(TextBoxCusto.Text.Replace("R$", "").Replace(".", "").Replace(",", "").Trim());
                cadastro.ValorVenda = int.Parse(TextBoxVenda.Text.Replace("R$", "").Replace(".", "").Replace(",", "").Trim());
                cadastro.CodigoBarras = TextBoxCodigoBarras.Text;
                cadastro.Sku = TextBoxSku.Text;
                cadastro.EsMinimo = int.Parse(TextBoxEstoqueMinimo.Text);
                int estoqueAtual = int.Parse(TextBoxEstoque.Text);
                if (cadastro.Estoque > estoqueAtual)
                {
                    cadastro.Estoque = cadastro.Estoque -= estoqueAtual;

                }
                else if (cadastro.Estoque < estoqueAtual)
                {
                    cadastro.Estoque = estoqueAtual -= cadastro.Estoque;
                    cadastro.MovimentacaoEstoque = "ENTRADA";
                }
                else if (estoqueAtual == 0)
                {
                    cadastro.Estoque = cadastro.Estoque -= cadastro.Estoque;
                    cadastro.MovimentacaoEstoque = "SAIDA";
                }
                if (pictureBoxCadastroProduto.Image != null)
                {
                    
                    cadastro.Imagem = ConverterImagemParaBytes(pictureBoxCadastroProduto.Image  );
                }
                cadastro.atualizarProduto();
                ListaProdutos listaPr = new ListaProdutos();
                PanelEditarProdutos.Controls.Clear();
                listaPr.Dock = DockStyle.Fill;
                PanelEditarProdutos.Controls.Add(listaPr);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro editar " + ex.Message);
            }
        }


        private void EditarProdutos_Load(object sender, EventArgs e)
        {
            try
            {


                textBox1Nome.Text = cadastro.Nome;
                textBox2Categoria.Text = cadastro.Categoria;
                textBox3Marca.Text = cadastro.Marca;
                TextBoxDescricao.Text = cadastro.Descricao;
                TextBoxCusto.Text = (cadastro.ValorCusto / 100.0m).ToString("C2");
                TextBoxVenda.Text = (cadastro.ValorVenda / 100.0m).ToString("C2");
                TextBoxEstoque.Text = cadastro.Estoque.ToString();
                TextBoxCodigoBarras.Text = cadastro.CodigoBarras;
                TextBoxSku.Text = cadastro.Sku;
                TextBoxEstoqueMinimo.Text  = cadastro.EsMinimo.ToString();
                if (cadastro.Imagem != null )
                {
                    using (var ms = new System.IO.MemoryStream(cadastro.Imagem))
                    {
                        pictureBoxCadastroProduto.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void pictureBoxCadastroProduto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Selecione uma imagem";
                open.Filter = "Imagens(*.jpg;*.jpeg;*.png;*.bmp|*.jpg;*.jpeg;*.png;*.bmp)";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (pictureBoxCadastroProduto.Image != null)
                        {
                            pictureBoxCadastroProduto.Image.Dispose();
                            pictureBoxCadastroProduto.Image = null;
                        }

                        pictureBoxCadastroProduto.Image = Image.FromFile(open.FileName);

                        pictureBoxCadastroProduto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao carregar imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

            }
        }       }
}
