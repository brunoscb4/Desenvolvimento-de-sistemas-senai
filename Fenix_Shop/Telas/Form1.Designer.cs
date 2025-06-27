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
            PanelDeLogin = new ReaLTaiizor.Controls.ParrotGradientPanel();
            label1 = new Label();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            Login = new ReaLTaiizor.Controls.Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelLogin.SuspendLayout();
            PanelDeLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            parrotGradientPanel1.BottomLeft = Color.Black;
            parrotGradientPanel1.BottomRight = Color.FromArgb(192, 192, 255);
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
            parrotGradientPanel1.TopLeft = Color.FromArgb(192, 192, 255);
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
            PanelLogin.BottomLeft = Color.White;
            PanelLogin.BottomRight = Color.FromArgb(192, 192, 255);
            PanelLogin.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            PanelLogin.Controls.Add(PanelDeLogin);
            PanelLogin.Dock = DockStyle.Fill;
            PanelLogin.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            PanelLogin.Location = new Point(0, 30);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            PanelLogin.PrimerColor = Color.White;
            PanelLogin.Size = new Size(1200, 670);
            PanelLogin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PanelLogin.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            PanelLogin.TabIndex = 2;
            PanelLogin.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            PanelLogin.TopLeft = Color.FromArgb(192, 192, 255);
            PanelLogin.TopRight = Color.Black;
            // 
            // PanelDeLogin
            // 
            PanelDeLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelDeLogin.BottomLeft = Color.White;
            PanelDeLogin.BottomRight = Color.FromArgb(192, 192, 255);
            PanelDeLogin.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            PanelDeLogin.Controls.Add(label1);
            PanelDeLogin.Controls.Add(bigLabel1);
            PanelDeLogin.Controls.Add(Login);
            PanelDeLogin.Controls.Add(pictureBox1);
            PanelDeLogin.Controls.Add(label2);
            PanelDeLogin.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            PanelDeLogin.Location = new Point(332, 52);
            PanelDeLogin.Margin = new Padding(3, 2, 3, 2);
            PanelDeLogin.MaximumSize = new Size(700, 620);
            PanelDeLogin.MinimumSize = new Size(564, 537);
            PanelDeLogin.Name = "PanelDeLogin";
            PanelDeLogin.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            PanelDeLogin.PrimerColor = Color.White;
            PanelDeLogin.Size = new Size(564, 537);
            PanelDeLogin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PanelDeLogin.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            PanelDeLogin.TabIndex = 8;
            PanelDeLogin.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            PanelDeLogin.TopLeft = Color.FromArgb(192, 192, 255);
            PanelDeLogin.TopRight = Color.FromArgb(192, 192, 255);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(84, 297);
            label1.Name = "label1";
            label1.Size = new Size(68, 24);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // bigLabel1
            // 
            bigLabel1.Anchor = AnchorStyles.Top;
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(174, 43);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(173, 37);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Fenix shop";
            // 
            // Login
            // 
            Login.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Login.BackColor = Color.Transparent;
            Login.BorderColor = Color.Black;
            Login.EnteredBorderColor = Color.Black;
            Login.EnteredColor = Color.FromArgb(0, 64, 0);
            Login.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.Image = null;
            Login.ImageAlign = ContentAlignment.MiddleLeft;
            Login.InactiveColor = Color.Green;
            Login.Location = new Point(378, 474);
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
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.img_Fenix_Shop;
            pictureBox1.Location = new Point(84, 80);
            pictureBox1.MaximumSize = new Size(612, 338);
            pictureBox1.MinimumSize = new Size(391, 240);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(84, 381);
            label2.Name = "label2";
            label2.Size = new Size(76, 24);
            label2.TabIndex = 2;
            label2.Text = "Senha:";
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
            Load += Form1_Load;
            parrotGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelLogin.ResumeLayout(false);
            PanelDeLogin.ResumeLayout(false);
            PanelDeLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.ParrotGradientPanel PanelLogin;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.Button Login;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private ReaLTaiizor.Controls.ParrotGradientPanel PanelDeLogin;
    }
}
