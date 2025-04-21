namespace Lista_15
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
            textNomeSetor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textID = new TextBox();
            label3 = new Label();
            textSetor = new TextBox();
            Gavar = new Button();
            Excluir = new Button();
            Editar = new Button();
            cone = new Label();
            Listar = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            Salvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textNomeSetor
            // 
            textNomeSetor.Location = new Point(203, 52);
            textNomeSetor.Name = "textNomeSetor";
            textNomeSetor.Size = new Size(365, 27);
            textNomeSetor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 52);
            label1.Name = "label1";
            label1.Size = new Size(168, 27);
            label1.TabIndex = 3;
            label1.Text = "Buscar setor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 372);
            label2.Name = "label2";
            label2.Size = new Size(48, 27);
            label2.TabIndex = 4;
            label2.Text = "ID:";
            // 
            // textID
            // 
            textID.Location = new Point(111, 372);
            textID.Name = "textID";
            textID.Size = new Size(153, 27);
            textID.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 419);
            label3.Name = "label3";
            label3.Size = new Size(72, 27);
            label3.TabIndex = 6;
            label3.Text = "Nome:";
            // 
            // textSetor
            // 
            textSetor.Location = new Point(111, 419);
            textSetor.Name = "textSetor";
            textSetor.Size = new Size(563, 27);
            textSetor.TabIndex = 7;
            // 
            // Gavar
            // 
            Gavar.BackColor = Color.LimeGreen;
            Gavar.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Gavar.ForeColor = SystemColors.ControlLightLight;
            Gavar.Location = new Point(29, 479);
            Gavar.Name = "Gavar";
            Gavar.Size = new Size(94, 29);
            Gavar.TabIndex = 8;
            Gavar.Text = "Gravar";
            Gavar.UseVisualStyleBackColor = false;
            Gavar.Click += Gavar_Click;
            // 
            // Excluir
            // 
            Excluir.BackColor = Color.Crimson;
            Excluir.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Excluir.ForeColor = SystemColors.ControlLightLight;
            Excluir.Location = new Point(399, 479);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(94, 29);
            Excluir.TabIndex = 9;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = false;
            // 
            // Editar
            // 
            Editar.BackColor = Color.Red;
            Editar.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Editar.ForeColor = SystemColors.ControlLightLight;
            Editar.Location = new Point(211, 479);
            Editar.Name = "Editar";
            Editar.Size = new Size(94, 29);
            Editar.TabIndex = 10;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = false;
            Editar.Click += Editar_Click;
            // 
            // cone
            // 
            cone.AutoSize = true;
            cone.Location = new Point(399, 378);
            cone.Name = "cone";
            cone.Size = new Size(0, 20);
            cone.TabIndex = 11;
            // 
            // Listar
            // 
            Listar.BackColor = Color.ForestGreen;
            Listar.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Listar.ForeColor = SystemColors.ControlLightLight;
            Listar.Location = new Point(580, 479);
            Listar.Name = "Listar";
            Listar.Size = new Size(94, 29);
            Listar.TabIndex = 12;
            Listar.Text = "Listar";
            Listar.UseVisualStyleBackColor = false;
            Listar.Click += Listar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(645, 272);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(580, 52);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Salvar
            // 
            Salvar.BackColor = Color.ForestGreen;
            Salvar.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Salvar.ForeColor = SystemColors.ControlLightLight;
            Salvar.Location = new Point(580, 373);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(94, 29);
            Salvar.TabIndex = 15;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = false;
            Salvar.Click += Salvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(700, 536);
            Controls.Add(Salvar);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Listar);
            Controls.Add(cone);
            Controls.Add(Editar);
            Controls.Add(Excluir);
            Controls.Add(Gavar);
            Controls.Add(textSetor);
            Controls.Add(label3);
            Controls.Add(textID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textNomeSetor);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textNomeSetor;
        private Label label1;
        private Label label2;
        private TextBox textID;
        private Label label3;
        private TextBox textSetor;
        private Button Gavar;
        private Button Excluir;
        private Button Editar;
        private Label cone;
        private Button Listar;
        private DataGridView dataGridView1;
        private Button button1;
        private Button Salvar;
    }
}
