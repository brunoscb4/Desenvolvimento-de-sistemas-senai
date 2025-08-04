using Fenix_Shop.programação;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fenix_Shop.Telas
{

    public partial class Tela_Inicial : UserControl
    {
        private UsuarioLogado usuariologado;
        ItensVendidos itensVendidos = new ItensVendidos(); 
       
        public Tela_Inicial(UsuarioLogado usuariologado)
        {
            InitializeComponent();
            this.usuariologado = usuariologado;
            
        }
       
        public bool AcesssoUsuarioPanel()
        {
            if (usuariologado.Nivelusuario.Equals("GERENTE"))
            {
                ButtonCadastroProduto.Enabled = true;
                button1LIstaProdutos.Enabled = true;
                button2Relatorio.Enabled = false;
                button3Vender.Enabled = true;
                button4CadastroUsuario.Enabled = false;

            }
            else if (usuariologado.Nivelusuario.Equals("VENDEDOR"))
            {
                ButtonCadastroProduto.Enabled = false;
                button1LIstaProdutos.Enabled = false;
                button2Relatorio.Enabled = false;
                button3Vender.Enabled = true;
                button4CadastroUsuario.Enabled = false;
            }
                return true;
        }
        public bool  AtualizarVendas()
        {
            labelVendidos.Text = itensVendidos.QtVendidas().ToString();
            labelNumeroDeCadastrados.Text = itensVendidos.QtItemsCadastrados().ToString();
            labelSemEstoque.Text = CadastroDeProduto.PrSemEstoque().ToString();
            

            labelVendidos.Invalidate();
            labelVendidos.Update();
            labelNumeroDeCadastrados.Invalidate();
            labelNumeroDeCadastrados.Update();
            return true;
        }
            
        
            
        

        private void CadastroProdutos_Click(object sender, EventArgs e)
        {
            CadastroProdutos cadastro = new CadastroProdutos(this);
            panel5IncialControler.Controls.Clear();
            cadastro.Dock = DockStyle.Fill;
            panel5IncialControler.Controls.Add(cadastro);
            ButtonCadastroProduto.InactiveColor = Color.Green;
            Inicio.InactiveColor = Color.SlateBlue;
            button1LIstaProdutos.InactiveColor = Color.SlateBlue;
            button2Relatorio.InactiveColor = Color.SlateBlue;
            button3Vender.InactiveColor = Color.SlateBlue;
            button4CadastroUsuario.InactiveColor = Color.SlateBlue;

        }
        public static Image ConverterImagem(byte[] ImagemBytes)
        {
            if (ImagemBytes == null || ImagemBytes.Length == 0)
                return null;
            {

                using (MemoryStream ms = new MemoryStream(ImagemBytes))
                {
                    return Image.FromStream(ms);

                }
            }

        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            panel5IncialControler.Controls.Clear();
            PanelInicio.Dock = DockStyle.Fill;
            panel5IncialControler.Controls.Add(PanelInicio);

            Inicio.InactiveColor = Color.Green;
            ButtonCadastroProduto.InactiveColor = Color.SlateBlue;
            button1LIstaProdutos.InactiveColor = Color.SlateBlue;
            button2Relatorio.InactiveColor = Color.SlateBlue;
            button3Vender.InactiveColor = Color.SlateBlue;
            button4CadastroUsuario.InactiveColor = Color.SlateBlue;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaProdutos lista = new ListaProdutos();
            panel5IncialControler.Controls.Clear();
            lista.Dock = DockStyle.Fill;
            panel5IncialControler.Controls.Add(lista);

            button1LIstaProdutos.InactiveColor = Color.Green;
            ButtonCadastroProduto.InactiveColor = Color.SlateBlue;
            Inicio.InactiveColor = Color.SlateBlue;
            button2Relatorio.InactiveColor = Color.SlateBlue;
            button3Vender.InactiveColor = Color.SlateBlue;
            button4CadastroUsuario.InactiveColor = Color.SlateBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RelatorioVendas relatorio = new RelatorioVendas();

            panel5IncialControler.Controls.Clear();
            relatorio.Dock = DockStyle.Fill;
            panel5IncialControler.Controls.Add(relatorio);

            button2Relatorio.InactiveColor = Color.Green;
            ButtonCadastroProduto.InactiveColor = Color.SlateBlue;
            button1LIstaProdutos.InactiveColor = Color.SlateBlue;
            Inicio.InactiveColor = Color.SlateBlue;
            button3Vender.InactiveColor = Color.SlateBlue;
            button4CadastroUsuario.InactiveColor = Color.SlateBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas(usuariologado,this);

            panel5IncialControler.Controls.Clear();
            vendas.Dock = DockStyle.Fill;
            panel5IncialControler.Controls.Add(vendas);

            button3Vender.InactiveColor = Color.Green;
            ButtonCadastroProduto.InactiveColor = Color.SlateBlue;
            button1LIstaProdutos.InactiveColor = Color.SlateBlue;
            button2Relatorio.InactiveColor = Color.SlateBlue;
            Inicio.InactiveColor = Color.SlateBlue;
            button4CadastroUsuario.InactiveColor = Color.SlateBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroDeUsuario usuario = new CadastroDeUsuario();

            panel5IncialControler.Controls.Clear();
            usuario.Dock = DockStyle.Fill;
            panel5IncialControler.Controls.Add(usuario);

            button4CadastroUsuario.InactiveColor = Color.Green;
            ButtonCadastroProduto.InactiveColor = Color.SlateBlue;
            button1LIstaProdutos.InactiveColor = Color.SlateBlue;
            button2Relatorio.InactiveColor = Color.SlateBlue;
            button3Vender.InactiveColor = Color.SlateBlue;
            Inicio.InactiveColor = Color.SlateBlue;
        }

        private void Tela_Inicial_Load(object sender, EventArgs e)
        {
            AcesssoUsuarioPanel();
            Inicio.InactiveColor = Color.Green;
            AtualizarVendas();
            labelusuario.Text = usuariologado.Nome;
            label4NivelUsuario.Text = usuariologado.Nivelusuario;
            CadastroDeProduto.Id = usuariologado.Id;
            label6NomeDaLoja.Text = usuariologado.NomeLoja;
            pictureBoxTelaInicial.Image = ConverterImagem(usuariologado.Foto);
            
           
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            label6Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label7Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
