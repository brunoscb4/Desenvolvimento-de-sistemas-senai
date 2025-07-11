using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Fenix_Shop.programação
{
    internal class ListaDeVendas
    {


        List<ListVendas> lista = new List<ListVendas>();
        

        public bool add(ListVendas vendas)
        {
            if (vendas != null)
            {
                lista.Add(vendas);
                return true;
            }
            else
            {
                return false;
            }
        }


        public void ExibirVendas(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            foreach (var item in lista)
            {
                    dataGridView.Rows.Add(item.Id,item.Produto,item.Quantidade,item.Valor,item.Foto);
            }
        }
    }
}
