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
    public partial class ListaProdutos : UserControl
    {
        public ListaProdutos()
        {
            InitializeComponent();
        }
         CadastroDeProduto produto = new CadastroDeProduto();
        private void ListaProdutos_Load(object sender, EventArgs e)
        {
            

            dataGridView1.DataSource = produto.ProdutosRegistrados();
            if (!dataGridView1.Columns.Contains("btnAcao"))
            {
                DataGridViewButtonColumn btnColuna = new DataGridViewButtonColumn();
                btnColuna.Name = "btnAcao";
                btnColuna.HeaderText = "AÇÃO";
                btnColuna.Text = "Editar";
                btnColuna.UseColumnTextForButtonValue = true;
                btnColuna.DefaultCellStyle.BackColor = Color.DarkRed;
                dataGridView1.Columns.Add(btnColuna);
                btnColuna.Width = 50;
                dataGridView1.RowTemplate.Height = 20;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroDeProduto produto = new CadastroDeProduto();
            int? idBuscar = null;
            if (!string.IsNullOrWhiteSpace(TextBoxCodigoBuscar.Text) && TextBoxCodigoBuscar.Text != null)
            {
                idBuscar = int.Parse(TextBoxCodigoBuscar.Text);
           

                dataGridView1.DataSource =  produto.ProdutosRegisBuscaId(idBuscar);
                if (!dataGridView1.Columns.Contains("btnAcao"))
                {
                    DataGridViewButtonColumn btnColuna = new DataGridViewButtonColumn();
                    btnColuna.Name = "btnAcao";
                    btnColuna.HeaderText = "AÇÃO";
                    btnColuna.Text = "Editar";
                    btnColuna.UseColumnTextForButtonValue = true;
                    btnColuna.DefaultCellStyle.BackColor = Color.DarkRed;
                    dataGridView1.Columns.Add(btnColuna);
                    btnColuna.Width = 50;
                    dataGridView1.RowTemplate.Height = 20;
                }
              
            }
            else
            {
               
                dataGridView1.DataSource = produto.ProdutosRegisBuscaNome(textBoxBuscarNome.Text);

                if (!dataGridView1.Columns.Contains("btnAcao"))
                {
                    DataGridViewButtonColumn btnColuna = new DataGridViewButtonColumn();
                    btnColuna.Name = "btnAcao";
                    btnColuna.HeaderText = "AÇÃO";
                    btnColuna.Text = "Editar";
                    btnColuna.UseColumnTextForButtonValue = true;
                    btnColuna.DefaultCellStyle.BackColor = Color.DarkRed;
                    dataGridView1.Columns.Add(btnColuna);
                    btnColuna.Width = 50;
                    dataGridView1.RowTemplate.Height = 20;
                }
            }
        }

        private void TextBoxCodigoBuscar_Click(object sender, EventArgs e)
        {
            TextBoxCodigoBuscar.SelectionStart = TextBoxCodigoBuscar.Text.Length;
            TextBoxCodigoBuscar.SelectionLength = 0;
            TextBoxCodigoBuscar.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0 && dataGridView1.Columns[e.ColumnIndex].Name == "btnAcao")
            { 
              
                  CadastroDeProduto.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString());
                if (produto.InformacaoDoProduto())
                {
                    EditarProdutos editarProdutos = new EditarProdutos(produto);
                PanelListaProdutos.Controls.Clear();
                editarProdutos.Dock = DockStyle.Fill;
                PanelListaProdutos.Controls.Add(editarProdutos);
                }
                
                
            }
        }
    }
}
