namespace ControContatos.Telas
{
    partial class TelaMain
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
            panelContatos = new Panel();
            button4 = new Button();
            textBoxBuscar = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            TextBoxMaskTelefone = new MaskedTextBox();
            textBoxNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panelContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelContatos
            // 
            panelContatos.BackColor = SystemColors.GradientActiveCaption;
            panelContatos.Controls.Add(button4);
            panelContatos.Controls.Add(textBoxBuscar);
            panelContatos.Controls.Add(button3);
            panelContatos.Controls.Add(button2);
            panelContatos.Controls.Add(button1);
            panelContatos.Controls.Add(TextBoxMaskTelefone);
            panelContatos.Controls.Add(textBoxNome);
            panelContatos.Controls.Add(label3);
            panelContatos.Controls.Add(label2);
            panelContatos.Controls.Add(dataGridView1);
            panelContatos.Dock = DockStyle.Fill;
            panelContatos.Location = new Point(0, 0);
            panelContatos.Margin = new Padding(3, 4, 3, 4);
            panelContatos.Name = "panelContatos";
            panelContatos.Size = new Size(457, 617);
            panelContatos.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(347, 23);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 10;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(56, 23);
            textBoxBuscar.Margin = new Padding(3, 4, 3, 4);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(284, 27);
            textBoxBuscar.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(347, 433);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 8;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(347, 367);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 7;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(347, 563);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 6;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TextBoxMaskTelefone
            // 
            TextBoxMaskTelefone.Location = new Point(107, 561);
            TextBoxMaskTelefone.Margin = new Padding(3, 4, 3, 4);
            TextBoxMaskTelefone.Mask = "(00)00000-0000";
            TextBoxMaskTelefone.Name = "TextBoxMaskTelefone";
            TextBoxMaskTelefone.Size = new Size(154, 27);
            TextBoxMaskTelefone.TabIndex = 5;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(107, 507);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(284, 27);
            textBoxNome.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 568);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 3;
            label3.Text = "Telefone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 507);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 73);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(337, 409);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TelaMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContatos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaMain";
            Size = new Size(457, 617);
            Load += TelaMain_Load;
            panelContatos.ResumeLayout(false);
            panelContatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContatos;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private MaskedTextBox TextBoxMaskTelefone;
        private TextBox textBoxNome;
        private Label label3;
        private Label label2;
        private Button button4;
        private TextBox textBoxBuscar;
        private Button button3;
    }
}
