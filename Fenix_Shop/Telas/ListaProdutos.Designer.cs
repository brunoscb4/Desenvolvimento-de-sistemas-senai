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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            PanelListaProdutos = new ReaLTaiizor.Controls.ParrotGradientPanel();
            button1 = new ReaLTaiizor.Controls.Button();
            TextBoxNomeBusacar = new ReaLTaiizor.Controls.CyberRichTextBox();
            TextBoxCodigoBuscar = new MaskedTextBox();
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            PanelListaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PanelListaProdutos
            // 
            PanelListaProdutos.BottomLeft = Color.White;
            PanelListaProdutos.BottomRight = Color.White;
            PanelListaProdutos.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            PanelListaProdutos.Controls.Add(button1);
            PanelListaProdutos.Controls.Add(TextBoxNomeBusacar);
            PanelListaProdutos.Controls.Add(TextBoxCodigoBuscar);
            PanelListaProdutos.Controls.Add(poisonDataGridView1);
            PanelListaProdutos.Dock = DockStyle.Fill;
            PanelListaProdutos.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            PanelListaProdutos.Location = new Point(0, 0);
            PanelListaProdutos.Name = "PanelListaProdutos";
            PanelListaProdutos.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            PanelListaProdutos.PrimerColor = Color.White;
            PanelListaProdutos.Size = new Size(926, 670);
            PanelListaProdutos.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PanelListaProdutos.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            PanelListaProdutos.TabIndex = 0;
            PanelListaProdutos.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            PanelListaProdutos.TopLeft = Color.White;
            PanelListaProdutos.TopRight = Color.FromArgb(128, 255, 255);
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.Black;
            button1.EnteredBorderColor = Color.Black;
            button1.EnteredColor = Color.Lime;
            button1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(768, 74);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.Black;
            button1.PressedColor = Color.FromArgb(0, 64, 0);
            button1.Size = new Size(99, 28);
            button1.TabIndex = 3;
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
            TextBoxNomeBusacar.Location = new Point(296, 75);
            TextBoxNomeBusacar.Name = "TextBoxNomeBusacar";
            TextBoxNomeBusacar.PenWidth = 15;
            TextBoxNomeBusacar.RGB = false;
            TextBoxNomeBusacar.Rounding = true;
            TextBoxNomeBusacar.RoundingInt = 60;
            TextBoxNomeBusacar.Size = new Size(395, 27);
            TextBoxNomeBusacar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            TextBoxNomeBusacar.TabIndex = 2;
            TextBoxNomeBusacar.Tag = "Cyber";
            TextBoxNomeBusacar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            TextBoxNomeBusacar.Timer_RGB = 300;
            // 
            // TextBoxCodigoBuscar
            // 
            TextBoxCodigoBuscar.Location = new Point(72, 79);
            TextBoxCodigoBuscar.Mask = "00000000000000000000000";
            TextBoxCodigoBuscar.Name = "TextBoxCodigoBuscar";
            TextBoxCodigoBuscar.Size = new Size(135, 23);
            TextBoxCodigoBuscar.TabIndex = 1;
            // 
            // poisonDataGridView1
            // 
            poisonDataGridView1.AllowUserToResizeRows = false;
            poisonDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            poisonDataGridView1.BackgroundColor = Color.FromArgb(128, 128, 255);
            poisonDataGridView1.BorderStyle = BorderStyle.None;
            poisonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            poisonDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            poisonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            poisonDataGridView1.EnableHeadersVisualStyles = false;
            poisonDataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDataGridView1.GridColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.Location = new Point(0, 177);
            poisonDataGridView1.Name = "poisonDataGridView1";
            poisonDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            poisonDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            poisonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView1.Size = new Size(926, 493);
            poisonDataGridView1.TabIndex = 0;
            // 
            // ListaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelListaProdutos);
            Name = "ListaProdutos";
            Size = new Size(926, 670);
            PanelListaProdutos.ResumeLayout(false);
            PanelListaProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel PanelListaProdutos;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private ReaLTaiizor.Controls.CyberRichTextBox TextBoxNomeBusacar;
        private MaskedTextBox TextBoxCodigoBuscar;
        private ReaLTaiizor.Controls.Button button1;
    }
}
