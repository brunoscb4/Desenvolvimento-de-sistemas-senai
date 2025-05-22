namespace Projeto02.Telas
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
            pictureBox2 = new PictureBox();
            button1 = new Button();
            TextBoxMaskTelefone = new MaskedTextBox();
            TextBoxMaskCpf = new MaskedTextBox();
            textBoxUsuario = new TextBox();
            textBoxEmail = new TextBox();
            textBoxNome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            textBoxSenhaUser = new TextBox();
            panelNovoCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelNovoCadastro
            // 
            panelNovoCadastro.Controls.Add(textBoxSenhaUser);
            panelNovoCadastro.Controls.Add(label6);
            panelNovoCadastro.Controls.Add(pictureBox2);
            panelNovoCadastro.Controls.Add(button1);
            panelNovoCadastro.Controls.Add(TextBoxMaskTelefone);
            panelNovoCadastro.Controls.Add(TextBoxMaskCpf);
            panelNovoCadastro.Controls.Add(textBoxUsuario);
            panelNovoCadastro.Controls.Add(textBoxEmail);
            panelNovoCadastro.Controls.Add(textBoxNome);
            panelNovoCadastro.Controls.Add(label5);
            panelNovoCadastro.Controls.Add(label4);
            panelNovoCadastro.Controls.Add(label3);
            panelNovoCadastro.Controls.Add(label2);
            panelNovoCadastro.Controls.Add(label1);
            panelNovoCadastro.Controls.Add(pictureBox1);
            panelNovoCadastro.Dock = DockStyle.Fill;
            panelNovoCadastro.Location = new Point(0, 0);
            panelNovoCadastro.Name = "panelNovoCadastro";
            panelNovoCadastro.Size = new Size(850, 488);
            panelNovoCadastro.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.volte;
            pictureBox2.Location = new Point(12, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(648, 405);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TextBoxMaskTelefone
            // 
            TextBoxMaskTelefone.Location = new Point(599, 169);
            TextBoxMaskTelefone.Mask = "(00)00000-0000";
            TextBoxMaskTelefone.Name = "TextBoxMaskTelefone";
            TextBoxMaskTelefone.Size = new Size(124, 23);
            TextBoxMaskTelefone.TabIndex = 9;
            // 
            // TextBoxMaskCpf
            // 
            TextBoxMaskCpf.Location = new Point(599, 86);
            TextBoxMaskCpf.Mask = "000-000-000-00";
            TextBoxMaskCpf.Name = "TextBoxMaskCpf";
            TextBoxMaskCpf.Size = new Size(124, 23);
            TextBoxMaskCpf.TabIndex = 8;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(84, 236);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(281, 23);
            textBoxUsuario.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(84, 156);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(281, 23);
            textBoxEmail.TabIndex = 6;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(84, 86);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(281, 23);
            textBoxNome.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(576, 132);
            label5.Name = "label5";
            label5.Size = new Size(58, 16);
            label5.TabIndex = 4;
            label5.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(576, 42);
            label4.Name = "label4";
            label4.Size = new Size(30, 16);
            label4.TabIndex = 3;
            label4.Text = "Cpf:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 199);
            label3.Name = "label3";
            label3.Size = new Size(109, 16);
            label3.TabIndex = 2;
            label3.Text = "Nome de usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 124);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 51);
            label1.Name = "label1";
            label1.Size = new Size(102, 16);
            label1.TabIndex = 0;
            label1.Text = "Nome completo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.geometric_1732847_1280;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(850, 488);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(61, 278);
            label6.Name = "label6";
            label6.Size = new Size(48, 16);
            label6.TabIndex = 13;
            label6.Text = "Senha:";
            // 
            // textBoxSenhaUser
            // 
            textBoxSenhaUser.Location = new Point(84, 319);
            textBoxSenhaUser.Name = "textBoxSenhaUser";
            textBoxSenhaUser.Size = new Size(143, 23);
            textBoxSenhaUser.TabIndex = 14;
            // 
            // NovoCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelNovoCadastro);
            Name = "NovoCadastro";
            Size = new Size(850, 488);
            panelNovoCadastro.ResumeLayout(false);
            panelNovoCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNovoCadastro;
        private TextBox textBoxUsuario;
        private TextBox textBoxEmail;
        private TextBox textBoxNome;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox TextBoxMaskTelefone;
        private MaskedTextBox TextBoxMaskCpf;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private TextBox textBoxSenhaUser;
        private Label label6;
    }
}
