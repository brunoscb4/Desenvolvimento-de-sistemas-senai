namespace Lista16
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
            label1 = new Label();
            textBuscar = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textID = new TextBox();
            textNome = new TextBox();
            textData = new DateTimePicker();
            textSalario = new TextBox();
            label6 = new Label();
            textCargo = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textCpf = new MaskedTextBox();
            textSetor = new ComboBox();
            radioButtonFeminino = new RadioButton();
            radioButtonMasculino = new RadioButton();
            label9 = new Label();
            buttonGravar = new Button();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(204, 16);
            label1.TabIndex = 0;
            label1.Text = "Digite o nome do funucionario:";
            // 
            // textBuscar
            // 
            textBuscar.Location = new Point(248, 11);
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(344, 23);
            textBuscar.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(699, 204);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 283);
            label2.Name = "label2";
            label2.Size = new Size(24, 16);
            label2.TabIndex = 3;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 315);
            label3.Name = "label3";
            label3.Size = new Size(48, 16);
            label3.TabIndex = 4;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 348);
            label4.Name = "label4";
            label4.Size = new Size(40, 16);
            label4.TabIndex = 5;
            label4.Text = "Data:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 376);
            label5.Name = "label5";
            label5.Size = new Size(57, 16);
            label5.TabIndex = 6;
            label5.Text = "Salario:";
            // 
            // textID
            // 
            textID.Location = new Point(78, 276);
            textID.Name = "textID";
            textID.Size = new Size(61, 23);
            textID.TabIndex = 7;
            // 
            // textNome
            // 
            textNome.Location = new Point(78, 308);
            textNome.Name = "textNome";
            textNome.Size = new Size(395, 23);
            textNome.TabIndex = 8;
            // 
            // textData
            // 
            textData.Format = DateTimePickerFormat.Short;
            textData.Location = new Point(78, 341);
            textData.Name = "textData";
            textData.Size = new Size(138, 23);
            textData.TabIndex = 9;
            // 
            // textSalario
            // 
            textSalario.Location = new Point(78, 369);
            textSalario.Name = "textSalario";
            textSalario.Size = new Size(138, 23);
            textSalario.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(248, 348);
            label6.Name = "label6";
            label6.Size = new Size(49, 16);
            label6.TabIndex = 11;
            label6.Text = "Cargo:";
            // 
            // textCargo
            // 
            textCargo.Location = new Point(303, 341);
            textCargo.Name = "textCargo";
            textCargo.Size = new Size(170, 23);
            textCargo.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(501, 310);
            label7.Name = "label7";
            label7.Size = new Size(37, 16);
            label7.TabIndex = 13;
            label7.Text = "CPF:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(501, 348);
            label8.Name = "label8";
            label8.Size = new Size(45, 16);
            label8.TabIndex = 14;
            label8.Text = "Setor:";
            // 
            // textCpf
            // 
            textCpf.Location = new Point(556, 308);
            textCpf.Name = "textCpf";
            textCpf.Size = new Size(155, 23);
            textCpf.TabIndex = 15;
            // 
            // textSetor
            // 
            textSetor.FormattingEnabled = true;
            textSetor.Location = new Point(558, 341);
            textSetor.Name = "textSetor";
            textSetor.Size = new Size(153, 23);
            textSetor.TabIndex = 16;
            // 
            // radioButtonFeminino
            // 
            radioButtonFeminino.AutoSize = true;
            radioButtonFeminino.Location = new Point(78, 398);
            radioButtonFeminino.Name = "radioButtonFeminino";
            radioButtonFeminino.Size = new Size(75, 19);
            radioButtonFeminino.TabIndex = 17;
            radioButtonFeminino.TabStop = true;
            radioButtonFeminino.Text = "Feminino";
            radioButtonFeminino.UseVisualStyleBackColor = true;
            radioButtonFeminino.CheckedChanged += radioButtonFeminino_CheckedChanged;
            // 
            // radioButtonMasculino
            // 
            radioButtonMasculino.AutoSize = true;
            radioButtonMasculino.Location = new Point(136, 415);
            radioButtonMasculino.Name = "radioButtonMasculino";
            radioButtonMasculino.Size = new Size(80, 19);
            radioButtonMasculino.TabIndex = 18;
            radioButtonMasculino.TabStop = true;
            radioButtonMasculino.Text = "Masculino";
            radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 401);
            label9.Name = "label9";
            label9.Size = new Size(44, 16);
            label9.TabIndex = 19;
            label9.Text = "Sexo:";
            // 
            // buttonGravar
            // 
            buttonGravar.BackColor = Color.LimeGreen;
            buttonGravar.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGravar.Location = new Point(298, 410);
            buttonGravar.Name = "buttonGravar";
            buttonGravar.Size = new Size(75, 23);
            buttonGravar.TabIndex = 20;
            buttonGravar.Text = "Gravar";
            buttonGravar.UseVisualStyleBackColor = false;
            buttonGravar.Click += buttonGravar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.FromArgb(255, 128, 0);
            buttonEditar.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditar.Location = new Point(410, 410);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 21;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.BackColor = Color.FromArgb(192, 0, 0);
            buttonExcluir.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcluir.Location = new Point(530, 410);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(75, 23);
            buttonExcluir.TabIndex = 22;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = false;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(636, 275);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "Listar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(723, 446);
            Controls.Add(button1);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(buttonGravar);
            Controls.Add(label9);
            Controls.Add(radioButtonMasculino);
            Controls.Add(radioButtonFeminino);
            Controls.Add(textSetor);
            Controls.Add(textCpf);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textCargo);
            Controls.Add(label6);
            Controls.Add(textSalario);
            Controls.Add(textData);
            Controls.Add(textNome);
            Controls.Add(textID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(textBuscar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBuscar;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textID;
        private TextBox textNome;
        private DateTimePicker textData;
        private TextBox textSalario;
        private Label label6;
        private TextBox textCargo;
        private Label label7;
        private Label label8;
        private MaskedTextBox textCpf;
        private ComboBox textSetor;
        private RadioButton radioButtonFeminino;
        private RadioButton radioButtonMasculino;
        private Label label9;
        private Button buttonGravar;
        private Button buttonEditar;
        private Button buttonExcluir;
        private Button button1;
    }
}
