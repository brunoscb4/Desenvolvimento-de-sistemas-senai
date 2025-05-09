namespace SenaiGerenciadorProdutos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            button3 = new Button();
            textSenha = new TextBox();
            textUsuarioEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 71);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.icons8_excluir_24__1_;
            button2.Location = new Point(844, 21);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(37, 26);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textSenha);
            panel2.Controls.Add(textUsuarioEmail);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 71);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 508);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(488, 425);
            button3.Name = "button3";
            button3.Size = new Size(78, 29);
            button3.TabIndex = 6;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(163, 377);
            textSenha.Margin = new Padding(3, 4, 3, 4);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(188, 27);
            textSenha.TabIndex = 4;
            // 
            // textUsuarioEmail
            // 
            textUsuarioEmail.Location = new Point(163, 233);
            textUsuarioEmail.Margin = new Padding(3, 4, 3, 4);
            textUsuarioEmail.Name = "textUsuarioEmail";
            textUsuarioEmail.Size = new Size(403, 27);
            textUsuarioEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(144, 323);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 163);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 1;
            label1.Text = "Email ou Usuario:";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(706, 456);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(175, 31);
            button1.TabIndex = 0;
            button1.Text = "Novo cadastro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(798, 21);
            button4.Name = "button4";
            button4.Size = new Size(40, 26);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 579);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private TextBox textSenha;
        private TextBox textUsuarioEmail;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
