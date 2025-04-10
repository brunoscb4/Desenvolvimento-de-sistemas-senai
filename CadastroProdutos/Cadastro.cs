using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProdutos
{
    class Cadastro
    {

        private string categoria;
        private string nome;
        private double preco;

        public Cadastro()
        {
            this.categoria = "";
            this.nome = "";
            this.preco = 0;
        }


        public  string Categoria 
        {
            get { return categoria; }
            set { this.categoria = value; }
        }

        public  string Nome
        {
            get { return nome; }
            set { this.nome = value; }
        }

        public  double Preco
        {
            get { return preco; }
            set { this.preco = value; }
        }
            
            }
}
