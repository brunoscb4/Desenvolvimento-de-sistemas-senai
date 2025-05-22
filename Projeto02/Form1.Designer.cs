namespace Projeto02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel02 = new Panel();
            panelLogin = new Panel();
            label6 = new Label();
            button1 = new Button();
            textBoxSenha = new TextBox();
            textBoxEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel02.SuspendLayout();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 32);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Algerian", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(287, 9);
            label7.Name = "label7";
            label7.Size = new Size(239, 15);
            label7.TabIndex = 2;
            label7.Text = "Sistema de cadastro de jogos";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(771, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.botao_fechar;
            pictureBox2.Location = new Point(813, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel02
            // 
            panel02.Controls.Add(panelLogin);
            panel02.Controls.Add(pictureBox1);
            panel02.Dock = DockStyle.Fill;
            panel02.Location = new Point(0, 32);
            panel02.Name = "panel02";
            panel02.Size = new Size(850, 488);
            panel02.TabIndex = 2;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = SystemColors.GradientInactiveCaption;
            panelLogin.BorderStyle = BorderStyle.Fixed3D;
            panelLogin.Controls.Add(label6);
            panelLogin.Controls.Add(button1);
            panelLogin.Controls.Add(textBoxSenha);
            panelLogin.Controls.Add(textBoxEmail);
            panelLogin.Controls.Add(label5);
            panelLogin.Controls.Add(label4);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Location = new Point(237, 44);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(396, 384);
            panelLogin.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(172, 183);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 8;
            label6.Text = "Login";
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(289, 258);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(115, 213);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(145, 23);
            textBoxSenha.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(115, 142);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(237, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(198, 309);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 4;
            label5.Text = "Cadastrar";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 309);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 3;
            label4.Text = "Novo cadastro?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 180);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 106);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Emal:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 12);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.tec;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(850, 488);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 520);
            Controls.Add(panel02);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel02.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel02;
        private PictureBox pictureBox1;
        private Panel panelLogin;
        private TextBox textBoxSenha;
        private TextBox textBoxEmail;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private Label label7;
        private Label label6;
    }
}
