namespace Projeto_05.Telas
{
    partial class NovoCadastro
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
            panelNovoCadastro = new Panel();
            label6 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBoxSenha = new TextBox();
            TextBoxMaskTelefone = new MaskedTextBox();
            TextBoxMaskCpf = new MaskedTextBox();
            textBoxEmail = new TextBox();
            textBoxNome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelNovoCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelNovoCadastro
            // 
            panelNovoCadastro.BackColor = Color.Honeydew;
            panelNovoCadastro.Controls.Add(label6);
            panelNovoCadastro.Controls.Add(button1);
            panelNovoCadastro.Controls.Add(pictureBox1);
            panelNovoCadastro.Controls.Add(textBoxSenha);
            panelNovoCadastro.Controls.Add(TextBoxMaskTelefone);
            panelNovoCadastro.Controls.Add(TextBoxMaskCpf);
            panelNovoCadastro.Controls.Add(textBoxEmail);
            panelNovoCadastro.Controls.Add(textBoxNome);
            panelNovoCadastro.Controls.Add(label5);
            panelNovoCadastro.Controls.Add(label4);
            panelNovoCadastro.Controls.Add(label3);
            panelNovoCadastro.Controls.Add(label2);
            panelNovoCadastro.Controls.Add(label1);
            panelNovoCadastro.Dock = DockStyle.Fill;
            panelNovoCadastro.Location = new Point(0, 0);
            panelNovoCadastro.Name = "panelNovoCadastro";
            panelNovoCadastro.Size = new Size(632, 631);
            panelNovoCadastro.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(229, 15);
            label6.Name = "label6";
            label6.Size = new Size(190, 37);
            label6.TabIndex = 12;
            label6.Text = "Novo cadastro";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(406, 559);
            button1.Name = "button1";
            button1.Size = new Size(113, 29);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.volte;
            pictureBox1.Location = new Point(19, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(182, 485);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(180, 27);
            textBoxSenha.TabIndex = 9;
            // 
            // TextBoxMaskTelefone
            // 
            TextBoxMaskTelefone.Location = new Point(182, 384);
            TextBoxMaskTelefone.Mask = "(00)00000-0000";
            TextBoxMaskTelefone.Name = "TextBoxMaskTelefone";
            TextBoxMaskTelefone.Size = new Size(180, 27);
            TextBoxMaskTelefone.TabIndex = 8;
            // 
            // TextBoxMaskCpf
            // 
            TextBoxMaskCpf.Location = new Point(182, 303);
            TextBoxMaskCpf.Mask = "000,000,000-00";
            TextBoxMaskCpf.Name = "TextBoxMaskCpf";
            TextBoxMaskCpf.Size = new Size(180, 27);
            TextBoxMaskCpf.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(182, 218);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(337, 27);
            textBoxEmail.TabIndex = 6;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(182, 137);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(337, 27);
            textBoxNome.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(157, 434);
            label5.Name = "label5";
            label5.Size = new Size(76, 24);
            label5.TabIndex = 4;
            label5.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(157, 347);
            label4.Name = "label4";
            label4.Size = new Size(98, 24);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(157, 259);
            label3.Name = "label3";
            label3.Size = new Size(50, 24);
            label3.TabIndex = 2;
            label3.Text = "Cpf:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(157, 176);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 100);
            label1.Name = "label1";
            label1.Size = new Size(71, 24);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // NovoCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelNovoCadastro);
            Name = "NovoCadastro";
            Size = new Size(632, 631);
            panelNovoCadastro.ResumeLayout(false);
            panelNovoCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNovoCadastro;
        private TextBox textBoxSenha;
        private MaskedTextBox TextBoxMaskTelefone;
        private MaskedTextBox TextBoxMaskCpf;
        private TextBox textBoxEmail;
        private TextBox textBoxNome;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
