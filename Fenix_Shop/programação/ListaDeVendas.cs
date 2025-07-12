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
        private decimal valorTotal,valor,total;
        private int quantidadeItensVendidos ;
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
                dataGridView.Rows.Add(item.Id, item.Produto, item.Quantidade, item.Valor,item.Total);
            }
        }

        public decimal ValorTotal()
        {


            if (lista == null || lista.Count == 0)
                return 0;
            {

                var ultimoItem = lista[lista.Count - 1];
                valor = ultimoItem.Valor * ultimoItem.Quantidade;
                valorTotal += valor;

            }
            return valorTotal;

        }

        public decimal Total()
        {
            

            if (lista == null || lista.Count == 0)
                return 0;
            {
             
                var ultimoItem = lista[lista.Count - 1];
                valor =  ultimoItem.Valor * ultimoItem.Quantidade;
                total += valor;
                
            }
            return total;
           
        }
        public decimal QuantidadeVendidos()
        {


            if (lista == null || lista.Count == 0)
                return 0;
            {

                var ultimoItem = lista[lista.Count - 1];
                quantidadeItensVendidos = quantidadeItensVendidos + ultimoItem.Quantidade;
                

            }
            return quantidadeItensVendidos;

        }
    }
}
