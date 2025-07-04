﻿using Fenix_Shop.programação;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (panel5IncialControler.Controls.Contains(cadastro))
            {
              ButtonCadastroProduto.InactiveColor = Color.Green;
            }
            else 
            {
                ButtonCadastroProduto.InactiveColor = Color.SlateBlue;
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
            labelusuario.Text = usuariologado.Nome;
            label4NivelUsuario.Text = usuariologado.Nivelusuario;
            CadastroDeProduto.Id = usuariologado.Id;
        }

        private void labelusuario_Click(object sender, EventArgs e)
        {

        }
    }
}
