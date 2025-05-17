namespace TrabalhoSenai.Telas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoCadastro));
            PanelCadastro = new Panel();
            pictureBox2 = new PictureBox();
            textConfSenha = new TextBox();
            label6 = new Label();
            textCpf = new MaskedTextBox();
            label5 = new Label();
            button1 = new Button();
            textSenha = new TextBox();
            textEmail = new TextBox();
            textTelefone = new MaskedTextBox();
            textNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textNomeUsuario = new TextBox();
            label7 = new Label();
            PanelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelCadastro
            // 
            PanelCadastro.Controls.Add(textNomeUsuario);
            PanelCadastro.Controls.Add(label7);
            PanelCadastro.Controls.Add(pictureBox2);
            PanelCadastro.Controls.Add(textConfSenha);
            PanelCadastro.Controls.Add(label6);
            PanelCadastro.Controls.Add(textCpf);
            PanelCadastro.Controls.Add(label5);
            PanelCadastro.Controls.Add(button1);
            PanelCadastro.Controls.Add(textSenha);
            PanelCadastro.Controls.Add(textEmail);
            PanelCadastro.Controls.Add(textTelefone);
            PanelCadastro.Controls.Add(textNome);
            PanelCadastro.Controls.Add(label4);
            PanelCadastro.Controls.Add(label3);
            PanelCadastro.Controls.Add(label1);
            PanelCadastro.Controls.Add(label2);
            PanelCadastro.Controls.Add(pictureBox1);
            PanelCadastro.Location = new Point(0, 0);
            PanelCadastro.Margin = new Padding(2, 3, 2, 3);
            PanelCadastro.Name = "PanelCadastro";
            PanelCadastro.Size = new Size(654, 331);
            PanelCadastro.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.de_volta;
            pictureBox2.Location = new Point(3, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // textConfSenha
            // 
            textConfSenha.Location = new Point(417, 207);
            textConfSenha.Margin = new Padding(2, 3, 2, 3);
            textConfSenha.Name = "textConfSenha";
            textConfSenha.Size = new Size(171, 27);
            textConfSenha.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(417, 171);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(165, 24);
            label6.TabIndex = 25;
            label6.Text = "Confirmar senha:";
            // 
            // textCpf
            // 
            textCpf.Location = new Point(72, 207);
            textCpf.Margin = new Padding(2, 3, 2, 3);
            textCpf.Mask = "000-000-000-00";
            textCpf.Name = "textCpf";
            textCpf.Size = new Size(121, 27);
            textCpf.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 171);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 24);
            label5.TabIndex = 23;
            label5.Text = "Cpf:";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(498, 282);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(90, 32);
            button1.TabIndex = 22;
            button1.Text = "Finalizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(417, 132);
            textSenha.Margin = new Padding(2, 3, 2, 3);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(171, 27);
            textSenha.TabIndex = 20;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(72, 132);
            textEmail.Margin = new Padding(2, 3, 2, 3);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(311, 27);
            textEmail.TabIndex = 19;
            // 
            // textTelefone
            // 
            textTelefone.Location = new Point(417, 56);
            textTelefone.Margin = new Padding(2, 3, 2, 3);
            textTelefone.Mask = "(00)00000-0000";
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(121, 27);
            textTelefone.TabIndex = 18;
            // 
            // textNome
            // 
            textNome.Location = new Point(72, 56);
            textNome.Margin = new Padding(2, 3, 2, 3);
            textNome.Name = "textNome";
            textNome.Size = new Size(311, 27);
            textNome.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(417, 16);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 24);
            label4.TabIndex = 16;
            label4.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 16);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 24);
            label3.TabIndex = 15;
            label3.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(417, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 14;
            label1.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 24);
            label2.TabIndex = 13;
            label2.Text = "Criar email:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(654, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // textNomeUsuario
            // 
            textNomeUsuario.Location = new Point(72, 287);
            textNomeUsuario.Margin = new Padding(2, 3, 2, 3);
            textNomeUsuario.Name = "textNomeUsuario";
            textNomeUsuario.Size = new Size(254, 27);
            textNomeUsuario.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(61, 242);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(169, 24);
            label7.TabIndex = 29;
            label7.Text = "Nome de usuario:";
            // 
            // NovoCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(PanelCadastro);
            Margin = new Padding(2, 3, 2, 3);
            Name = "NovoCadastro";
            Size = new Size(654, 331);
            Load += NovoCadastro_Load;
            PanelCadastro.ResumeLayout(false);
            PanelCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelCadastro;
        private Button button1;
        private TextBox textSenha;
        private TextBox textEmail;
        private MaskedTextBox textTelefone;
        private TextBox textNome;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox textConfSenha;
        private Label label6;
        private MaskedTextBox textCpf;
        private PictureBox pictureBox2;
        private TextBox textNomeUsuario;
        private Label label7;
    }
}
