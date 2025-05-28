using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_05.Programação
{
    internal class BancoConexao
    {
        private const string server = "localhost";
        private const string Database = "agenda";
        private const string user = "root";
        private const string password = "";

        public static string Conexao = $"Server={server};Database={Database};Uid={user};Pwd={password};";
    }
}
