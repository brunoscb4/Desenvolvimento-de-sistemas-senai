using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenaiGerenciadorProdutos.Progamação;

namespace SenaiGerenciadorProdutos.Resources.Paineis
{
    public partial class Pagina_inicial : UserControl
    {

        public Pagina_inicial()
        {
            InitializeComponent();


        }
        public int idB;

        

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos produtos = new Produtos();

                produtos.NomeProduto = textNomeProduto.Text;
                produtos.Preco = double.Parse(textPreco.Text);
                produtos.Estoque = int.Parse(textEstoque.Text);
                produtos.Categoria = textCategoria.Text;

                if (textNomeProduto.Text != "" && textPreco.Text != "" && textEstoque.Text != "" && textEstoque.Text != "")
                {

                    produtos.CadastroProduto();
                    textNomeProduto.Clear();
                    textPreco.Clear();
                    textEstoque.Clear();
                    textCategoria.Clear();
                    textNomeProduto.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cadastro não realizado...");

            }
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos produtos = new Produtos();



                dataGridView1.DataSource = produtos.Listar();



            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao consultar dados..");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Produtos produtos = new Produtos();

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                textNomeProduto.Text = dataGridView1.CurrentRow.Cells["PRODUTO"].Value.ToString();
                textPreco.Text = dataGridView1.CurrentRow.Cells["PRECO"].Value.ToString();
                textEstoque.Text = dataGridView1.CurrentRow.Cells["ESTOQUE"].Value.ToString();
                textCategoria.Text = dataGridView1.CurrentRow.Cells["CATEGORIA"].Value.ToString();
                idB = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Produtos produtos = new Produtos();


                if (textNomeProduto.Text != "" && textPreco.Text != "" && textEstoque.Text != "" && textEstoque.Text != "")
                {
                    produtos.IdBanco = idB;
                    produtos.NomeProduto = textNomeProduto.Text;
                    produtos.Preco = double.Parse(textPreco.Text);
                    produtos.Estoque = int.Parse(textEstoque.Text);
                    produtos.Categoria = textCategoria.Text;

                    produtos.Editar();

                    dataGridView1.DataSource = produtos.Listar();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Nâo foi possivel finalar a edição");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();

            produtos.Pesquisa = textPesquisa.Text;

            if (textPesquisa.Text != "")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = produtos.Seach();
                textPesquisa.Clear();
                textPesquisa.Focus();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Produtos produtos = new Produtos();


                if (textNomeProduto.Text != "" && textPreco.Text != "" && textEstoque.Text != "" && textEstoque.Text != "")
                {
                    produtos.IdBanco = idB;
                    produtos.NomeProduto = textNomeProduto.Text;
                    produtos.Preco = double.Parse(textPreco.Text);
                    produtos.Estoque = int.Parse(textEstoque.Text);
                    produtos.Categoria = textCategoria.Text;

                    produtos.Excluir();

                    textNomeProduto.Clear();
                    textPreco.Clear();
                    textEstoque.Clear();
                    textCategoria.Clear();
                    textEstoque.Focus();

                    dataGridView1.DataSource = produtos.Listar();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Nâo foi possivel finalar a exclusão");
            }
        }

        

    }
}
