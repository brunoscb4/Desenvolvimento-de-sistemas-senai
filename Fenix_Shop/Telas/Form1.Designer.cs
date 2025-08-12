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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            PanelLogin = new ReaLTaiizor.Controls.ParrotGradientPanel();
            panel1ControlerPanelLogin = new Panel();
            PanelDeLoginPrincipal = new ReaLTaiizor.Controls.ParrotGradientPanel();
            pictureBox5 = new PictureBox();
            textBox2Senha = new TextBox();
            textBox1Email = new TextBox();
            label1 = new Label();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            Login = new ReaLTaiizor.Controls.Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelLogin.SuspendLayout();
            panel1ControlerPanelLogin.SuspendLayout();
            PanelDeLoginPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            parrotGradientPanel1.BottomLeft = Color.FromArgb(64, 64, 64);
            parrotGradientPanel1.BottomRight = Color.FromArgb(64, 64, 64);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(pictureBox4);
            parrotGradientPanel1.Controls.Add(pictureBox3);
            parrotGradientPanel1.Controls.Add(pictureBox2);
            resources.ApplyResources(parrotGradientPanel1, "parrotGradientPanel1");
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.Black;
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.Silver;
            parrotGradientPanel1.TopRight = Color.Black;
            parrotGradientPanel1.MouseDown += parrotGradientPanel1_MouseDown;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.botao_fechar;
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.botao_fechar;
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.botao_fechar;
            pictureBox2.Image = Properties.Resources.botao_fechar;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // PanelLogin
            // 
            PanelLogin.BorderStyle = BorderStyle.FixedSingle;
            PanelLogin.BottomLeft = Color.Black;
            PanelLogin.BottomRight = Color.FromArgb(192, 192, 255);
            PanelLogin.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            PanelLogin.Controls.Add(panel1ControlerPanelLogin);
            resources.ApplyResources(PanelLogin, "PanelLogin");
            PanelLogin.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            PanelLogin.Name = "PanelLogin";
            PanelLogin.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            PanelLogin.PrimerColor = Color.White;
            PanelLogin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PanelLogin.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            PanelLogin.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            PanelLogin.TopLeft = Color.FromArgb(192, 192, 255);
            PanelLogin.TopRight = Color.White;
            // 
            // panel1ControlerPanelLogin
            // 
            resources.ApplyResources(panel1ControlerPanelLogin, "panel1ControlerPanelLogin");
            panel1ControlerPanelLogin.BackColor = Color.White;
            panel1ControlerPanelLogin.Controls.Add(PanelDeLoginPrincipal);
            panel1ControlerPanelLogin.Name = "panel1ControlerPanelLogin";
            // 
            // PanelDeLoginPrincipal
            // 
            PanelDeLoginPrincipal.BorderStyle = BorderStyle.Fixed3D;
            PanelDeLoginPrincipal.BottomLeft = Color.White;
            PanelDeLoginPrincipal.BottomRight = Color.White;
            PanelDeLoginPrincipal.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            PanelDeLoginPrincipal.Controls.Add(pictureBox5);
            PanelDeLoginPrincipal.Controls.Add(textBox2Senha);
            PanelDeLoginPrincipal.Controls.Add(textBox1Email);
            PanelDeLoginPrincipal.Controls.Add(label1);
            PanelDeLoginPrincipal.Controls.Add(bigLabel1);
            PanelDeLoginPrincipal.Controls.Add(Login);
            PanelDeLoginPrincipal.Controls.Add(label2);
            PanelDeLoginPrincipal.Controls.Add(pictureBox1);
            resources.ApplyResources(PanelDeLoginPrincipal, "PanelDeLoginPrincipal");
            PanelDeLoginPrincipal.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            PanelDeLoginPrincipal.Name = "PanelDeLoginPrincipal";
            PanelDeLoginPrincipal.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            PanelDeLoginPrincipal.PrimerColor = Color.White;
            PanelDeLoginPrincipal.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PanelDeLoginPrincipal.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            PanelDeLoginPrincipal.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            PanelDeLoginPrincipal.TopLeft = Color.White;
            PanelDeLoginPrincipal.TopRight = Color.Silver;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.olho;
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // textBox2Senha
            // 
            resources.ApplyResources(textBox2Senha, "textBox2Senha");
            textBox2Senha.BackColor = Color.White;
            textBox2Senha.BorderStyle = BorderStyle.FixedSingle;
            textBox2Senha.Name = "textBox2Senha";
            textBox2Senha.UseSystemPasswordChar = true;
            // 
            // textBox1Email
            // 
            resources.ApplyResources(textBox1Email, "textBox1Email");
            textBox1Email.BackColor = Color.White;
            textBox1Email.BorderStyle = BorderStyle.FixedSingle;
            textBox1Email.Name = "textBox1Email";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Name = "label1";
            // 
            // bigLabel1
            // 
            resources.ApplyResources(bigLabel1, "bigLabel1");
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Name = "bigLabel1";
            // 
            // Login
            // 
            resources.ApplyResources(Login, "Login");
            Login.BackColor = Color.Transparent;
            Login.BorderColor = Color.Black;
            Login.EnteredBorderColor = Color.Black;
            Login.EnteredColor = Color.FromArgb(0, 64, 0);
            Login.Image = null;
            Login.ImageAlign = ContentAlignment.MiddleLeft;
            Login.InactiveColor = Color.Green;
            Login.Name = "Login";
            Login.PressedBorderColor = Color.Black;
            Login.PressedColor = Color.Lime;
            Login.TextAlignment = StringAlignment.Center;
            Login.Click += Login_Click_1;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
            label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            Controls.Add(PanelLogin);
            Controls.Add(parrotGradientPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Load += Form1_Load;
            parrotGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelLogin.ResumeLayout(false);
            panel1ControlerPanelLogin.ResumeLayout(false);
            PanelDeLoginPrincipal.ResumeLayout(false);
            PanelDeLoginPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.ParrotGradientPanel PanelLogin;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1ControlerPanelLogin;
        private ReaLTaiizor.Controls.ParrotGradientPanel PanelDeLoginPrincipal;
        private PictureBox pictureBox5;
        private TextBox textBox2Senha;
        private TextBox textBox1Email;
        private Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.Button Login;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
