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
       
        public Tela_Inicial(UsuarioLogado usuariologado)
        {
            InitializeComponent();
            this.usuariologado = usuariologado;
        }

        private void CadastroProdutos_Click(object sender, EventArgs e)
        {
            CadastroProdutos cadastro = new CadastroProdutos();
            panel5IncialControler.Controls.Clear();
            cadastro.Dock = DockStyle.Fill;
            panel5IncialControler.Controls.Add(cadastro);


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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaProdutos lista = new ListaProdutos();
            panel5IncialControler.Controls.Clear();
            lista.Dock = DockStyle.Fill;
            panel5IncialControler.Controls.Add(lista);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RelatorioVendas relatorio = new RelatorioVendas();

            panel5IncialControler.Controls.Clear();
            relatorio.Dock = DockStyle.Fill;
            panel5IncialControler.Controls.Add(relatorio);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();

            panel5IncialControler.Controls.Clear();
            vendas.Dock = DockStyle.Fill;
            panel5IncialControler.Controls.Add(vendas);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroDeUsuario usuario = new CadastroDeUsuario();

            panel5IncialControler.Controls.Clear();
            usuario.Dock = DockStyle.Fill;
            panel5IncialControler.Controls.Add(usuario);
        }

        private void Tela_Inicial_Load(object sender, EventArgs e)
        { 
            ItensVendidos itensVendidos = new ItensVendidos();
            itensVendidos.IdUser = usuariologado.Id;
            labelusuario.Text = usuariologado.Nome;
            label4NivelUsuario.Text = usuariologado.Nivelusuario;
            CadastroDeProduto.Id = usuariologado.Id;
            label6NomeDaLoja.Text = usuariologado.NomeLoja;
            pictureBoxTelaInicial.Image = ConverterImagem(usuariologado.Foto);
        }

        private void labelNumeroDeCadastrados_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxTelaInicial_Click(object sender, EventArgs e)
        {

        }
    }
}
