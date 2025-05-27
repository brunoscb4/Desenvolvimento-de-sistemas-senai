using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControContatos.Programação;

namespace ControContatos.Telas
{
    public partial class TelaMain : UserControl
    {
        public TelaMain()
        {
            InitializeComponent();
        }


        public Panel panelMain()
        {
            return panelContatos;
        }

        private void panelContatos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Usuario usuario = new Usuario();



                if (textBoxNome.Text != "" && TextBoxMaskTelefone.Text != "")
                {

                    usuario.NomeContato = textBoxNome.Text;
                    usuario.TelCadastro = TextBoxMaskTelefone.Text;

                    usuario.CadastrarContato();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = usuario.DataGrid();

                }
                else
                {
                    MessageBox.Show("Preencha os campis corretamente..");

                    textBoxNome.Clear();
                    TextBoxMaskTelefone.Clear();
                    textBoxNome.Focus();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao realizar o cadastro " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxNome.Text = dataGridView1.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
                TextBoxMaskTelefone.Text = dataGridView1.Rows[e.RowIndex].Cells["TEL"].Value.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao aceesar daos da tabela ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.NomeContato = textBoxNome.Text;
            usuario.TelCadastro = TextBoxMaskTelefone.Text;

            usuario.Excluir();

            MessageBox.Show("Excluido com suscesso");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuario.DataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario.NomeContato = textBoxNome.Text;
            usuario.TelCadastro = TextBoxMaskTelefone.Text;

            usuario.Editar();

            MessageBox.Show("Editado com sucesso ..");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuario.DataGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();

                usuario.NomeContato = textBoxBuscar.Text;

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = usuario.BuscarContato();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao buscar " + ex.Message);
            }
        }

        private void TelaMain_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            dataGridView1.DataSource = usuario.DataGrid();
        }
    }
}

