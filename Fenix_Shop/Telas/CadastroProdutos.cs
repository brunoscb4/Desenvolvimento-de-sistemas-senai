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
    public partial class CadastroProdutos : UserControl
    {
        public CadastroProdutos()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.CadastroProdutos_Resize);
        }

        private void PanelCadastroProduto_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void CadastroProdutos_Resize(object sender, EventArgs e)
        {
            PanelCadastroProduto.Width = this.ClientSize.Width;
            PanelCadastroProduto.Height = this.ClientSize.Height;

            

        }
    }
}
