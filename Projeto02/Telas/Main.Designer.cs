namespace Projeto02.Telas
{
    partial class Main
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
            panel1 = new Panel();
            textBoxIdUser = new TextBox();
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBoxCategoria = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBoxBuscar = new TextBox();
            button1 = new Button();
            TextBoxMaskValorProduto = new MaskedTextBox();
            TextBoxMaskEstoque = new MaskedTextBox();
            textBoxEmpresa = new TextBox();
            textBoxNomeGame = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(textBoxIdUser);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBoxCategoria);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBoxBuscar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(TextBoxMaskValorProduto);
            panel1.Controls.Add(TextBoxMaskEstoque);
            panel1.Controls.Add(textBoxEmpresa);
            panel1.Controls.Add(textBoxNomeGame);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 488);
            panel1.TabIndex = 0;
            // 
            // textBoxIdUser
            // 
            textBoxIdUser.Location = new Point(791, 238);
            textBoxIdUser.Name = "textBoxIdUser";
            textBoxIdUser.Size = new Size(42, 23);
            textBoxIdUser.TabIndex = 18;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(758, 355);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 17;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(591, 355);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lupa;
            pictureBox1.Location = new Point(368, 401);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.Location = new Point(566, 175);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(267, 23);
            textBoxCategoria.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(566, 146);
            label7.Name = "label7";
            label7.Size = new Size(66, 16);
            label7.TabIndex = 13;
            label7.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 405);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 12;
            label6.Text = "Buscar";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(75, 401);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(267, 23);
            textBoxBuscar.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(758, 294);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TextBoxMaskValorProduto
            // 
            TextBoxMaskValorProduto.Location = new Point(566, 294);
            TextBoxMaskValorProduto.Name = "TextBoxMaskValorProduto";
            TextBoxMaskValorProduto.Size = new Size(100, 23);
            TextBoxMaskValorProduto.TabIndex = 9;
            // 
            // TextBoxMaskEstoque
            // 
            TextBoxMaskEstoque.Location = new Point(566, 238);
            TextBoxMaskEstoque.Mask = "00000000000";
            TextBoxMaskEstoque.Name = "TextBoxMaskEstoque";
            TextBoxMaskEstoque.Size = new Size(100, 23);
            TextBoxMaskEstoque.TabIndex = 8;
            // 
            // textBoxEmpresa
            // 
            textBoxEmpresa.Location = new Point(566, 110);
            textBoxEmpresa.Name = "textBoxEmpresa";
            textBoxEmpresa.Size = new Size(267, 23);
            textBoxEmpresa.TabIndex = 7;
            // 
            // textBoxNomeGame
            // 
            textBoxNomeGame.Location = new Point(566, 58);
            textBoxNomeGame.Name = "textBoxNomeGame";
            textBoxNomeGame.Size = new Size(267, 23);
            textBoxNomeGame.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(566, 264);
            label5.Name = "label5";
            label5.Size = new Size(40, 16);
            label5.TabIndex = 5;
            label5.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(566, 210);
            label4.Name = "label4";
            label4.Size = new Size(59, 16);
            label4.TabIndex = 4;
            label4.Text = "Estoque:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(566, 84);
            label3.Name = "label3";
            label3.Size = new Size(63, 16);
            label3.TabIndex = 3;
            label3.Text = "Empresa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(566, 31);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 2;
            label2.Text = "Nome do jogo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(649, 11);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Cadastrar:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(560, 378);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Main";
            Size = new Size(850, 488);
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private MaskedTextBox TextBoxMaskValorProduto;
        private MaskedTextBox TextBoxMaskEstoque;
        private TextBox textBoxEmpresa;
        private TextBox textBoxNomeGame;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox textBoxCategoria;
        private Label label7;
        private Label label6;
        private TextBox textBoxBuscar;
        private Button button1;
        private Button button3;
        private Button button2;
        private TextBox textBoxIdUser;
    }
}
