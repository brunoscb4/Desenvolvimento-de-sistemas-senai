using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projeto_05.Programação;

namespace Projeto_05.Telas
{
    public partial class Agenda : UserControl
    {
        public Agenda()
        {
            InitializeComponent();
        }
        private int id;
        private void button2_Click(object sender, EventArgs e)
        {
            CadastroAgenda agenda = new CadastroAgenda();

            try
            {
                if (textBoxDescricao.Text != "" && dateTimePickerData.Text != "")
                {
                    agenda.Data = dateTimePickerData.Value.Date;
                    agenda.Hora = dateTimePickerTime.Value.TimeOfDay;
                    agenda.Descricao = textBoxDescricao.Text;

                    agenda.Cadastro();

                    MessageBox.Show("Cadastro realizado..");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = agenda.Datagrid();

                }
                else
                {
                    MessageBox.Show("CAadastro não realizado...");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao acessar o banco" + ex.Message);
            }
        }




        private void Agenda_Load(object sender, EventArgs e)
        {
            CadastroAgenda agenda = new CadastroAgenda();
            dataGridView1.DataSource = agenda.Datagrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            textBoxDescricao.Text = dataGridView1.Rows[e.RowIndex].Cells["DESCRICAO"].Value.ToString();
            dateTimePickerData.Text = dataGridView1.Rows[e.RowIndex].Cells["CALENDARIO"].Value.ToString();
            dateTimePickerTime.Text = dataGridView1.Rows[e.RowIndex].Cells["HORA"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroAgenda agenda = new CadastroAgenda();
                if (textBoxDescricao.Text != "" && dateTimePickerData.Text != "")
                {
                    agenda.Data = dateTimePickerData.Value.Date;
                    agenda.Hora = dateTimePickerTime.Value.TimeOfDay;
                    agenda.Descricao = textBoxDescricao.Text;
                    agenda.Id = id;

                    agenda.Editar();

                    MessageBox.Show("Editado com sucesso");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = agenda.Datagrid();

                }
                else { MessageBox.Show("Erro ao editar"); }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroAgenda agenda = new CadastroAgenda();
                if (textBoxDescricao.Text != "" && dateTimePickerData.Text != "")
                {
                    agenda.Data = dateTimePickerData.Value.Date;
                    agenda.Hora = dateTimePickerTime.Value.TimeOfDay;
                    agenda.Descricao = textBoxDescricao.Text;
                    agenda.Id = id;

                    agenda.Excluir();

                    MessageBox.Show("Excluido com sucesso");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = agenda.Datagrid();

                }
                else { MessageBox.Show("Erro ao excluir"); }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroAgenda agenda = new CadastroAgenda();
                agenda.Data = dateTimePickerBuscar.Value.Date;

                dataGridView1.DataSource = agenda.Buscar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao realizar a busca");
            }
        }
    }
}
