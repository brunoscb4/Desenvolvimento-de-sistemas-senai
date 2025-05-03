namespace SenaiGerenciadorProdutos.Resources.Paineis
{
    partial class Pagina_inicial
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            Listar = new Button();
            Cadastrar = new Button();
            pictureBox1 = new PictureBox();
            textPesquisa = new TextBox();
            dataGridView1 = new DataGridView();
            textCategoria = new TextBox();
            textEstoque = new MaskedTextBox();
            textPreco = new MaskedTextBox();
            textNomeProduto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            columnBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)columnBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Listar);
            panel1.Controls.Add(Cadastrar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textPesquisa);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(textCategoria);
            panel1.Controls.Add(textEstoque);
            panel1.Controls.Add(textPreco);
            panel1.Controls.Add(textNomeProduto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 508);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = columnBindingSource;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(355, 22);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 28);
            comboBox1.TabIndex = 16;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(712, 339);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(85, 27);
            button2.TabIndex = 15;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(591, 339);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(82, 27);
            button1.TabIndex = 14;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Listar
            // 
            Listar.BackColor = Color.FromArgb(0, 192, 0);
            Listar.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Listar.ForeColor = Color.White;
            Listar.Location = new Point(478, 339);
            Listar.Margin = new Padding(2);
            Listar.Name = "Listar";
            Listar.Size = new Size(88, 27);
            Listar.TabIndex = 13;
            Listar.Text = "Listar";
            Listar.UseVisualStyleBackColor = false;
            Listar.Click += Listar_Click;
            // 
            // Cadastrar
            // 
            Cadastrar.BackColor = Color.FromArgb(0, 192, 0);
            Cadastrar.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cadastrar.ForeColor = Color.White;
            Cadastrar.Location = new Point(230, 368);
            Cadastrar.Margin = new Padding(2);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(106, 27);
            Cadastrar.TabIndex = 12;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = false;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lupa;
            pictureBox1.Location = new Point(864, 22);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textPesquisa
            // 
            textPesquisa.Location = new Point(562, 22);
            textPesquisa.Margin = new Padding(2);
            textPesquisa.Name = "textPesquisa";
            textPesquisa.Size = new Size(298, 27);
            textPesquisa.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(355, 86);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(550, 236);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textCategoria
            // 
            textCategoria.Location = new Point(39, 298);
            textCategoria.Margin = new Padding(2);
            textCategoria.Name = "textCategoria";
            textCategoria.Size = new Size(298, 27);
            textCategoria.TabIndex = 8;
            // 
            // textEstoque
            // 
            textEstoque.HidePromptOnLeave = true;
            textEstoque.Location = new Point(39, 228);
            textEstoque.Margin = new Padding(2);
            textEstoque.Mask = "0000000000";
            textEstoque.Name = "textEstoque";
            textEstoque.Size = new Size(109, 27);
            textEstoque.TabIndex = 7;
            // 
            // textPreco
            // 
            textPreco.HidePromptOnLeave = true;
            textPreco.ImeMode = ImeMode.NoControl;
            textPreco.Location = new Point(39, 166);
            textPreco.Margin = new Padding(2);
            textPreco.Mask = "0000000000";
            textPreco.Name = "textPreco";
            textPreco.Size = new Size(109, 27);
            textPreco.TabIndex = 6;
            textPreco.ValidatingType = typeof(int);
            // 
            // textNomeProduto
            // 
            textNomeProduto.Location = new Point(39, 86);
            textNomeProduto.Margin = new Padding(2);
            textNomeProduto.Name = "textNomeProduto";
            textNomeProduto.Size = new Size(298, 27);
            textNomeProduto.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 255);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 22);
            label5.TabIndex = 4;
            label5.Text = "Categoria:";
            label5.UseMnemonic = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(25, 193);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(200, 22);
            label4.TabIndex = 3;
            label4.Text = "Quantidade estoque:";
            label4.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 127);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 2;
            label3.Text = "Preço:";
            label3.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 62);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 22);
            label2.TabIndex = 1;
            label2.Text = "Nome produto:";
            label2.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(18, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 32);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar produto";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // columnBindingSource
            // 
            columnBindingSource.DataSource = typeof(Mysqlx.Crud.Column);
            // 
            // Pagina_inicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Pagina_inicial";
            Size = new Size(907, 508);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)columnBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textPesquisa;
        private DataGridView dataGridView1;
        private TextBox textCategoria;
        private MaskedTextBox textEstoque;
        private MaskedTextBox textPreco;
        private TextBox textNomeProduto;
        private PictureBox pictureBox1;
        private Button Listar;
        private Button Cadastrar;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private ContextMenuStrip contextMenuStrip1;
        private BindingSource columnBindingSource;
    }
}
