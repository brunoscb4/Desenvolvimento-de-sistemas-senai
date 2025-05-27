namespace ControContatos.Telas
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
            panel1 = new Panel();
            button1 = new Button();
            TextBoxMaskTelefone = new MaskedTextBox();
            TextBoxMaskCpf = new MaskedTextBox();
            textBoxEmail = new TextBox();
            textBoxNome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            textBoxSenha = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(textBoxSenha);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(TextBoxMaskTelefone);
            panel1.Controls.Add(TextBoxMaskCpf);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxNome);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 463);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(286, 408);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 9;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TextBoxMaskTelefone
            // 
            TextBoxMaskTelefone.Location = new Point(47, 345);
            TextBoxMaskTelefone.Mask = "(00)00000-0000";
            TextBoxMaskTelefone.Name = "TextBoxMaskTelefone";
            TextBoxMaskTelefone.Size = new Size(143, 23);
            TextBoxMaskTelefone.TabIndex = 8;
            // 
            // TextBoxMaskCpf
            // 
            TextBoxMaskCpf.Location = new Point(47, 270);
            TextBoxMaskCpf.Mask = "000.000.000-00";
            TextBoxMaskCpf.Name = "TextBoxMaskCpf";
            TextBoxMaskCpf.Size = new Size(143, 23);
            TextBoxMaskCpf.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(47, 195);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(283, 23);
            textBoxEmail.TabIndex = 6;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(47, 124);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(283, 23);
            textBoxNome.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 305);
            label5.Name = "label5";
            label5.Size = new Size(70, 18);
            label5.TabIndex = 4;
            label5.Text = "Telefone:";
            label5.Click += label5_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 232);
            label4.Name = "label4";
            label4.Size = new Size(37, 18);
            label4.TabIndex = 3;
            label4.Text = "Cpf:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 162);
            label3.Name = "label3";
            label3.Size = new Size(52, 18);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 94);
            label2.Name = "label2";
            label2.Size = new Size(54, 18);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(97, 15);
            label1.Name = "label1";
            label1.Size = new Size(163, 27);
            label1.TabIndex = 0;
            label1.Text = "Novo cadastro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 385);
            label6.Name = "label6";
            label6.Size = new Size(57, 18);
            label6.TabIndex = 10;
            label6.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(47, 411);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(143, 23);
            textBoxSenha.TabIndex = 11;
            // 
            // NovoCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "NovoCadastro";
            Size = new Size(400, 463);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private MaskedTextBox TextBoxMaskCpf;
        private TextBox textBoxEmail;
        private TextBox textBoxNome;
        private Label label5;
        private MaskedTextBox TextBoxMaskTelefone;
        private Button button1;
        private TextBox textBoxSenha;
        private Label label6;
    }
}
