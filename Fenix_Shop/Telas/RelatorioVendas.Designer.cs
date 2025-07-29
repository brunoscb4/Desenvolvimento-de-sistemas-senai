namespace Fenix_Shop.Telas
{
    partial class RelatorioVendas
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
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            dataGridView1 = new DataGridView();
            button1 = new ReaLTaiizor.Controls.Button();
            bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            dateTimePickerFinal = new DateTimePicker();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            dateTimePickerInicio = new DateTimePicker();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            panel6 = new Panel();
            label16PagamentosCredito = new Label();
            label8 = new Label();
            panel7 = new Panel();
            label15PagamentosDebito = new Label();
            label7 = new Label();
            panel5 = new Panel();
            label13ItensVendidos = new Label();
            label5 = new Label();
            panel8 = new Panel();
            label14PagamentosPix = new Label();
            label6 = new Label();
            panel4 = new Panel();
            label12MediaDeVendas = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label11ConvercoesDeVendas = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label10VendasCanceladas = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label9VendasRealizadas = new Label();
            label1 = new Label();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BottomLeft = Color.White;
            parrotGradientPanel1.BottomRight = Color.White;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.Controls.Add(dataGridView1);
            parrotGradientPanel1.Controls.Add(button1);
            parrotGradientPanel1.Controls.Add(bigLabel4);
            parrotGradientPanel1.Controls.Add(dateTimePickerFinal);
            parrotGradientPanel1.Controls.Add(bigLabel3);
            parrotGradientPanel1.Controls.Add(bigLabel2);
            parrotGradientPanel1.Controls.Add(dateTimePickerInicio);
            parrotGradientPanel1.Controls.Add(bigLabel1);
            parrotGradientPanel1.Controls.Add(panel6);
            parrotGradientPanel1.Controls.Add(panel7);
            parrotGradientPanel1.Controls.Add(panel5);
            parrotGradientPanel1.Controls.Add(panel8);
            parrotGradientPanel1.Controls.Add(panel4);
            parrotGradientPanel1.Controls.Add(panel3);
            parrotGradientPanel1.Controls.Add(panel2);
            parrotGradientPanel1.Controls.Add(panel1);
            parrotGradientPanel1.Dock = DockStyle.Fill;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(926, 670);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            parrotGradientPanel1.TabIndex = 0;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.White;
            parrotGradientPanel1.TopRight = Color.FromArgb(64, 64, 64);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.Location = new Point(0, 390);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(926, 278);
            dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BorderColor = Color.Black;
            button1.EnteredBorderColor = Color.Black;
            button1.EnteredColor = Color.Lime;
            button1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.Lime;
            button1.Location = new Point(621, 349);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.Black;
            button1.PressedColor = Color.FromArgb(0, 64, 0);
            button1.Size = new Size(100, 23);
            button1.TabIndex = 12;
            button1.Text = "Filtrar";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
            // 
            // bigLabel4
            // 
            bigLabel4.AutoSize = true;
            bigLabel4.BackColor = Color.Transparent;
            bigLabel4.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bigLabel4.ForeColor = Color.Black;
            bigLabel4.Location = new Point(117, 349);
            bigLabel4.Name = "bigLabel4";
            bigLabel4.Size = new Size(31, 23);
            bigLabel4.TabIndex = 10;
            bigLabel4.Text = "De";
            // 
            // dateTimePickerFinal
            // 
            dateTimePickerFinal.Format = DateTimePickerFormat.Short;
            dateTimePickerFinal.Location = new Point(473, 349);
            dateTimePickerFinal.Name = "dateTimePickerFinal";
            dateTimePickerFinal.Size = new Size(110, 23);
            dateTimePickerFinal.TabIndex = 9;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.Black;
            bigLabel3.Location = new Point(365, 349);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(37, 23);
            bigLabel3.TabIndex = 8;
            bigLabel3.Text = "Ate";
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(39, 310);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(53, 23);
            bigLabel2.TabIndex = 7;
            bigLabel2.Text = "Filtro";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Format = DateTimePickerFormat.Short;
            dateTimePickerInicio.Location = new Point(186, 349);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(110, 23);
            dateTimePickerInicio.TabIndex = 6;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(152, 282);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(200, 23);
            bigLabel1.TabIndex = 5;
            bigLabel1.Text = "Produtos mais vendidos ";
            // 
            // panel6
            // 
            panel6.AllowDrop = true;
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.AutoSize = true;
            panel6.BackColor = Color.Lavender;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label16PagamentosCredito);
            panel6.Controls.Add(label8);
            panel6.ImeMode = ImeMode.NoControl;
            panel6.Location = new Point(636, 217);
            panel6.MaximumSize = new Size(375, 75);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 53);
            panel6.TabIndex = 4;
            // 
            // label16PagamentosCredito
            // 
            label16PagamentosCredito.AutoSize = true;
            label16PagamentosCredito.BackColor = Color.Transparent;
            label16PagamentosCredito.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label16PagamentosCredito.ForeColor = SystemColors.ActiveCaptionText;
            label16PagamentosCredito.Location = new Point(112, 28);
            label16PagamentosCredito.Name = "label16PagamentosCredito";
            label16PagamentosCredito.Size = new Size(21, 23);
            label16PagamentosCredito.TabIndex = 4;
            label16PagamentosCredito.Text = "0";
            label16PagamentosCredito.Click += label16PagamentosCredito_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(175, 18);
            label8.TabIndex = 2;
            label8.Text = "pagametos por credito";
            // 
            // panel7
            // 
            panel7.AllowDrop = true;
            panel7.Anchor = AnchorStyles.Top;
            panel7.AutoSize = true;
            panel7.BackColor = Color.Lavender;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label15PagamentosDebito);
            panel7.Controls.Add(label7);
            panel7.ImeMode = ImeMode.NoControl;
            panel7.Location = new Point(344, 217);
            panel7.MaximumSize = new Size(375, 75);
            panel7.MinimumSize = new Size(250, 50);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 53);
            panel7.TabIndex = 3;
            // 
            // label15PagamentosDebito
            // 
            label15PagamentosDebito.AutoSize = true;
            label15PagamentosDebito.BackColor = Color.Transparent;
            label15PagamentosDebito.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label15PagamentosDebito.ForeColor = SystemColors.ActiveCaptionText;
            label15PagamentosDebito.Location = new Point(108, 28);
            label15PagamentosDebito.Name = "label15PagamentosDebito";
            label15PagamentosDebito.Size = new Size(21, 23);
            label15PagamentosDebito.TabIndex = 4;
            label15PagamentosDebito.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(171, 18);
            label7.TabIndex = 1;
            label7.Text = "pagametos por debito";
            // 
            // panel5
            // 
            panel5.AllowDrop = true;
            panel5.Anchor = AnchorStyles.Top;
            panel5.AutoSize = true;
            panel5.BackColor = Color.DodgerBlue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label13ItensVendidos);
            panel5.Controls.Add(label5);
            panel5.ImeMode = ImeMode.NoControl;
            panel5.Location = new Point(502, 126);
            panel5.MaximumSize = new Size(375, 75);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 55);
            panel5.TabIndex = 1;
            // 
            // label13ItensVendidos
            // 
            label13ItensVendidos.AutoSize = true;
            label13ItensVendidos.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13ItensVendidos.ForeColor = SystemColors.ButtonHighlight;
            label13ItensVendidos.Location = new Point(94, 30);
            label13ItensVendidos.Name = "label13ItensVendidos";
            label13ItensVendidos.Size = new Size(21, 23);
            label13ItensVendidos.TabIndex = 3;
            label13ItensVendidos.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 18);
            label5.TabIndex = 1;
            label5.Text = "Itens vendidos";
            // 
            // panel8
            // 
            panel8.AllowDrop = true;
            panel8.AutoSize = true;
            panel8.BackColor = Color.Lavender;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label14PagamentosPix);
            panel8.Controls.Add(label6);
            panel8.ImeMode = ImeMode.NoControl;
            panel8.Location = new Point(46, 217);
            panel8.MaximumSize = new Size(375, 75);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 55);
            panel8.TabIndex = 2;
            // 
            // label14PagamentosPix
            // 
            label14PagamentosPix.AutoSize = true;
            label14PagamentosPix.BackColor = Color.Transparent;
            label14PagamentosPix.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label14PagamentosPix.ForeColor = SystemColors.ActiveCaptionText;
            label14PagamentosPix.Location = new Point(105, 30);
            label14PagamentosPix.Name = "label14PagamentosPix";
            label14PagamentosPix.Size = new Size(21, 23);
            label14PagamentosPix.TabIndex = 3;
            label14PagamentosPix.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(158, 18);
            label6.TabIndex = 1;
            label6.Text = "Pagamentos por pix";
            // 
            // panel4
            // 
            panel4.AllowDrop = true;
            panel4.Anchor = AnchorStyles.Top;
            panel4.AutoSize = true;
            panel4.BackColor = Color.DodgerBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label12MediaDeVendas);
            panel4.Controls.Add(label4);
            panel4.ImeMode = ImeMode.NoControl;
            panel4.Location = new Point(168, 126);
            panel4.MaximumSize = new Size(375, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 56);
            panel4.TabIndex = 1;
            // 
            // label12MediaDeVendas
            // 
            label12MediaDeVendas.AutoSize = true;
            label12MediaDeVendas.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12MediaDeVendas.ForeColor = SystemColors.ButtonHighlight;
            label12MediaDeVendas.Location = new Point(108, 31);
            label12MediaDeVendas.Name = "label12MediaDeVendas";
            label12MediaDeVendas.Size = new Size(21, 23);
            label12MediaDeVendas.TabIndex = 3;
            label12MediaDeVendas.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(-1, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 18);
            label4.TabIndex = 1;
            label4.Text = "Média de vendas";
            // 
            // panel3
            // 
            panel3.AllowDrop = true;
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.AutoSize = true;
            panel3.BackColor = Color.DodgerBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label11ConvercoesDeVendas);
            panel3.Controls.Add(label3);
            panel3.ImeMode = ImeMode.NoControl;
            panel3.Location = new Point(636, 28);
            panel3.MaximumSize = new Size(375, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 55);
            panel3.TabIndex = 1;
            // 
            // label11ConvercoesDeVendas
            // 
            label11ConvercoesDeVendas.AutoSize = true;
            label11ConvercoesDeVendas.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11ConvercoesDeVendas.ForeColor = SystemColors.ButtonHighlight;
            label11ConvercoesDeVendas.Location = new Point(112, 30);
            label11ConvercoesDeVendas.Name = "label11ConvercoesDeVendas";
            label11ConvercoesDeVendas.Size = new Size(21, 23);
            label11ConvercoesDeVendas.TabIndex = 3;
            label11ConvercoesDeVendas.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(181, 18);
            label3.TabIndex = 1;
            label3.Text = "Converções de vendas";
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.Anchor = AnchorStyles.Top;
            panel2.AutoSize = true;
            panel2.BackColor = Color.DodgerBlue;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label10VendasCanceladas);
            panel2.Controls.Add(label2);
            panel2.ImeMode = ImeMode.NoControl;
            panel2.Location = new Point(344, 28);
            panel2.MaximumSize = new Size(375, 75);
            panel2.MinimumSize = new Size(250, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 55);
            panel2.TabIndex = 1;
            // 
            // label10VendasCanceladas
            // 
            label10VendasCanceladas.AutoSize = true;
            label10VendasCanceladas.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10VendasCanceladas.ForeColor = SystemColors.ButtonHighlight;
            label10VendasCanceladas.Location = new Point(108, 30);
            label10VendasCanceladas.Name = "label10VendasCanceladas";
            label10VendasCanceladas.Size = new Size(21, 23);
            label10VendasCanceladas.TabIndex = 3;
            label10VendasCanceladas.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 18);
            label2.TabIndex = 1;
            label2.Text = "Vendas canceladas";
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.DodgerBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9VendasRealizadas);
            panel1.Controls.Add(label1);
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(46, 28);
            panel1.MaximumSize = new Size(375, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 56);
            panel1.TabIndex = 0;
            // 
            // label9VendasRealizadas
            // 
            label9VendasRealizadas.AutoSize = true;
            label9VendasRealizadas.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9VendasRealizadas.ForeColor = SystemColors.ButtonHighlight;
            label9VendasRealizadas.Location = new Point(105, 31);
            label9VendasRealizadas.Name = "label9VendasRealizadas";
            label9VendasRealizadas.Size = new Size(21, 23);
            label9VendasRealizadas.TabIndex = 2;
            label9VendasRealizadas.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 18);
            label1.TabIndex = 0;
            label1.Text = "Vendas realizadas";
            // 
            // RelatorioVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parrotGradientPanel1);
            Name = "RelatorioVendas";
            Size = new Size(926, 670);
            Load += RelatorioVendas_Load;
            parrotGradientPanel1.ResumeLayout(false);
            parrotGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFinal;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.Button button1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label16PagamentosCredito;
        private Label label8;
        private Label label15PagamentosDebito;
        private Label label13ItensVendidos;
        private Label label14PagamentosPix;
        private Label label12MediaDeVendas;
        private Label label11ConvercoesDeVendas;
        private Label label10VendasCanceladas;
        private Label label9VendasRealizadas;
        private DataGridView dataGridView1;
    }
}
