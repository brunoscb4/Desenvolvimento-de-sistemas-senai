namespace JogosGratis
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            textDesenvolvedor = new TextBox();
            textPublicado = new TextBox();
            textGenero = new TextBox();
            textTitulo = new TextBox();
            textId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBoxImagem = new PictureBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 27);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_linha_horizontal_24;
            pictureBox2.Location = new Point(859, -5);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_excluir_24__1_;
            pictureBox1.Location = new Point(904, -5);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(374, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 0;
            label1.Text = "Jogos gratis";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(textDesenvolvedor);
            panel2.Controls.Add(textPublicado);
            panel2.Controls.Add(textGenero);
            panel2.Controls.Add(textTitulo);
            panel2.Controls.Add(textId);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBoxImagem);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(0, 27);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(935, 646);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // textDesenvolvedor
            // 
            textDesenvolvedor.Location = new Point(617, 177);
            textDesenvolvedor.Name = "textDesenvolvedor";
            textDesenvolvedor.Size = new Size(306, 27);
            textDesenvolvedor.TabIndex = 35;
            // 
            // textPublicado
            // 
            textPublicado.Location = new Point(617, 139);
            textPublicado.Name = "textPublicado";
            textPublicado.Size = new Size(306, 27);
            textPublicado.TabIndex = 34;
            // 
            // textGenero
            // 
            textGenero.Location = new Point(617, 98);
            textGenero.Name = "textGenero";
            textGenero.Size = new Size(306, 27);
            textGenero.TabIndex = 33;
            // 
            // textTitulo
            // 
            textTitulo.Location = new Point(617, 55);
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(306, 27);
            textTitulo.TabIndex = 32;
            // 
            // textId
            // 
            textId.Location = new Point(617, 11);
            textId.Name = "textId";
            textId.Size = new Size(306, 27);
            textId.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(468, 185);
            label6.Name = "label6";
            label6.Size = new Size(120, 19);
            label6.TabIndex = 30;
            label6.Text = "Desenvolvedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(468, 147);
            label5.Name = "label5";
            label5.Size = new Size(86, 19);
            label5.TabIndex = 29;
            label5.Text = "Publicado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(468, 106);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 28;
            label4.Text = "Genero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(468, 63);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 27;
            label3.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(468, 19);
            label2.Name = "label2";
            label2.Size = new Size(28, 19);
            label2.TabIndex = 26;
            label2.Text = "Id:";
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.BackColor = Color.FromArgb(128, 255, 255);
            pictureBoxImagem.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxImagem.Location = new Point(12, 7);
            pictureBoxImagem.Name = "pictureBoxImagem";
            pictureBoxImagem.Size = new Size(366, 206);
            pictureBoxImagem.TabIndex = 25;
            pictureBoxImagem.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 284);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Size = new Size(935, 362);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(837, 246);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 23;
            button1.Text = "Listar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private PictureBox pictureBoxImagem;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textDesenvolvedor;
        private TextBox textPublicado;
        private TextBox textGenero;
        private TextBox textTitulo;
        private TextBox textId;
    }
}
