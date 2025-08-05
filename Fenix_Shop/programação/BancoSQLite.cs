using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Fenix_Shop.programação
{
    public  class BancoSQLite
    {
        private static  string caminho = "Phenix.db";
        public static readonly string ConexaoSQlite = $"Data Source={caminho};Version=3;";


        public static void CriarBancoETabela()
        {
            if (!File.Exists(caminho))
            {
                SQLiteConnection.CreateFile(caminho);
                 MessageBox.Show("Banco criado com sucesso!");
            }
           

                using (var connection = new SQLiteConnection(ConexaoSQlite))
                {
                    connection.Open();

                    using (var cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    string sql = @"
            CREATE TABLE IF NOT EXISTS Usuario (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nome TEXT NOT NULL,
                Email TEXT UNIQUE NOT NULL,
                Senha TEXT NOT NULL, 
                NivelUsuario TEXT NOT NULL CHECK  (NivelUsuario IN ('ADMINISTRADOR','GERENTE','VENDEDOR')),
                Cpf TEXT UNIQUE,
                NomeLoja TEXT UNIQUE,
                Telefone TEXT UNIQUE,
                DataDeCadastro DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                Foto BLOB
              
            );

            CREATE TABLE IF NOT EXISTS CadastroProduto (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                IdUsuario INT NOT NULL,
                Nome TEXT NOT NULL,
                Categoria TEXT,
                Descricao TEXT,
                Marca TEXT,
                ValorDeCusto  INTEGER NOT NULL,
                ValorDeVenda INTEGER NOT NULL,
                CodigoDeBarras TEXT UNIQUE,
                Sku TEXT UNIQUE,
                EstoqueMinimo INTEGER CHECK(EstoqueMinimo > 0),
                DataDeCadastro DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                Foto BLOB,
                StatusDoProduto TEXT NOT NULL CHECK (StatusDoProduto IN('ATIVO','INATIVO')),
                FOREIGN KEY (Idusuario) REFERENCES Usuario (Id)

            );

            CREATE TABLE IF NOT EXISTS Estoque (
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 IdProduto INTEGER NOT NULL,
                 Tipo TEXT NOT NULL CHECK (Tipo IN ('ENTRADA','SAIDA')),
                 Quantidade INTEGER NOT NULL CHECK (Quantidade >= 0),
                 ValorUnitario INTEGER NOT NULL,
                 DataDaMovimentacao DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                 FOREIGN KEY (IdProduto) REFERENCES CadastroProduto(Id) ON DELETE CASCADE ON UPDATE CASCADE
                 
            );
        
            CREATE TABLE IF NOT EXISTS Vendas (
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 IdUsuario INTEGER NOT NULL,
                 DataVenda DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                 Total INTEGER NOT NULL,
                 FormaDePagamento TEXT NOT NULL CHECK (FormaDePagamento IN ('DINHEIRO','CREDITO','DEBITO','PIX','OUTROS')),
                 FOREIGN KEY (IdUsuario) REFERENCES Usuario(Id)

            );

            CREATE TABLE IF NOT EXISTS ItensVendidos (
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 IdVenda INTEGER NOT NULL,
                 IdProduto INTEGER NOT NULL,
                 Quantidade INTEGER NOT NULL CHECK (Quantidade >= 0),
                 PrecoUnitario INTEGER NOT NULL,
                 DataDaMovimentacao DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                 FOREIGN KEY (IdVenda) REFERENCES Vendas (Id) ON DELETE CASCADE,
                 FOREIGN KEY (IdProduto) REFERENCES CadastroProduto(Id)

            ); 
            
             ";

                    using (var cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Tabelas criadas com sucesso!");
                       
                    }
                  

                    connection.Close();

                }

            
        }



    }
}
