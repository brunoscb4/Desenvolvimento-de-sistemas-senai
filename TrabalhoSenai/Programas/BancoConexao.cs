using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoSenai.Programas
{
     class BancoConexao
    {
        private const string servidor = "localhost";
        private const string bancoDados = "Marketplace";
        private const string usuario = "root";
        private const string senha = "120430";


        static public readonly string ConexaoBancoDados = $"Server={servidor};Database={bancoDados};Uid={usuario};Pwd={senha};";

    }
}
