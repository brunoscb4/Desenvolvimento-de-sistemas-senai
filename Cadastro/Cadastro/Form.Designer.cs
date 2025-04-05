namespace Cadastro
{
    partial class Form
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
            textNome = new TextBox();
            textTelefone = new TextBox();
            textData = new TextBox();
            textCurso = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Cadastrar = new Button();
            voltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 56);
            label1.Name = "label1";
            label1.Size = new Size(123, 19);
            label1.TabIndex = 0;
            label1.Text = "Nome do aluno :";
            // 
            // textNome
            // 
            textNome.Location = new Point(326, 52);
            textNome.Name = "textNome";
            textNome.Size = new Size(289, 23);
            textNome.TabIndex = 1;
            // 
            // textTelefone
            // 
            textTelefone.Location = new Point(326, 345);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(289, 23);
            textTelefone.TabIndex = 2;
            // 
            // textData
            // 
            textData.Location = new Point(326, 139);
            textData.Name = "textData";
            textData.Size = new Size(119, 23);
            textData.TabIndex = 3;
            // 
            // textCurso
            // 
            textCurso.Location = new Point(326, 246);
            textCurso.Name = "textCurso";
            textCurso.Size = new Size(289, 23);
            textCurso.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 349);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 5;
            label2.Text = "Telefone :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 246);
            label3.Name = "label3";
            label3.Size = new Size(55, 19);
            label3.TabIndex = 6;
            label3.Text = "Curso :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(107, 143);
            label4.Name = "label4";
            label4.Size = new Size(132, 19);
            label4.TabIndex = 7;
            label4.Text = "Data nascimento :";
            // 
            // Cadastrar
            // 
            Cadastrar.Location = new Point(633, 486);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(90, 26);
            Cadastrar.TabIndex = 8;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = true;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // voltar
            // 
            voltar.Location = new Point(41, 12);
            voltar.Name = "voltar";
            voltar.Size = new Size(75, 23);
            voltar.TabIndex = 9;
            voltar.Text = "Voltar";
            voltar.UseVisualStyleBackColor = true;
            voltar.Click += voltar_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 536);
            Controls.Add(voltar);
            Controls.Add(Cadastrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textCurso);
            Controls.Add(textData);
            Controls.Add(textTelefone);
            Controls.Add(textNome);
            Controls.Add(label1);
            Name = "Form";
            Text = "Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNome;
        private TextBox textTelefone;
        private TextBox textData;
        private TextBox textCurso;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Cadastrar;
        private Button voltar;
    }
}
