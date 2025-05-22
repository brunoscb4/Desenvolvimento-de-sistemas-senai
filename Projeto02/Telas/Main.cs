using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto02.Programas;

namespace Projeto02.Telas
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }
        private int idPush;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cadastro cadastro = new Cadastro();
                if (textBoxNomeGame.Text != "" && textBoxEmpresa.Text != "" && textBoxCategoria.Text != "" && TextBoxMaskEstoque.Text != "" && TextBoxMaskValorProduto.Text != "")
                {

                    cadastro.Jogo = textBoxNomeGame.Text;
                    cadastro.Empresa = textBoxEmpresa.Text;
                    cadastro.Categoria = textBoxCategoria.Text;
                    cadastro.Estoque = Convert.ToInt32(TextBoxMaskEstoque.Text);
                    cadastro.Valor = double.Parse(TextBoxMaskValorProduto.Text);
                    cadastro.Id_jogos = Convert.ToInt32(textBoxIdUser.Text);


                    cadastro.Cadastrojogo();
                    MessageBox.Show(" Cadastro realizado com sucesso ...");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = cadastro.Select();

                }
                else
                {
                    MessageBox.Show("Prencha os campos corretamente..");
                    textBoxNomeGame.Clear();
                    textBoxEmpresa.Clear();
                    textBoxCategoria.Clear();
                    TextBoxMaskEstoque.Clear();
                    TextBoxMaskValorProduto.Clear();

                    textBoxNomeGame.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar dados " + ex.Message);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            Cadastro cadastro = new Cadastro();


            dataGridView1.DataSource = cadastro.Select();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idPush = Convert.ToInt32( dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            textBoxNomeGame.Text = dataGridView1.Rows[e.RowIndex].Cells["JOGO"].Value.ToString();
            textBoxEmpresa.Text = dataGridView1.Rows[e.RowIndex].Cells["EMPRESA"].Value.ToString();
            textBoxCategoria.Text = dataGridView1.Rows[e.RowIndex].Cells["CATEGORIA"].Value.ToString();
            TextBoxMaskEstoque.Text = dataGridView1.Rows[e.RowIndex].Cells["ESTOQUE"].Value.ToString();
            TextBoxMaskValorProduto.Text = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["VALOR"].Value.ToString()).ToString("N2");
            textBoxIdUser.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_JOGOS"].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();

            try
            {
                cadastro.Jogo = textBoxNomeGame.Text;
                cadastro.Empresa = textBoxEmpresa.Text;
                cadastro.Categoria = textBoxCategoria.Text;
                cadastro.Estoque = Convert.ToInt32(TextBoxMaskEstoque.Text);
                cadastro.Valor = double.Parse(TextBoxMaskValorProduto.Text);
                cadastro.Id = idPush;

                cadastro.Editar();
                MessageBox.Show("Editado com sucesso ..");

                textBoxNomeGame.Clear();
                textBoxEmpresa.Clear();
                textBoxCategoria.Clear();
                TextBoxMaskEstoque.Clear();
                TextBoxMaskValorProduto.Clear();

                textBoxNomeGame.Focus();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = cadastro.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar informações " + ex.Message);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();

            try
            {

                cadastro.Id = idPush;

                cadastro.Excluir();
                MessageBox.Show("Excluido com sucesso ..");

                textBoxNomeGame.Clear();
                textBoxEmpresa.Clear();
                textBoxCategoria.Clear();
                TextBoxMaskEstoque.Clear();
                TextBoxMaskValorProduto.Clear();

                textBoxNomeGame.Focus();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = cadastro.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar informações " + ex.Message);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();

            cadastro.Jogo = textBoxBuscar.Text;
        
            dataGridView1.DataSource = cadastro.Procurar();
        }
    }
}
