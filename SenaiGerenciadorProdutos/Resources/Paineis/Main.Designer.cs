namespace SenaiGerenciadorProdutos.Resources.Paineis
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textNome = new TextBox();
            textEmail = new TextBox();
            TextCpf = new MaskedTextBox();
            textUsuario = new TextBox();
            textSenha = new TextBox();
            Finalizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 161);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(138, 271);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 3;
            label3.Text = "Cpf:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 386);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 4;
            label4.Text = "Nome Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(138, 502);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 5;
            label5.Text = "Senha:";
            // 
            // textNome
            // 
            textNome.BackColor = Color.FromArgb(224, 224, 224);
            textNome.Location = new Point(175, 95);
            textNome.Margin = new Padding(4, 5, 4, 5);
            textNome.Name = "textNome";
            textNome.Size = new Size(482, 31);
            textNome.TabIndex = 6;
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.FromArgb(224, 224, 224);
            textEmail.Location = new Point(175, 216);
            textEmail.Margin = new Padding(4, 5, 4, 5);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(482, 31);
            textEmail.TabIndex = 7;
            // 
            // TextCpf
            // 
            TextCpf.BackColor = Color.FromArgb(224, 224, 224);
            TextCpf.Location = new Point(175, 322);
            TextCpf.Margin = new Padding(4, 5, 4, 5);
            TextCpf.Mask = "000-000-000-00";
            TextCpf.Name = "TextCpf";
            TextCpf.Size = new Size(202, 31);
            TextCpf.TabIndex = 8;
            // 
            // textUsuario
            // 
            textUsuario.BackColor = Color.FromArgb(224, 224, 224);
            textUsuario.Location = new Point(175, 439);
            textUsuario.Margin = new Padding(4, 5, 4, 5);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(482, 31);
            textUsuario.TabIndex = 9;
            // 
            // textSenha
            // 
            textSenha.BackColor = Color.FromArgb(224, 224, 224);
            textSenha.Location = new Point(175, 559);
            textSenha.Margin = new Padding(4, 5, 4, 5);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(202, 31);
            textSenha.TabIndex = 10;
            // 
            // Finalizar
            // 
            Finalizar.BackColor = Color.Green;
            Finalizar.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Finalizar.ForeColor = Color.White;
            Finalizar.Location = new Point(695, 595);
            Finalizar.Margin = new Padding(4, 4, 4, 4);
            Finalizar.Name = "Finalizar";
            Finalizar.Size = new Size(140, 36);
            Finalizar.TabIndex = 12;
            Finalizar.Text = "Finalizar";
            Finalizar.UseVisualStyleBackColor = false;
            Finalizar.Click += Finalizar_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 635);
            Controls.Add(Finalizar);
            Controls.Add(textSenha);
            Controls.Add(textUsuario);
            Controls.Add(TextCpf);
            Controls.Add(textEmail);
            Controls.Add(textNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textNome;
        private TextBox textEmail;
        private MaskedTextBox TextCpf;
        private TextBox textUsuario;
        private TextBox textSenha;
        private Button Finalizar;
    }
}