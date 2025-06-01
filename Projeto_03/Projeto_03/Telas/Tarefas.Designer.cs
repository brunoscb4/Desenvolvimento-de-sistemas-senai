namespace Projeto_03.Telas
{
    partial class Tarefas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dateTimePickerData = new DateTimePicker();
            label1 = new Label();
            TextBoxDescricao = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            checkBoxCompleto = new CheckBox();
            checkBoxPendente = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(315, 422);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Format = DateTimePickerFormat.Short;
            dateTimePickerData.Location = new Point(339, 186);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(97, 23);
            dateTimePickerData.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 22);
            label1.Name = "label1";
            label1.Size = new Size(162, 19);
            label1.TabIndex = 2;
            label1.Text = "Descrição da tarefa:";
            // 
            // TextBoxDescricao
            // 
            TextBoxDescricao.Location = new Point(339, 44);
            TextBoxDescricao.Name = "TextBoxDescricao";
            TextBoxDescricao.Size = new Size(309, 96);
            TextBoxDescricao.TabIndex = 3;
            TextBoxDescricao.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(339, 154);
            label2.Name = "label2";
            label2.Size = new Size(122, 19);
            label2.TabIndex = 4;
            label2.Text = "Prazo termino:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(339, 223);
            label3.Name = "label3";
            label3.Size = new Size(134, 19);
            label3.TabIndex = 5;
            label3.Text = "Status da tarefa:";
            // 
            // checkBoxCompleto
            // 
            checkBoxCompleto.AutoSize = true;
            checkBoxCompleto.Location = new Point(339, 263);
            checkBoxCompleto.Name = "checkBoxCompleto";
            checkBoxCompleto.Size = new Size(79, 19);
            checkBoxCompleto.TabIndex = 6;
            checkBoxCompleto.Text = "Completo";
            checkBoxCompleto.UseVisualStyleBackColor = true;
            // 
            // checkBoxPendente
            // 
            checkBoxPendente.AutoSize = true;
            checkBoxPendente.Location = new Point(481, 263);
            checkBoxPendente.Name = "checkBoxPendente";
            checkBoxPendente.Size = new Size(76, 19);
            checkBoxPendente.TabIndex = 7;
            checkBoxPendente.Text = "Pendente";
            checkBoxPendente.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(339, 336);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 8;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(456, 336);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 9;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(573, 336);
            button3.Name = "button3";
            button3.Size = new Size(75, 25);
            button3.TabIndex = 10;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Tarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBoxPendente);
            Controls.Add(checkBoxCompleto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TextBoxDescricao);
            Controls.Add(label1);
            Controls.Add(dateTimePickerData);
            Controls.Add(dataGridView1);
            Name = "Tarefas";
            Size = new Size(670, 422);
            Load += Tarefas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePickerData;
        private Label label1;
        private RichTextBox TextBoxDescricao;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxCompleto;
        private CheckBox checkBoxPendente;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
