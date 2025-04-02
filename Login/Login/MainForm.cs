/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 01/04/2025
 * Time: 10:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Login
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
	
			try
				
				
			{
				string usuario = txtUsuario.Text;
				string senha  = txtSenha.Text;
				
				if (usuario != "" && senha != "")
				{
					string conexaoBanco = "Server = localhost; Database = sistemalogim; Uid = root; pwd = '' " ;
					MySqlConnection conexao = new MySqlConnection (conexaoBanco);
					conexao.Open();
					
					String consultaUsuario = "select * from usuarios where usuario = @usuario and senha = @senha";
					MySqlCommand comandoSQL = new MySqlCommand(consultaUsuario, conexao);
					
	
					comandoSQL.Parameters.AddWithValue("@usuario", usuario);
					comandoSQL.Parameters.AddWithValue("@senha", senha);
					
					int registro = Convert.ToInt32(comandoSQL.ExecuteScalar());
				
					if (registro > 0 )
					{
					MessageBox.Show("Login realizado com sucesso");
					}
					else
					{
					MessageBox.Show("Usuario ou senha invalido !");
					}
				    }
				    else
				    {
					MessageBox.Show("Erro ao realizar login " );
				    }
				
				    
			}
			catch(Exception ex)
			{
				MessageBox.Show("Erro ao realizar login " + ex.Message);
			}
			
			
		}
		void Button2Click(object sender, EventArgs e)
		{
		Cadastro telaCadastro = new Cadastro ();
		telaCadastro.Show();
		this.Hide();
			
		}
	}
}
