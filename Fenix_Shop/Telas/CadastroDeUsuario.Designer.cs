namespace Fenix_Shop.Telas
{
    partial class CadastroDeUsuario
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
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            TextBoxMaskTelefone = new MaskedTextBox();
            label8 = new Label();
            Salvar = new ReaLTaiizor.Controls.Button();
            textBox5NomeLoja = new TextBox();
            textBox4ConfirmarSenha = new TextBox();
            textBox3Senha = new TextBox();
            textBox2Email = new TextBox();
            textBox1Nome = new TextBox();
            comboBoxNivelPermissão = new ComboBox();
            TextBoxMasCpf = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1Usuario = new PictureBox();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Usuario).BeginInit();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            parrotGradientPanel1.BottomLeft = Color.White;
            parrotGradientPanel1.BottomRight = Color.White;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(pictureBox1Usuario);
            parrotGradientPanel1.Controls.Add(TextBoxMaskTelefone);
            parrotGradientPanel1.Controls.Add(label8);
            parrotGradientPanel1.Controls.Add(Salvar);
            parrotGradientPanel1.Controls.Add(textBox5NomeLoja);
            parrotGradientPanel1.Controls.Add(textBox4ConfirmarSenha);
            parrotGradientPanel1.Controls.Add(textBox3Senha);
            parrotGradientPanel1.Controls.Add(textBox2Email);
            parrotGradientPanel1.Controls.Add(textBox1Nome);
            parrotGradientPanel1.Controls.Add(comboBoxNivelPermissão);
            parrotGradientPanel1.Controls.Add(TextBoxMasCpf);
            parrotGradientPanel1.Controls.Add(label7);
            parrotGradientPanel1.Controls.Add(label6);
            parrotGradientPanel1.Controls.Add(label5);
            parrotGradientPanel1.Controls.Add(label4);
            parrotGradientPanel1.Controls.Add(label3);
            parrotGradientPanel1.Controls.Add(label2);
            parrotGradientPanel1.Controls.Add(label1);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Margin = new Padding(3, 2, 3, 2);
            parrotGradientPanel1.MinimumSize = new Size(926, 670);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(926, 670);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            parrotGradientPanel1.TabIndex = 0;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.White;
            parrotGradientPanel1.TopRight = Color.FromArgb(192, 192, 255);
            // 
            // TextBoxMaskTelefone
            // 
            TextBoxMaskTelefone.Anchor = AnchorStyles.Left;
            TextBoxMaskTelefone.Location = new Point(478, 190);
            TextBoxMaskTelefone.Margin = new Padding(3, 2, 3, 2);
            TextBoxMaskTelefone.Mask = "(00) 0000-0000";
            TextBoxMaskTelefone.Name = "TextBoxMaskTelefone";
            TextBoxMaskTelefone.Size = new Size(230, 23);
            TextBoxMaskTelefone.TabIndex = 40;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(449, 152);
            label8.Name = "label8";
            label8.Size = new Size(96, 23);
            label8.TabIndex = 39;
            label8.Text = "Telefone:";
            // 
            // Salvar
            // 
            Salvar.Anchor = AnchorStyles.Left;
            Salvar.BackColor = Color.Transparent;
            Salvar.BorderColor = Color.Black;
            Salvar.EnteredBorderColor = Color.Black;
            Salvar.EnteredColor = Color.FromArgb(0, 64, 0);
            Salvar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Salvar.Image = null;
            Salvar.ImageAlign = ContentAlignment.MiddleLeft;
            Salvar.InactiveColor = Color.Green;
            Salvar.Location = new Point(635, 539);
            Salvar.Name = "Salvar";
            Salvar.PressedBorderColor = Color.Black;
            Salvar.PressedColor = Color.Lime;
            Salvar.RightToLeft = RightToLeft.No;
            Salvar.Size = new Size(73, 26);
            Salvar.TabIndex = 38;
            Salvar.Text = "Salvar";
            Salvar.TextAlignment = StringAlignment.Center;
            Salvar.Click += Salvar_Click;
            // 
            // textBox5NomeLoja
            // 
            textBox5NomeLoja.Anchor = AnchorStyles.Left;
            textBox5NomeLoja.Location = new Point(478, 296);
            textBox5NomeLoja.Name = "textBox5NomeLoja";
            textBox5NomeLoja.Size = new Size(230, 23);
            textBox5NomeLoja.TabIndex = 36;
            // 
            // textBox4ConfirmarSenha
            // 
            textBox4ConfirmarSenha.Location = new Point(74, 510);
            textBox4ConfirmarSenha.Name = "textBox4ConfirmarSenha";
            textBox4ConfirmarSenha.Size = new Size(230, 23);
            textBox4ConfirmarSenha.TabIndex = 35;
            // 
            // textBox3Senha
            // 
            textBox3Senha.Anchor = AnchorStyles.Left;
            textBox3Senha.Location = new Point(68, 403);
            textBox3Senha.Name = "textBox3Senha";
            textBox3Senha.Size = new Size(230, 23);
            textBox3Senha.TabIndex = 34;
            // 
            // textBox2Email
            // 
            textBox2Email.Location = new Point(74, 295);
            textBox2Email.Name = "textBox2Email";
            textBox2Email.Size = new Size(230, 23);
            textBox2Email.TabIndex = 33;
            // 
            // textBox1Nome
            // 
            textBox1Nome.Location = new Point(74, 200);
            textBox1Nome.Name = "textBox1Nome";
            textBox1Nome.Size = new Size(230, 23);
            textBox1Nome.TabIndex = 32;
            // 
            // comboBoxNivelPermissão
            // 
            comboBoxNivelPermissão.Anchor = AnchorStyles.Left;
            comboBoxNivelPermissão.FormattingEnabled = true;
            comboBoxNivelPermissão.Location = new Point(478, 391);
            comboBoxNivelPermissão.Margin = new Padding(3, 2, 3, 2);
            comboBoxNivelPermissão.Name = "comboBoxNivelPermissão";
            comboBoxNivelPermissão.Size = new Size(230, 23);
            comboBoxNivelPermissão.TabIndex = 31;
            // 
            // TextBoxMasCpf
            // 
            TextBoxMasCpf.Location = new Point(74, 602);
            TextBoxMasCpf.Margin = new Padding(3, 2, 3, 2);
            TextBoxMasCpf.Mask = "000-000-000,00";
            TextBoxMasCpf.Name = "TextBoxMasCpf";
            TextBoxMasCpf.Size = new Size(230, 23);
            TextBoxMasCpf.TabIndex = 30;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(449, 349);
            label7.Name = "label7";
            label7.Size = new Size(191, 23);
            label7.TabIndex = 6;
            label7.Text = "Tipo de permissão:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(449, 247);
            label6.Name = "label6";
            label6.Size = new Size(141, 23);
            label6.TabIndex = 5;
            label6.Text = "Nome Da loja:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 560);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 4;
            label5.Text = "Cpf:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 451);
            label4.Name = "label4";
            label4.Size = new Size(173, 23);
            label4.TabIndex = 3;
            label4.Text = "Confirmar senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 349);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 253);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 151);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 0;
            label1.Text = "Nome completo:";
            // 
            // pictureBox1Usuario
            // 
            pictureBox1Usuario.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1Usuario.Location = new Point(52, 23);
            pictureBox1Usuario.Name = "pictureBox1Usuario";
            pictureBox1Usuario.Size = new Size(100, 100);
            pictureBox1Usuario.TabIndex = 41;
            pictureBox1Usuario.TabStop = false;
            // 
            // CadastroDeUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parrotGradientPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroDeUsuario";
            Size = new Size(926, 670);
            Load += CadastroDeUsuario_Load;
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Usuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxNivelPermissão;
        private MaskedTextBox TextBoxMasCpf;
        private TextBox textBox5NomeLoja;
        private TextBox textBox4ConfirmarSenha;
        private TextBox textBox3Senha;
        private TextBox textBox2Email;
        private TextBox textBox1Nome;
        private ReaLTaiizor.Controls.Button Salvar;
        private MaskedTextBox TextBoxMaskTelefone;
        private Label label8;
        private PictureBox pictureBox1Usuario;
    }
}
