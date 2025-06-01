namespace Projeto_03.Telas
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
            panelCadastro = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            textBoxSenha = new TextBox();
            label6 = new Label();
            TextBoxTelefone = new MaskedTextBox();
            label5 = new Label();
            TextBoxMaskCpf = new MaskedTextBox();
            label4 = new Label();
            textBoxNomeUser = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label2 = new Label();
            textBoxNome = new TextBox();
            label1 = new Label();
            panelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelCadastro
            // 
            panelCadastro.BackColor = Color.PaleTurquoise;
            panelCadastro.Controls.Add(button1);
            panelCadastro.Controls.Add(pictureBox1);
            panelCadastro.Controls.Add(label7);
            panelCadastro.Controls.Add(textBoxSenha);
            panelCadastro.Controls.Add(label6);
            panelCadastro.Controls.Add(TextBoxTelefone);
            panelCadastro.Controls.Add(label5);
            panelCadastro.Controls.Add(TextBoxMaskCpf);
            panelCadastro.Controls.Add(label4);
            panelCadastro.Controls.Add(textBoxNomeUser);
            panelCadastro.Controls.Add(label3);
            panelCadastro.Controls.Add(textBoxEmail);
            panelCadastro.Controls.Add(label2);
            panelCadastro.Controls.Add(textBoxNome);
            panelCadastro.Controls.Add(label1);
            panelCadastro.Dock = DockStyle.Fill;
            panelCadastro.Location = new Point(0, 0);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Size = new Size(670, 422);
            panelCadastro.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.Location = new Point(490, 372);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 14;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.volte;
            pictureBox1.Location = new Point(16, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Lime;
            label7.Location = new Point(282, 16);
            label7.Name = "label7";
            label7.Size = new Size(65, 29);
            label7.TabIndex = 12;
            label7.Text = "Login";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(430, 202);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(135, 23);
            textBoxSenha.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(410, 164);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 10;
            label6.Text = "Senha:";
            // 
            // TextBoxTelefone
            // 
            TextBoxTelefone.Location = new Point(430, 112);
            TextBoxTelefone.Mask = "(00)00000-0000";
            TextBoxTelefone.Name = "TextBoxTelefone";
            TextBoxTelefone.Size = new Size(135, 23);
            TextBoxTelefone.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(410, 74);
            label5.Name = "label5";
            label5.Size = new Size(80, 19);
            label5.TabIndex = 8;
            label5.Text = "Telefone;";
            // 
            // TextBoxMaskCpf
            // 
            TextBoxMaskCpf.Location = new Point(114, 373);
            TextBoxMaskCpf.Mask = "000,000,000,-00";
            TextBoxMaskCpf.Name = "TextBoxMaskCpf";
            TextBoxMaskCpf.Size = new Size(135, 23);
            TextBoxMaskCpf.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 329);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 6;
            label4.Text = "Cpf:";
            // 
            // textBoxNomeUser
            // 
            textBoxNomeUser.Location = new Point(114, 285);
            textBoxNomeUser.Name = "textBoxNomeUser";
            textBoxNomeUser.Size = new Size(228, 23);
            textBoxNomeUser.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(99, 247);
            label3.Name = "label3";
            label3.Size = new Size(122, 19);
            label3.TabIndex = 4;
            label3.Text = "Nome usuario:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(114, 202);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(228, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 164);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(114, 112);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(228, 23);
            textBoxNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 74);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // NovoCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelCadastro);
            Name = "NovoCadastro";
            Size = new Size(670, 422);
            panelCadastro.ResumeLayout(false);
            panelCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCadastro;
        private Label label4;
        private TextBox textBoxNomeUser;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label2;
        private TextBox textBoxNome;
        private Label label1;
        private MaskedTextBox TextBoxMaskCpf;
        private MaskedTextBox TextBoxTelefone;
        private Label label5;
        private TextBox textBoxSenha;
        private Label label6;
        private Label label7;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
