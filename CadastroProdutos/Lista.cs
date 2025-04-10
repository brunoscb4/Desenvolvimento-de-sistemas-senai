using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProdutos
{
    class Lista
    {
        private int cont = 0;
        Cadastro cadastro = new Cadastro();
        List<Cadastro> lista = new List<Cadastro>();

        public Lista ()
        {
            this.cont = 0;
        }
        public int Cont 
        {
            get { return cont; }
        }
        public void Add (Cadastro cadastro)
        {
            lista.Add(cadastro);
            
            cont ++;
        }

        public List<Cadastro> ListarCadastrados()
        {
            return lista;
        }
    }
}
