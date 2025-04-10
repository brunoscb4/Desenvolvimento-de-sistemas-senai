namespace CadastroProdutos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Adicionar = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textCategoria = new TextBox();
            textNome = new TextBox();
            TextRealizado = new Label();
            button1 = new Button();
            textBuscar = new TextBox();
            Listar = new Button();
            textPreco = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Adicionar
            // 
            Adicionar.Font = new Font("Algerian", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Adicionar.Location = new Point(623, 286);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(86, 23);
            Adicionar.TabIndex = 0;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(424, 449);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(457, 24);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 2;
            label1.Text = "Categoria :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(457, 187);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Preço :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(457, 109);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Nome :";
            // 
            // textCategoria
            // 
            textCategoria.Location = new Point(479, 61);
            textCategoria.Name = "textCategoria";
            textCategoria.Size = new Size(230, 23);
            textCategoria.TabIndex = 5;
            // 
            // textNome
            // 
            textNome.Location = new Point(479, 140);
            textNome.Name = "textNome";
            textNome.Size = new Size(230, 23);
            textNome.TabIndex = 6;
            // 
            // TextRealizado
            // 
            TextRealizado.AutoSize = true;
            TextRealizado.Location = new Point(572, 263);
            TextRealizado.Name = "TextRealizado";
            TextRealizado.Size = new Size(7, 15);
            TextRealizado.TabIndex = 8;
            TextRealizado.Text = "\r\n";
            // 
            // button1
            // 
            button1.Font = new Font("Algerian", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(623, 415);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 9;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBuscar
            // 
            textBuscar.Location = new Point(479, 368);
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(230, 23);
            textBuscar.TabIndex = 10;
            // 
            // Listar
            // 
            Listar.Font = new Font("Algerian", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Listar.Location = new Point(479, 286);
            Listar.Name = "Listar";
            Listar.Size = new Size(86, 23);
            Listar.TabIndex = 11;
            Listar.Text = "Listar";
            Listar.UseVisualStyleBackColor = true;
            Listar.Click += Listar_Click;
            // 
            // textPreco
            // 
            textPreco.Location = new Point(479, 222);
            textPreco.Name = "textPreco";
            textPreco.Size = new Size(117, 23);
            textPreco.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textPreco);
            Controls.Add(Listar);
            Controls.Add(textBuscar);
            Controls.Add(button1);
            Controls.Add(TextRealizado);
            Controls.Add(textNome);
            Controls.Add(textCategoria);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Adicionar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Adicionar;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textCategoria;
        private TextBox textNome;
        private Label TextRealizado;
        private Button button1;
        private TextBox textBuscar;
        private Button Listar;
        private MaskedTextBox textPreco;
    }
}
