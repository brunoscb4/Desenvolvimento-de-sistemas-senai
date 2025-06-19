namespace Fenix_Shop.Telas
{
    partial class ListaProdutos
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
            PanelListaProdutos = new ReaLTaiizor.Controls.ParrotGradientPanel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            button1 = new ReaLTaiizor.Controls.Button();
            TextBoxNomeBusacar = new ReaLTaiizor.Controls.CyberRichTextBox();
            TextBoxCodigoBuscar = new MaskedTextBox();
            PanelListaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PanelListaProdutos
            // 
            PanelListaProdutos.BottomLeft = Color.White;
            PanelListaProdutos.BottomRight = Color.White;
            PanelListaProdutos.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            PanelListaProdutos.Controls.Add(label2);
            PanelListaProdutos.Controls.Add(label1);
            PanelListaProdutos.Controls.Add(button1);
            PanelListaProdutos.Controls.Add(TextBoxNomeBusacar);
            PanelListaProdutos.Controls.Add(TextBoxCodigoBuscar);
            PanelListaProdutos.Controls.Add(dataGridView1);
            PanelListaProdutos.Dock = DockStyle.Fill;
            PanelListaProdutos.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            PanelListaProdutos.Location = new Point(0, 0);
            PanelListaProdutos.Margin = new Padding(3, 4, 3, 4);
            PanelListaProdutos.Name = "PanelListaProdutos";
            PanelListaProdutos.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            PanelListaProdutos.PrimerColor = Color.White;
            PanelListaProdutos.Size = new Size(1058, 893);
            PanelListaProdutos.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PanelListaProdutos.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            PanelListaProdutos.TabIndex = 0;
            PanelListaProdutos.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            PanelListaProdutos.TopLeft = Color.White;
            PanelListaProdutos.TopRight = Color.FromArgb(128, 255, 255);
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.Location = new Point(-7, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1065, 762);
            dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(330, 43);
            label2.Name = "label2";
            label2.Size = new Size(102, 24);
            label2.TabIndex = 13;
            label2.Text = "Pesquisa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 46);
            label1.Name = "label1";
            label1.Size = new Size(85, 24);
            label1.TabIndex = 12;
            label1.Text = "Codigo:";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.Black;
            button1.EnteredBorderColor = Color.Black;
            button1.EnteredColor = Color.Lime;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(919, 37);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.Black;
            button1.PressedColor = Color.FromArgb(0, 64, 0);
            button1.Size = new Size(113, 37);
            button1.TabIndex = 11;
            button1.Text = "Buscar";
            button1.TextAlignment = StringAlignment.Center;
            // 
            // TextBoxNomeBusacar
            // 
            TextBoxNomeBusacar.Alpha = 20;
            TextBoxNomeBusacar.BackColor = Color.Transparent;
            TextBoxNomeBusacar.Background_WidthPen = 3F;
            TextBoxNomeBusacar.BackgroundPen = true;
            TextBoxNomeBusacar.ColorBackground = Color.White;
            TextBoxNomeBusacar.ColorBackground_Pen = Color.Black;
            TextBoxNomeBusacar.ColorLighting = Color.Black;
            TextBoxNomeBusacar.ColorPen_1 = Color.FromArgb(29, 200, 238);
            TextBoxNomeBusacar.ColorPen_2 = Color.White;
            TextBoxNomeBusacar.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            TextBoxNomeBusacar.Font = new Font("Arial", 11F);
            TextBoxNomeBusacar.ForeColor = Color.FromArgb(245, 245, 245);
            TextBoxNomeBusacar.Lighting = false;
            TextBoxNomeBusacar.LinearGradientPen = false;
            TextBoxNomeBusacar.Location = new Point(469, 37);
            TextBoxNomeBusacar.Margin = new Padding(3, 4, 3, 4);
            TextBoxNomeBusacar.Name = "TextBoxNomeBusacar";
            TextBoxNomeBusacar.PenWidth = 15;
            TextBoxNomeBusacar.RGB = false;
            TextBoxNomeBusacar.Rounding = true;
            TextBoxNomeBusacar.RoundingInt = 60;
            TextBoxNomeBusacar.Size = new Size(390, 36);
            TextBoxNomeBusacar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            TextBoxNomeBusacar.TabIndex = 10;
            TextBoxNomeBusacar.Tag = "Cyber";
            TextBoxNomeBusacar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            TextBoxNomeBusacar.Timer_RGB = 300;
            // 
            // TextBoxCodigoBuscar
            // 
            TextBoxCodigoBuscar.Location = new Point(123, 43);
            TextBoxCodigoBuscar.Margin = new Padding(3, 4, 3, 4);
            TextBoxCodigoBuscar.Mask = "00000000000000000000000";
            TextBoxCodigoBuscar.Name = "TextBoxCodigoBuscar";
            TextBoxCodigoBuscar.Size = new Size(154, 27);
            TextBoxCodigoBuscar.TabIndex = 9;
            // 
            // ListaProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelListaProdutos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListaProdutos";
            Size = new Size(1058, 893);
            PanelListaProdutos.ResumeLayout(false);
            PanelListaProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel PanelListaProdutos;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.CyberRichTextBox TextBoxNomeBusacar;
        private MaskedTextBox TextBoxCodigoBuscar;
    }
}
