namespace Projeto_05.Telas
{
    partial class Agenda
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
            dateTimePickerBuscar = new DateTimePicker();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerData = new DateTimePicker();
            dateTimePickerTime = new DateTimePicker();
            textBoxDescricao = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(632, 331);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePickerBuscar
            // 
            dateTimePickerBuscar.Format = DateTimePickerFormat.Custom;
            dateTimePickerBuscar.Location = new Point(206, 19);
            dateTimePickerBuscar.Name = "dateTimePickerBuscar";
            dateTimePickerBuscar.Size = new Size(126, 27);
            dateTimePickerBuscar.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(354, 19);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 544);
            label1.Name = "label1";
            label1.Size = new Size(60, 24);
            label1.TabIndex = 3;
            label1.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 599);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 4;
            label2.Text = "Hora:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 456);
            label3.Name = "label3";
            label3.Size = new Size(111, 24);
            label3.TabIndex = 5;
            label3.Text = "Descrição:";
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Format = DateTimePickerFormat.Custom;
            dateTimePickerData.Location = new Point(160, 544);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(126, 27);
            dateTimePickerData.TabIndex = 6;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Format = DateTimePickerFormat.Time;
            dateTimePickerTime.Location = new Point(160, 596);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.Size = new Size(126, 27);
            dateTimePickerTime.TabIndex = 7;
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.BackColor = SystemColors.Menu;
            textBoxDescricao.Location = new Point(160, 423);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(446, 83);
            textBoxDescricao.TabIndex = 9;
            textBoxDescricao.Text = "";
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Location = new Point(346, 566);
            button2.Name = "button2";
            button2.Size = new Size(66, 29);
            button2.TabIndex = 10;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lavender;
            button3.Location = new Point(439, 566);
            button3.Name = "button3";
            button3.Size = new Size(66, 29);
            button3.TabIndex = 11;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Lavender;
            button4.Location = new Point(532, 566);
            button4.Name = "button4";
            button4.Size = new Size(66, 29);
            button4.TabIndex = 12;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBoxDescricao);
            Controls.Add(dateTimePickerTime);
            Controls.Add(dateTimePickerData);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dateTimePickerBuscar);
            Controls.Add(dataGridView1);
            Name = "Agenda";
            Size = new Size(632, 631);
            Load += Agenda_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePickerBuscar;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerData;
        private DateTimePicker dateTimePickerTime;
        private RichTextBox textBoxDescricao;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
