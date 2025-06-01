namespace Projeto_03
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelLogin = new Panel();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            textBoxSenha = new TextBox();
            textBoxEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 28);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(585, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.botao_fechar;
            pictureBox1.Location = new Point(630, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Honeydew;
            panelLogin.Controls.Add(button1);
            panelLogin.Controls.Add(label4);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(textBoxSenha);
            panelLogin.Controls.Add(textBoxEmail);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 28);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(670, 422);
            panelLogin.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(376, 350);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(332, 286);
            label4.Name = "label4";
            label4.Size = new Size(66, 16);
            label4.TabIndex = 5;
            label4.Text = "Cadastrar!";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(238, 286);
            label3.Name = "label3";
            label3.Size = new Size(88, 16);
            label3.TabIndex = 4;
            label3.Text = "Novo usuario?";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(208, 205);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(243, 23);
            textBoxSenha.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(208, 134);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(243, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(189, 172);
            label2.Name = "label2";
            label2.Size = new Size(57, 18);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 93);
            label1.Name = "label1";
            label1.Size = new Size(52, 18);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 450);
            Controls.Add(panelLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelLogin;
        private Label label1;
        private Button button1;
        private Label label4;
        private Label label3;
        private TextBox textBoxSenha;
        private TextBox textBoxEmail;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
