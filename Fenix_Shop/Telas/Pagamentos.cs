
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fenix_Shop.Enums;

namespace Fenix_Shop.Telas
{
    public partial class Pagamentos : UserControl
    {
        private Vendas vendas;
        public Pagamentos(Vendas vendas)
        {
            InitializeComponent();
            this.vendas = vendas;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void button1Credito_Click(object sender, EventArgs e)
        {
            Vendas.VerificaPagamento = TipoDePagamento.CREDITO.ToString();
            vendas.AtualizarVenda();
            this.Parent.Controls.Remove(this);
        }

        private void button1Debito_Click(object sender, EventArgs e)
        {
            Vendas.VerificaPagamento = TipoDePagamento.DEBITO.ToString();
            vendas.AtualizarVenda();
            this.Parent.Controls.Remove(this);
        }

        private void button1Pix_Click(object sender, EventArgs e)
        {
            Vendas.VerificaPagamento = TipoDePagamento.PIX.ToString();
            vendas.AtualizarVenda();
            this.Parent.Controls.Remove(this);
        }

        private void button1Dinheiro_Click(object sender, EventArgs e)
        {
            Vendas.VerificaPagamento = TipoDePagamento.DINHEIRO.ToString();
            vendas.AtualizarVenda();
            this.Parent.Controls.Remove(this);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
