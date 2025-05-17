namespace TrabalhoSenai.Telas
{
    partial class Vendas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textNomeVenda = new TextBox();
            textCodigoVenda = new TextBox();
            textValorVenda = new TextBox();
            label4 = new Label();
            textCepVenda = new MaskedTextBox();
            label5 = new Label();
            textLogradouroVenda = new TextBox();
            label6 = new Label();
            textBairroVenda = new TextBox();
            label7 = new Label();
            textLocalidadeVenda = new TextBox();
            label8 = new Label();
            textUfVenda = new TextBox();
            label9 = new Label();
            textQuantidadeVenda = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 57);
            label1.Name = "label1";
            label1.Size = new Size(41, 16);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 8);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 102);
            label3.Name = "label3";
            label3.Size = new Size(38, 16);
            label3.TabIndex = 2;
            label3.Text = "Valor:";
            // 
            // textNomeVenda
            // 
            textNomeVenda.BackColor = SystemColors.InactiveCaption;
            textNomeVenda.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNomeVenda.Location = new Point(13, 76);
            textNomeVenda.Name = "textNomeVenda";
            textNomeVenda.Size = new Size(202, 23);
            textNomeVenda.TabIndex = 3;
            // 
            // textCodigoVenda
            // 
            textCodigoVenda.BackColor = SystemColors.InactiveCaption;
            textCodigoVenda.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCodigoVenda.Location = new Point(13, 27);
            textCodigoVenda.Name = "textCodigoVenda";
            textCodigoVenda.Size = new Size(107, 23);
            textCodigoVenda.TabIndex = 4;
            // 
            // textValorVenda
            // 
            textValorVenda.BackColor = SystemColors.InactiveCaption;
            textValorVenda.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textValorVenda.Location = new Point(13, 121);
            textValorVenda.Name = "textValorVenda";
            textValorVenda.Size = new Size(107, 23);
            textValorVenda.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(247, 12);
            label4.Name = "label4";
            label4.Size = new Size(84, 16);
            label4.TabIndex = 6;
            label4.Text = "Informe o cep:";
            // 
            // textCepVenda
            // 
            textCepVenda.BackColor = SystemColors.InactiveCaption;
            textCepVenda.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCepVenda.Location = new Point(247, 31);
            textCepVenda.Mask = "00000000";
            textCepVenda.Name = "textCepVenda";
            textCepVenda.Size = new Size(100, 23);
            textCepVenda.TabIndex = 7;
            textCepVenda.MaskInputRejected += textCepVenda_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(247, 57);
            label5.Name = "label5";
            label5.Size = new Size(74, 16);
            label5.TabIndex = 8;
            label5.Text = "Logradouro:";
            // 
            // textLogradouroVenda
            // 
            textLogradouroVenda.BackColor = SystemColors.InactiveCaption;
            textLogradouroVenda.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLogradouroVenda.Location = new Point(247, 76);
            textLogradouroVenda.Name = "textLogradouroVenda";
            textLogradouroVenda.Size = new Size(191, 23);
            textLogradouroVenda.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(247, 102);
            label6.Name = "label6";
            label6.Size = new Size(43, 16);
            label6.TabIndex = 10;
            label6.Text = "Bairro:";
            // 
            // textBairroVenda
            // 
            textBairroVenda.BackColor = SystemColors.InactiveCaption;
            textBairroVenda.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBairroVenda.Location = new Point(247, 121);
            textBairroVenda.Name = "textBairroVenda";
            textBairroVenda.Size = new Size(191, 23);
            textBairroVenda.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(247, 147);
            label7.Name = "label7";
            label7.Size = new Size(69, 16);
            label7.TabIndex = 12;
            label7.Text = "Localidade:";
            // 
            // textLocalidadeVenda
            // 
            textLocalidadeVenda.BackColor = SystemColors.InactiveCaption;
            textLocalidadeVenda.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLocalidadeVenda.Location = new Point(247, 166);
            textLocalidadeVenda.Name = "textLocalidadeVenda";
            textLocalidadeVenda.Size = new Size(191, 23);
            textLocalidadeVenda.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(247, 192);
            label8.Name = "label8";
            label8.Size = new Size(26, 16);
            label8.TabIndex = 14;
            label8.Text = "UF:";
            // 
            // textUfVenda
            // 
            textUfVenda.BackColor = SystemColors.InactiveCaption;
            textUfVenda.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUfVenda.Location = new Point(247, 211);
            textUfVenda.Name = "textUfVenda";
            textUfVenda.Size = new Size(100, 23);
            textUfVenda.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 147);
            label9.Name = "label9";
            label9.Size = new Size(72, 16);
            label9.TabIndex = 16;
            label9.Text = "Quantidade:";
            // 
            // textQuantidadeVenda
            // 
            textQuantidadeVenda.BackColor = SystemColors.InactiveCaption;
            textQuantidadeVenda.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textQuantidadeVenda.Location = new Point(13, 166);
            textQuantidadeVenda.Name = "textQuantidadeVenda";
            textQuantidadeVenda.Size = new Size(107, 23);
            textQuantidadeVenda.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(379, 211);
            button1.Name = "button1";
            button1.Size = new Size(59, 23);
            button1.TabIndex = 18;
            button1.Text = "Vender";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Lua;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(379, 31);
            button2.Name = "button2";
            button2.Size = new Size(59, 23);
            button2.TabIndex = 20;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textQuantidadeVenda);
            Controls.Add(label9);
            Controls.Add(textUfVenda);
            Controls.Add(label8);
            Controls.Add(textLocalidadeVenda);
            Controls.Add(label7);
            Controls.Add(textBairroVenda);
            Controls.Add(label6);
            Controls.Add(textLogradouroVenda);
            Controls.Add(label5);
            Controls.Add(textCepVenda);
            Controls.Add(label4);
            Controls.Add(textValorVenda);
            Controls.Add(textCodigoVenda);
            Controls.Add(textNomeVenda);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Vendas";
            Size = new Size(441, 246);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textNomeVenda;
        private TextBox textCodigoVenda;
        private TextBox textValorVenda;
        private Label label4;
        private MaskedTextBox textCepVenda;
        private Label label5;
        private TextBox textLogradouroVenda;
        private Label label6;
        private TextBox textBairroVenda;
        private Label label7;
        private TextBox textLocalidadeVenda;
        private Label label8;
        private TextBox textUfVenda;
        private Label label9;
        private TextBox textQuantidadeVenda;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}
