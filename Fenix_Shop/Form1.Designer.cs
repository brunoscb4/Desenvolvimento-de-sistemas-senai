namespace Fenix_Shop
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
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            PanelLogin = new ReaLTaiizor.Controls.ParrotGradientPanel();
            metroPanel1 = new ReaLTaiizor.Controls.MetroPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Login = new ReaLTaiizor.Controls.Button();
            TextBoxSenha = new ReaLTaiizor.Controls.CyberTextBox();
            TextBoxEmail = new ReaLTaiizor.Controls.CyberTextBox();
            label2 = new Label();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelLogin.SuspendLayout();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            parrotGradientPanel1.BottomLeft = Color.Black;
            parrotGradientPanel1.BottomRight = Color.FromArgb(128, 255, 255);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(pictureBox4);
            parrotGradientPanel1.Controls.Add(pictureBox3);
            parrotGradientPanel1.Controls.Add(pictureBox2);
            parrotGradientPanel1.Dock = DockStyle.Top;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.Black;
            parrotGradientPanel1.Size = new Size(1200, 30);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 1;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.FromArgb(128, 255, 255);
            parrotGradientPanel1.TopRight = Color.Black;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.botao_fechar;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1051, -1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.botao_fechar;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1106, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.botao_fechar;
            pictureBox2.Image = Properties.Resources.botao_fechar;
            pictureBox2.Location = new Point(1159, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PanelLogin
            // 
            PanelLogin.BorderStyle = BorderStyle.FixedSingle;
            PanelLogin.BottomLeft = Color.Black;
            PanelLogin.BottomRight = Color.FromArgb(192, 255, 255);
            PanelLogin.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            PanelLogin.Controls.Add(metroPanel1);
            PanelLogin.Dock = DockStyle.Fill;
            PanelLogin.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            PanelLogin.Location = new Point(0, 30);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            PanelLogin.PrimerColor = Color.Black;
            PanelLogin.Size = new Size(1200, 670);
            PanelLogin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PanelLogin.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            PanelLogin.TabIndex = 2;
            PanelLogin.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            PanelLogin.TopLeft = Color.FromArgb(192, 255, 255);
            PanelLogin.TopRight = Color.Black;
            // 
            // metroPanel1
            // 
            metroPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            metroPanel1.AutoSize = true;
            metroPanel1.BackgroundColor = Color.White;
            metroPanel1.BorderColor = Color.FromArgb(150, 150, 150);
            metroPanel1.BorderThickness = 2;
            metroPanel1.Controls.Add(label1);
            metroPanel1.Controls.Add(pictureBox1);
            metroPanel1.Controls.Add(Login);
            metroPanel1.Controls.Add(TextBoxSenha);
            metroPanel1.Controls.Add(TextBoxEmail);
            metroPanel1.Controls.Add(label2);
            metroPanel1.Controls.Add(bigLabel1);
            metroPanel1.IsDerivedStyle = true;
            metroPanel1.Location = new Point(365, 56);
            metroPanel1.MaximumSize = new Size(632, 780);
            metroPanel1.MinimumSize = new Size(465, 547);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(465, 547);
            metroPanel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroPanel1.StyleManager = null;
            metroPanel1.TabIndex = 0;
            metroPanel1.ThemeAuthor = "Taiizor";
            metroPanel1.ThemeName = "MetroLight";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(65, 224);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.img_Fenix_Shop;
            pictureBox1.Location = new Point(111, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            Login.BackColor = Color.Transparent;
            Login.BorderColor = Color.Black;
            Login.EnteredBorderColor = Color.Black;
            Login.EnteredColor = Color.FromArgb(0, 64, 0);
            Login.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.Image = null;
            Login.ImageAlign = ContentAlignment.MiddleLeft;
            Login.InactiveColor = Color.Green;
            Login.Location = new Point(327, 464);
            Login.Name = "Login";
            Login.PressedBorderColor = Color.Black;
            Login.PressedColor = Color.Lime;
            Login.RightToLeft = RightToLeft.No;
            Login.Size = new Size(73, 26);
            Login.TabIndex = 6;
            Login.Text = "Login";
            Login.TextAlignment = StringAlignment.Center;
            Login.Click += Login_Click;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.Alpha = 20;
            TextBoxSenha.Anchor = AnchorStyles.None;
            TextBoxSenha.BackColor = Color.Transparent;
            TextBoxSenha.Background_WidthPen = 3F;
            TextBoxSenha.BackgroundPen = true;
            TextBoxSenha.ColorBackground = Color.White;
            TextBoxSenha.ColorBackground_Pen = Color.Black;
            TextBoxSenha.ColorLighting = Color.FromArgb(29, 200, 238);
            TextBoxSenha.ColorPen_1 = Color.FromArgb(29, 200, 238);
            TextBoxSenha.ColorPen_2 = Color.FromArgb(37, 52, 68);
            TextBoxSenha.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            TextBoxSenha.Font = new Font("Arial", 9F);
            TextBoxSenha.ForeColor = Color.Black;
            TextBoxSenha.Lighting = false;
            TextBoxSenha.LinearGradientPen = false;
            TextBoxSenha.Location = new Point(88, 375);
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.PenWidth = 15;
            TextBoxSenha.RGB = false;
            TextBoxSenha.Rounding = true;
            TextBoxSenha.RoundingInt = 60;
            TextBoxSenha.Size = new Size(312, 39);
            TextBoxSenha.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            TextBoxSenha.TabIndex = 5;
            TextBoxSenha.Tag = "Cyber";
            TextBoxSenha.TextButton = "";
            TextBoxSenha.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            TextBoxSenha.Timer_RGB = 300;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Alpha = 20;
            TextBoxEmail.Anchor = AnchorStyles.None;
            TextBoxEmail.BackColor = Color.Transparent;
            TextBoxEmail.Background_WidthPen = 3F;
            TextBoxEmail.BackgroundPen = true;
            TextBoxEmail.ColorBackground = Color.White;
            TextBoxEmail.ColorBackground_Pen = Color.Black;
            TextBoxEmail.ColorLighting = Color.FromArgb(29, 200, 238);
            TextBoxEmail.ColorPen_1 = Color.FromArgb(29, 200, 238);
            TextBoxEmail.ColorPen_2 = Color.FromArgb(37, 52, 68);
            TextBoxEmail.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            TextBoxEmail.Font = new Font("Arial", 9F);
            TextBoxEmail.ForeColor = Color.Black;
            TextBoxEmail.Lighting = false;
            TextBoxEmail.LinearGradientPen = false;
            TextBoxEmail.Location = new Point(88, 264);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.PenWidth = 15;
            TextBoxEmail.RGB = false;
            TextBoxEmail.Rounding = true;
            TextBoxEmail.RoundingInt = 60;
            TextBoxEmail.Size = new Size(312, 39);
            TextBoxEmail.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            TextBoxEmail.TabIndex = 4;
            TextBoxEmail.Tag = "Cyber";
            TextBoxEmail.TextButton = "";
            TextBoxEmail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            TextBoxEmail.Timer_RGB = 300;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(65, 328);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
            // 
            // bigLabel1
            // 
            bigLabel1.Anchor = AnchorStyles.Top;
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Algerian", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(131, 39);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(189, 35);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Fenix shop";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(PanelLogin);
            Controls.Add(parrotGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            parrotGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelLogin.ResumeLayout(false);
            PanelLogin.PerformLayout();
            metroPanel1.ResumeLayout(false);
            metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.ParrotGradientPanel PanelLogin;
        private ReaLTaiizor.Controls.MetroPanel metroPanel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.CyberTextBox TextBoxEmail;
        private ReaLTaiizor.Controls.Button Login;
        private ReaLTaiizor.Controls.CyberTextBox TextBoxSenha;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}
