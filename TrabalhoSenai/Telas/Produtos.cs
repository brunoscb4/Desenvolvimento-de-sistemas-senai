using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoSenai.Programas;

namespace TrabalhoSenai.Telas
{
    public partial class Produtos : UserControl
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            CadastroProduto produto = new CadastroProduto();

            dataGridView1.DataSource = produto.TableProduto();
            CarregarCategoriasNaComboBox();

        }
        private void CarregarCategoriasNaComboBox()
        {
            CadastroProduto produto = new CadastroProduto();
            DataTable categorias = produto.BuscarCategorias();

            if (categorias.Rows.Count > 0)
            {
                comboBoxCategorias.DataSource = categorias;
                comboBoxCategorias.DisplayMember = "CATEGORIA";
                comboBoxCategorias.ValueMember = "CATEGORIA";
                comboBoxCategorias.SelectedIndex = -1;
            }
            else
            {
                comboBoxCategorias.Items.Clear();
                comboBoxCategorias.Text = "Nenhuma categoria encontrada";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CadastroProduto produto = new CadastroProduto();

            try
            {
                if (e.RowIndex >= 0)
                {
                    produto.IdBusca = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CODIGO"].Value);
                    textNomeProduto.Text = dataGridView1.Rows[e.RowIndex].Cells["PRODUTO"].Value.ToString();
                    textEstoque.Text = dataGridView1.Rows[e.RowIndex].Cells["ESTOQUE"].Value.ToString();
                    object imagemobj = dataGridView1.Rows[e.RowIndex].Cells["IMAGEM_URL"].Value;

                    if (imagemobj != DBNull.Value && imagemobj != null)
                    {
                        try
                        {
                            byte[] imagaemBytes = (byte[])imagemobj;

                            using (MemoryStream ms = new MemoryStream(imagaemBytes))
                            {

                                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Erro ao carregar iamgem " + ex.Message);
                            pictureBox1.Image = null;
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar na tabela " + ex.Message);

            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroProduto produto = new CadastroProduto();
                produto.Nome = textPesquisa.Text;


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = produto.BuscarProduto();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao buscar produto" + ex.Message);
            }

        }

        private void comboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                CadastroProduto produto = new CadastroProduto();

                produto.Categoria = comboBoxCategorias.Text;

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = produto.BuscarProduto();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao buscar produto" + ex.Message);
            }

        }

        private void comboBoxCategorias_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                CadastroProduto produto = new CadastroProduto();
                if (comboBoxCategorias.Text.Equals(""))
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = produto.TableProduto();
                }
                else 
                {
                produto.Categoria = comboBoxCategorias.Text;

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = produto.BuscarCategoria();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao buscar produto" + ex.Message);
            }
        }
    }
}
