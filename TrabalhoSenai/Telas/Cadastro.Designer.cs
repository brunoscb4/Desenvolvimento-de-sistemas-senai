namespace TrabalhoSenai.Telas
{
    partial class Cadastro
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
            textValorCompra = new TextBox();
            textCodigo = new MaskedTextBox();
            TextQuantidade = new MaskedTextBox();
            textNomeProduto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label7 = new Label();
            textCategoria = new TextBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            textVenda = new TextBox();
            textId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textValorCompra
            // 
            textValorCompra.Location = new Point(166, 243);
            textValorCompra.Margin = new Padding(2, 3, 2, 3);
            textValorCompra.Name = "textValorCompra";
            textValorCompra.Size = new Size(154, 27);
            textValorCompra.TabIndex = 22;
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(166, 207);
            textCodigo.Margin = new Padding(2, 3, 2, 3);
            textCodigo.Mask = "0000000000";
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(121, 27);
            textCodigo.TabIndex = 21;
            // 
            // TextQuantidade
            // 
            TextQuantidade.Location = new Point(279, 166);
            TextQuantidade.Margin = new Padding(2, 3, 2, 3);
            TextQuantidade.Mask = "0000000000";
            TextQuantidade.Name = "TextQuantidade";
            TextQuantidade.Size = new Size(121, 27);
            TextQuantidade.TabIndex = 20;
            // 
            // textNomeProduto
            // 
            textNomeProduto.Location = new Point(279, 67);
            textNomeProduto.Margin = new Padding(2, 3, 2, 3);
            textNomeProduto.Name = "textNomeProduto";
            textNomeProduto.Size = new Size(228, 27);
            textNomeProduto.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 247);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 17;
            label5.Text = "Valor de compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 211);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 16;
            label4.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(166, 173);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 15;
            label3.Text = "Quantidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 69);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 14;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(178, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 13;
            label1.Text = "Cadastro de produto";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.camera_fotografica;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(9, 67);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LawnGreen;
            button1.Location = new Point(415, 279);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(90, 31);
            button1.TabIndex = 24;
            button1.Text = "salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(166, 123);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 25;
            label7.Text = "Categoria:";
            // 
            // textCategoria
            // 
            textCategoria.Location = new Point(279, 119);
            textCategoria.Margin = new Padding(2, 3, 2, 3);
            textCategoria.Name = "textCategoria";
            textCategoria.Size = new Size(228, 27);
            textCategoria.TabIndex = 26;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ilustracao_da_cidade_anime;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(507, 331);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 287);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 28;
            label6.Text = "Valor de venda:";
            // 
            // textVenda
            // 
            textVenda.Location = new Point(166, 279);
            textVenda.Margin = new Padding(2, 3, 2, 3);
            textVenda.Name = "textVenda";
            textVenda.Size = new Size(154, 27);
            textVenda.TabIndex = 29;
            // 
            // textId
            // 
            textId.Location = new Point(460, 240);
            textId.Margin = new Padding(2, 3, 2, 3);
            textId.Name = "textId";
            textId.Size = new Size(45, 27);
            textId.TabIndex = 30;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textId);
            Controls.Add(textVenda);
            Controls.Add(label6);
            Controls.Add(textCategoria);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(textValorCompra);
            Controls.Add(textCodigo);
            Controls.Add(TextQuantidade);
            Controls.Add(textNomeProduto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Cadastro";
            Size = new Size(507, 331);
            Load += Cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textValorCompra;
        private MaskedTextBox textCodigo;
        private MaskedTextBox TextQuantidade;
        private TextBox textNomeProduto;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label7;
        private TextBox textCategoria;
        private PictureBox pictureBox2;
        private Label label6;
        private TextBox textVenda;
        private TextBox textId;
    }
}
