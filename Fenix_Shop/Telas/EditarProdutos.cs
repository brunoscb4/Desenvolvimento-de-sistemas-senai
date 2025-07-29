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

        private void Salvar_Click(object sender, EventArgs e)
        {

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
                TextBoxVenda.Text = (cadastro.ValorVenda / 100.0m ).ToString("C2");
                TextBoxEstoque.Text = cadastro.Estoque.ToString();
                TextBoxCodigoBarras.Text = cadastro.CodigoBarras;
                TextBoxSku.Text = cadastro.Sku;
                if (cadastro.Imagem != null)
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
    }
}
