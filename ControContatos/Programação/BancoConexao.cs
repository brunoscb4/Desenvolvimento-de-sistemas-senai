using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControContatos.Programação
{
    class BancoConexao
    {

        public const string server = "localhost";
        public const string DataBase = "ControleContatos";
        public const string user = "root";
        public const string senha = "";

        public static string Conexao = $"Server={server};Database={DataBase};Uid={user};Pwd={senha}";
    }
}
