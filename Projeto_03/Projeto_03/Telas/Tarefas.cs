using Projeto_03.programação;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03.Telas
{
    public partial class Tarefas : UserControl
    {
        public Tarefas()
        {
            InitializeComponent();
        }
        private int id;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                CadastroTarefas tarefas = new CadastroTarefas();
                if (TextBoxDescricao.Text != "" && dateTimePickerData.Text != "")
                {
                    tarefas.Descricao = TextBoxDescricao.Text;
                    tarefas.Data = dateTimePickerData.Value.Date;

                    if (checkBoxCompleto.Checked)
                    {
                        tarefas.Status = "Completa";
                    }
                    if (checkBoxPendente.Checked)
                    {
                        tarefas.Status = "Pendente";
                    }


                    tarefas.tarefasCadastradas();
                    MessageBox.Show("Terefa casdastrada ..");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = tarefas.Select();

                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente ..");
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void Tarefas_Load(object sender, EventArgs e)
        {
            CadastroTarefas tarefas = new CadastroTarefas();
            dataGridView1.DataSource = tarefas.Select();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            TextBoxDescricao.Text = dataGridView1.Rows[e.RowIndex].Cells["DESCRICAO"].Value.ToString();
            dateTimePickerData.Text = dataGridView1.Rows[e.RowIndex].Cells["DATACONCLUSAO"].Value.ToString();
            string status = dataGridView1.Rows[e.RowIndex].Cells["SITUACAO"].Value.ToString();
            if (status == "Completo")
            {
                checkBoxCompleto.Checked = true;
            }
            else
            {
                checkBoxPendente.Checked = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroTarefas tarefas = new CadastroTarefas();

                if (TextBoxDescricao.Text != "" && dateTimePickerData.Text != "")
                {
                    tarefas.Id = id;
                    tarefas.Descricao = TextBoxDescricao.Text;
                    tarefas.Data = dateTimePickerData.Value.Date;
                    if (checkBoxCompleto.Checked)
                    {
                        tarefas.Status = "Completo";
                    }
                    else if (checkBoxPendente.Checked)
                    {
                        tarefas.Status = "Pendente";
                    }

                    tarefas.Editar();
                    MessageBox.Show("Tarefa ediatada com secesso..");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = tarefas.Select();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar dados");
;                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroTarefas tarefas = new CadastroTarefas();

                if (TextBoxDescricao.Text != "" && dateTimePickerData.Text != "")
                {
                    tarefas.Id = id;
                    tarefas.Descricao = TextBoxDescricao.Text;
                    tarefas.Data = dateTimePickerData.Value.Date;
                    if (checkBoxCompleto.Checked)
                    {
                        tarefas.Status = "Completo";
                    }
                    else if (checkBoxPendente.Checked)
                    {
                        tarefas.Status = "Pendente";
                    }

                    tarefas.Excluir();
                    MessageBox.Show("Tarefa excluida com secesso..");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = tarefas.Select();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir dados");
                ;
            }
        }
    }
}
