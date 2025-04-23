using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista16
{
    class conexaoBanco
    {
        private const string servidor = "localhost";
        private const string bancoDados = "Lista16";
        private const string usuario = "root";
        private const string senha = "";

        static public string conexaoBancoDados = $"Server={servidor};Database={bancoDados};Uid={usuario};Pwd={senha};";


    }
}
