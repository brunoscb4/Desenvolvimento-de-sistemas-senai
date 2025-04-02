/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 01/04/2025
 * Time: 10:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
	/// <summary>
	/// Description of Cadastro.
	/// </summary>
	public partial class Cadastro : Form
	{
		public Cadastro()
		{
			InitializeComponent();
			
		
		}
		void Button1Click(object sender, EventArgs e)
		{
			
            
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

              try
                {
           string conexaoBanco = "Server = localhost; Database = sistemalogim; Uid = root; pwd = '' " ;
           MySqlConnection conexao = new MySqlConnection (conexaoBanco);
		   conexao.Open();
					

          
            string query = "INSERT INTO Usuarios (Nome, Email ) VALUES ( @Email, @Senha)";
              
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Senha", senha);
                
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
              }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }
            }
        }
	
		}
	}
}
