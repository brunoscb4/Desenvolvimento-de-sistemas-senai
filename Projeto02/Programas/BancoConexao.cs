using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Programas
{
    class BancoConexao
    {
        private const String server = "localhost";
        private const string dataBase = "CadastroJogos";
        private const string user = "root";
        private const string password = "";


        public static string Conexao = $"Server={server};Database={dataBase};Uid={user};Pwd={password};";
    }
}
