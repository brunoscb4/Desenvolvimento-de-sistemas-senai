using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Fenix_Shop.programação
{
    internal class ListVendas
    {
        private int id;
        private string produto;
        private int quantidade;
        private decimal valor,total;
      

        public int Id
        {  get { return id; } set { id = value; } }
        public string Produto 
        { get { return produto; } set { produto = value; } }
        public int Quantidade 
        { get {return quantidade; } set { quantidade = value; }}
                
        public decimal Valor
        { get { return valor; } set { valor = value; } }
        public decimal Total
        { get { return total; } set { total = value; } }


    }
}
