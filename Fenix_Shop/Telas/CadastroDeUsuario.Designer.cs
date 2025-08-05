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
            label9 = new Label();
            pictureBox1Usuario = new PictureBox();
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
            parrotGradientPanel1.Controls.Add(label9);
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
            parrotGradientPanel1.MinimumSize = new Size(1058, 893);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(1058, 893);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            parrotGradientPanel1.TabIndex = 0;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.White;
            parrotGradientPanel1.TopRight = Color.FromArgb(64, 64, 64);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Calibri", 13.8F);
            label9.Location = new Point(693, 605);
            label9.Name = "label9";
            label9.Size = new Size(200, 28);
            label9.TabIndex = 43;
            label9.Text = "Permissões de Telas:";
            // 
            // pictureBox1Usuario
            // 
            pictureBox1Usuario.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1Usuario.Location = new Point(111, 56);
            pictureBox1Usuario.Margin = new Padding(3, 4, 3, 4);
            pictureBox1Usuario.Name = "pictureBox1Usuario";
            pictureBox1Usuario.Size = new Size(114, 133);
            pictureBox1Usuario.TabIndex = 41;
            pictureBox1Usuario.TabStop = false;
            pictureBox1Usuario.Click += pictureBox1Usuario_Click;
            // 
            // TextBoxMaskTelefone
            // 
            TextBoxMaskTelefone.Font = new Font("Cambria", 12F);
            TextBoxMaskTelefone.Location = new Point(726, 276);
            TextBoxMaskTelefone.Mask = "(00) 0000-0000";
            TextBoxMaskTelefone.Name = "TextBoxMaskTelefone";
            TextBoxMaskTelefone.Size = new Size(211, 31);
            TextBoxMaskTelefone.TabIndex = 40;
            TextBoxMaskTelefone.Click += TextBoxMaskTelefone_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Calibri", 13.8F);
            label8.Location = new Point(693, 227);
            label8.Name = "label8";
            label8.Size = new Size(96, 28);
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
            Salvar.Location = new Point(854, 820);
            Salvar.Margin = new Padding(3, 4, 3, 4);
            Salvar.Name = "Salvar";
            Salvar.PressedBorderColor = Color.Black;
            Salvar.PressedColor = Color.Lime;
            Salvar.RightToLeft = RightToLeft.No;
            Salvar.Size = new Size(83, 35);
            Salvar.TabIndex = 38;
            Salvar.Text = "Salvar";
            Salvar.TextAlignment = StringAlignment.Center;
            Salvar.Click += Salvar_Click;
            // 
            // textBox5NomeLoja
            // 
            textBox5NomeLoja.Font = new Font("Cambria", 12F);
            textBox5NomeLoja.Location = new Point(726, 419);
            textBox5NomeLoja.Margin = new Padding(3, 4, 3, 4);
            textBox5NomeLoja.Name = "textBox5NomeLoja";
            textBox5NomeLoja.Size = new Size(211, 31);
            textBox5NomeLoja.TabIndex = 36;
            // 
            // textBox4ConfirmarSenha
            // 
            textBox4ConfirmarSenha.Font = new Font("Cambria", 12F);
            textBox4ConfirmarSenha.Location = new Point(137, 705);
            textBox4ConfirmarSenha.Margin = new Padding(3, 4, 3, 4);
            textBox4ConfirmarSenha.Name = "textBox4ConfirmarSenha";
            textBox4ConfirmarSenha.Size = new Size(262, 31);
            textBox4ConfirmarSenha.TabIndex = 35;
            // 
            // textBox3Senha
            // 
            textBox3Senha.Font = new Font("Cambria", 12F);
            textBox3Senha.Location = new Point(130, 563);
            textBox3Senha.Margin = new Padding(3, 4, 3, 4);
            textBox3Senha.Name = "textBox3Senha";
            textBox3Senha.Size = new Size(262, 31);
            textBox3Senha.TabIndex = 34;
            // 
            // textBox2Email
            // 
            textBox2Email.Font = new Font("Cambria", 12F);
            textBox2Email.Location = new Point(137, 419);
            textBox2Email.Margin = new Padding(3, 4, 3, 4);
            textBox2Email.Name = "textBox2Email";
            textBox2Email.Size = new Size(262, 31);
            textBox2Email.TabIndex = 33;
            // 
            // textBox1Nome
            // 
            textBox1Nome.Font = new Font("Cambria", 12F);
            textBox1Nome.Location = new Point(137, 292);
            textBox1Nome.Margin = new Padding(3, 4, 3, 4);
            textBox1Nome.Name = "textBox1Nome";
            textBox1Nome.Size = new Size(262, 31);
            textBox1Nome.TabIndex = 32;
            // 
            // comboBoxNivelPermissão
            // 
            comboBoxNivelPermissão.Font = new Font("Cambria", 12F);
            comboBoxNivelPermissão.FormattingEnabled = true;
            comboBoxNivelPermissão.Location = new Point(726, 544);
            comboBoxNivelPermissão.Name = "comboBoxNivelPermissão";
            comboBoxNivelPermissão.Size = new Size(211, 31);
            comboBoxNivelPermissão.TabIndex = 31;
            // 
            // TextBoxMasCpf
            // 
            TextBoxMasCpf.Location = new Point(137, 828);
            TextBoxMasCpf.Mask = "000-000-000,00";
            TextBoxMasCpf.Name = "TextBoxMasCpf";
            TextBoxMasCpf.Size = new Size(262, 27);
            TextBoxMasCpf.TabIndex = 30;
            TextBoxMasCpf.Click += TextBoxMasCpf_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Calibri", 13.8F);
            label7.Location = new Point(693, 488);
            label7.Name = "label7";
            label7.Size = new Size(186, 28);
            label7.TabIndex = 6;
            label7.Text = "Tipo de permissão:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Calibri", 13.8F);
            label6.Location = new Point(693, 352);
            label6.Name = "label6";
            label6.Size = new Size(143, 28);
            label6.TabIndex = 5;
            label6.Text = "Nome Da loja:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 13.8F);
            label5.Location = new Point(122, 772);
            label5.Name = "label5";
            label5.Size = new Size(49, 28);
            label5.TabIndex = 4;
            label5.Text = "Cpf:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 13.8F);
            label4.Location = new Point(111, 627);
            label4.Name = "label4";
            label4.Size = new Size(171, 28);
            label4.TabIndex = 3;
            label4.Text = "Confirmar senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 13.8F);
            label3.Location = new Point(111, 491);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 13.8F);
            label2.Location = new Point(111, 363);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 13.8F);
            label1.Location = new Point(111, 227);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 0;
            label1.Text = "Nome completo:";
            // 
            // CadastroDeUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parrotGradientPanel1);
            Name = "CadastroDeUsuario";
            Size = new Size(1058, 893);
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
        private Label label9;
    }
}
