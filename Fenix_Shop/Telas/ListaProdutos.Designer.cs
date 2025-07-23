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
            textBoxBuscarNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new ReaLTaiizor.Controls.Button();
            TextBoxCodigoBuscar = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            PanelListaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PanelListaProdutos
            // 
            PanelListaProdutos.BottomLeft = Color.White;
            PanelListaProdutos.BottomRight = Color.White;
            PanelListaProdutos.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            PanelListaProdutos.Controls.Add(textBoxBuscarNome);
            PanelListaProdutos.Controls.Add(label2);
            PanelListaProdutos.Controls.Add(label1);
            PanelListaProdutos.Controls.Add(button1);
            PanelListaProdutos.Controls.Add(TextBoxCodigoBuscar);
            PanelListaProdutos.Controls.Add(dataGridView1);
            PanelListaProdutos.Dock = DockStyle.Fill;
            PanelListaProdutos.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            PanelListaProdutos.Location = new Point(0, 0);
            PanelListaProdutos.Name = "PanelListaProdutos";
            PanelListaProdutos.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            PanelListaProdutos.PrimerColor = Color.White;
            PanelListaProdutos.Size = new Size(926, 670);
            PanelListaProdutos.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PanelListaProdutos.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Vertical;
            PanelListaProdutos.TabIndex = 0;
            PanelListaProdutos.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            PanelListaProdutos.TopLeft = Color.White;
            PanelListaProdutos.TopRight = Color.FromArgb(64, 64, 64);
            // 
            // textBoxBuscarNome
            // 
            textBoxBuscarNome.Location = new Point(416, 31);
            textBoxBuscarNome.Name = "textBoxBuscarNome";
            textBoxBuscarNome.Size = new Size(346, 23);
            textBoxBuscarNome.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(289, 32);
            label2.Name = "label2";
            label2.Size = new Size(83, 18);
            label2.TabIndex = 13;
            label2.Text = "Pesquisa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
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
            button1.Location = new Point(804, 28);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.Black;
            button1.PressedColor = Color.FromArgb(0, 64, 0);
            button1.Size = new Size(99, 28);
            button1.TabIndex = 11;
            button1.Text = "Buscar";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // TextBoxCodigoBuscar
            // 
            TextBoxCodigoBuscar.BorderStyle = BorderStyle.FixedSingle;
            TextBoxCodigoBuscar.Location = new Point(108, 32);
            TextBoxCodigoBuscar.Mask = "00000000000000000000000";
            TextBoxCodigoBuscar.Name = "TextBoxCodigoBuscar";
            TextBoxCodigoBuscar.PromptChar = ' ';
            TextBoxCodigoBuscar.Size = new Size(135, 23);
            TextBoxCodigoBuscar.TabIndex = 9;
            TextBoxCodigoBuscar.Click += TextBoxCodigoBuscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.Location = new Point(0, 81);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(926, 589);
            dataGridView1.TabIndex = 4;
            // 
            // ListaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelListaProdutos);
            Name = "ListaProdutos";
            Size = new Size(926, 670);
            Load += ListaProdutos_Load;
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
        private TextBox textBoxBuscarNome;
        private MaskedTextBox TextBoxCodigoBuscar;
    }
}
