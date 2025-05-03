using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiGerenciadorProdutos.Progamação
{
    internal class BancoConection
    {

        private const string servidor = "localhost";
        private const string BancoDados = "GerenciadorProdutos";
        private const string usuario = "root";
        private const string senha = "120430";

        static public string ConexaoBanco = $"Server={servidor};DataBase={BancoDados};Uid={usuario};Pwd={senha};";

    }
}
