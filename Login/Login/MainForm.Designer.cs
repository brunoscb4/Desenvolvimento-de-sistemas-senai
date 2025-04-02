/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 01/04/2025
 * Time: 10:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Login
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.txtSenha);
			this.panel1.Controls.Add(this.txtUsuario);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(457, 351);
			this.panel1.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(273, 274);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(93, 29);
			this.button2.TabIndex = 3;
			this.button2.Text = "Cadastro";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(171, 152);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(253, 26);
			this.txtSenha.TabIndex = 2;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(171, 62);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(253, 26);
			this.txtUsuario.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(171, 229);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(78, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(39, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Usuário";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(39, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Senha";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 347);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Login";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
