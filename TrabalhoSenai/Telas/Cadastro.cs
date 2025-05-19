using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using TrabalhoSenai.Programas;
using System.IO;
using System.Drawing;


namespace TrabalhoSenai.Telas
{
    public partial class Cadastro : UserControl
    {
        public Cadastro()
        {

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens (*.Jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
                ofd.Title = "Selecionar imagem";

                if (ofd.ShowDialog() == DialogResult.OK)

                {
                    pictureBox1.Controls.Clear();
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroProduto produto = new CadastroProduto();
                Usuario usuario = new Usuario();

                if (textNomeProduto.Text != "" && textCategoria.Text != "" && TextQuantidade.Text != "" && textCodigo.Text != "" && textVenda.Text != "" && textValorCompra.Text != "")
                {


                    if (pictureBox1.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            produto.Imagem = ms.ToArray();
                        }
                    }
                    produto.IdUsuario = textId.Text;
                    produto.Produto = textNomeProduto.Text;
                    produto.Categoria = textCategoria.Text;
                    produto.Estoque = Convert.ToInt32(TextQuantidade.Text);
                    produto.Codigo = Convert.ToInt32(textCodigo.Text);
                    produto.ValorCompra = double.Parse(textValorCompra.Text);
                    produto.ValorVenda = double.Parse(textVenda.Text);

                    produto.CadastroP();


                }
                else
                {
                    MessageBox.Show("Prencha os campos corretamente");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar dados " + ex.Message);
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            

            
        }
    }
}
