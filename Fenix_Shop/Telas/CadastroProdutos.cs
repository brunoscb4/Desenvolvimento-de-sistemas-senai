using Fenix_Shop.programação;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Fenix_Shop.Telas
{

    public partial class CadastroProdutos : UserControl
    {
        private Tela_Inicial tela_Inicial;
        public CadastroProdutos(Tela_Inicial tela_Inicial)
        {
            InitializeComponent();
            this.tela_Inicial = tela_Inicial;
            this.Resize += new System.EventHandler(this.CadastroProdutos_Resize);
        }
        public static byte[] ConverterImagemParaBytes(Image imagem)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagem.Save(ms, imagem.RawFormat);
                return ms.ToArray();
            }
        }
        private void LimparCampos()
        {
            textBox1Nome.Clear();
            textBox2Categoria.Clear();
            textBox3Marca.Clear();
            TextBoxDescricao.Clear();
            TextBoxEstoque.Clear();
            TextBoxCusto.Clear();
            TextBoxVenda.Clear();
            TextBoxCodigoBarras.Clear();
            TextBoxSku.Clear();
            TextBoxEstoqueMinimo.Clear();
            
            pictureBoxCadastroProduto.Image = null;

            textBox1Nome.Focus();
        }
        private void PanelCadastroProduto_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void CadastroProdutos_Resize(object sender, EventArgs e)
        {
            PanelCadastroProduto.Width = this.ClientSize.Width;
            PanelCadastroProduto.Height = this.ClientSize.Height;



        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1Nome.Text != "" && TextBoxCusto.Text != "" && TextBoxVenda.Text != "" && TextBoxEstoque.Text != "")
                {
                    CadastroDeProduto produto = new CadastroDeProduto();


                    produto.Nome = textBox1Nome.Text;
                    produto.Categoria = textBox2Categoria.Text;
                    produto.Marca = textBox3Marca.Text;
                    produto.Descricao = TextBoxDescricao.Text;
                    produto.ValorCusto = double.Parse(TextBoxCusto.Text);
                    produto.ValorVenda = double.Parse(TextBoxVenda.Text);
                    produto.CodigoBarras = TextBoxCodigoBarras.Text;
                    produto.Sku = TextBoxSku.Text;
                    if (pictureBoxCadastroProduto.Image != null)
                    {
                        produto.Imagem = ConverterImagemParaBytes(pictureBoxCadastroProduto.Image);
                    }
                    else
                    {
                        produto.Imagem = ConverterImagemParaBytes(Properties.Resources.img_Fenix_Shop);
                    }
                    produto.MovimentacaoEstoque = "ENTRADA";
                    produto.Estoque = Convert.ToInt32(TextBoxEstoque.Text);


                    produto.CadastroProdutoEstoque();
                    tela_Inicial.AtualizarVendas();
                    MessageBox.Show("Cadastro realizado..");

                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente ..");
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar dados " + ex.Message);
            }
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
        }
        private void pictureBoxCadastroProduto_Click(object sender, EventArgs e)
        {
            
              using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Selecione uma imagem";
                open.Filter = "Imagens(*.jpg;*.jpeg;*.png;*.bmp|*.jpg;*.jpeg;*.png;*.bmp)";
                    
                if(open.ShowDialog() == DialogResult.OK)
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

                        MessageBox.Show("Erro ao carregar imagem: " + ex.Message ,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    

                }
            
            }
            
           
        }

        private void TextBoxCusto_Click(object sender, EventArgs e)
        {
            TextBoxCusto.Select(0, 0);
        }

        private void TextBoxVenda_Click(object sender, EventArgs e)
        {
            TextBoxVenda.Select(0, 0);
        }

        private void TextBoxEstoque_Click(object sender, EventArgs e)
        {
            TextBoxEstoque.Select(0, 0);
        }

        private void TextBoxCodigoBarras_Click(object sender, EventArgs e)
        {
            TextBoxCodigoBarras.Select(0, 0);
        }

        private void TextBoxSku_Click(object sender, EventArgs e)
        {
            TextBoxSku.Select(0, 0);
        }

        private void TextBoxEstoqueMinimo_Click(object sender, EventArgs e)
        {
            TextBoxEstoqueMinimo.Select(0, 0);
        }

        

    }
}


