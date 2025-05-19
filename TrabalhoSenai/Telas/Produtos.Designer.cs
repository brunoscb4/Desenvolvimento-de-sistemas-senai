namespace TrabalhoSenai.Telas
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textNomeProduto = new TextBox();
            textEstoque = new TextBox();
            textPesquisa = new TextBox();
            pictureBox2 = new PictureBox();
            comboBoxCategorias = new ComboBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 157);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(507, 173);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.camera_fotografica;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 4);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 45);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Estoque:";
            // 
            // textNomeProduto
            // 
            textNomeProduto.Location = new Point(181, 1);
            textNomeProduto.Margin = new Padding(3, 4, 3, 4);
            textNomeProduto.Name = "textNomeProduto";
            textNomeProduto.Size = new Size(299, 27);
            textNomeProduto.TabIndex = 4;
            // 
            // textEstoque
            // 
            textEstoque.Location = new Point(181, 45);
            textEstoque.Margin = new Padding(3, 4, 3, 4);
            textEstoque.Name = "textEstoque";
            textEstoque.Size = new Size(110, 27);
            textEstoque.TabIndex = 5;
            // 
            // textPesquisa
            // 
            textPesquisa.Location = new Point(181, 117);
            textPesquisa.Margin = new Padding(3, 4, 3, 4);
            textPesquisa.Name = "textPesquisa";
            textPesquisa.Size = new Size(263, 27);
            textPesquisa.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(451, 117);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(3, 120);
            comboBoxCategorias.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(138, 28);
            comboBoxCategorias.TabIndex = 8;
            comboBoxCategorias.SelectedValueChanged += comboBoxCategorias_SelectedValueChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ilustracao_da_cidade_anime;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(507, 331);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            Controls.Add(comboBoxCategorias);
            Controls.Add(pictureBox2);
            Controls.Add(textPesquisa);
            Controls.Add(textEstoque);
            Controls.Add(textNomeProduto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox3);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Produtos";
            Size = new Size(507, 331);
            Load += Produtos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textNomeProduto;
        private TextBox textEstoque;
        private TextBox textPesquisa;
        private PictureBox pictureBox2;
        private ComboBox comboBoxCategorias;
        private PictureBox pictureBox3;
    }
}
