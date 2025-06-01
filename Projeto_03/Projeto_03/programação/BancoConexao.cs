using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_03.programação
{
    internal class BancoConexao
    {
        private const string server = "localhost";
        private const string Database = "tarefas";
        private const string usuario = "root";
        private const string senha = "";

        public static string conexao = $"Server={server};Database={Database};Uid={usuario};Pwd={senha};";

    }
}
