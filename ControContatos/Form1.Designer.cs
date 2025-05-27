namespace ControContatos
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelLogin = new Panel();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            textBoxSenha = new TextBox();
            textBoxEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 37);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.menos;
            pictureBox2.Location = new Point(312, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.botao_fechar;
            pictureBox1.Location = new Point(358, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 7);
            label1.Name = "label1";
            label1.Size = new Size(232, 27);
            label1.TabIndex = 0;
            label1.Text = "Registro de contatos";
            // 
            // panelLogin
            // 
            panelLogin.BackColor = SystemColors.GradientInactiveCaption;
            panelLogin.Controls.Add(button1);
            panelLogin.Controls.Add(label6);
            panelLogin.Controls.Add(label5);
            panelLogin.Controls.Add(textBoxSenha);
            panelLogin.Controls.Add(textBoxEmail);
            panelLogin.Controls.Add(label4);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 37);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(400, 463);
            panelLogin.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(264, 298);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.ForestGreen;
            label6.Location = new Point(167, 361);
            label6.Name = "label6";
            label6.Size = new Size(63, 16);
            label6.TabIndex = 6;
            label6.Text = "Cadastrar";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 330);
            label5.Name = "label5";
            label5.Size = new Size(88, 16);
            label5.TabIndex = 5;
            label5.Text = "Novo usuario?";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(58, 247);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(269, 23);
            textBoxSenha.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(58, 170);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(269, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(147, 214);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 2;
            label4.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(147, 127);
            label3.Name = "label3";
            label3.Size = new Size(52, 18);
            label3.TabIndex = 1;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(147, 19);
            label2.Name = "label2";
            label2.Size = new Size(71, 27);
            label2.TabIndex = 0;
            label2.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 500);
            Controls.Add(panelLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "  ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panelLogin;
        private TextBox textBoxEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox textBoxSenha;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
