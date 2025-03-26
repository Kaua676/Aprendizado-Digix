using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Npgsql;
using Dapper;

namespace Exemplo_Dapper
{
    public class Conexao
    {
        private static readonly string conexaodb = "Host=localhost;Username=postgres;Password=root;Database=Aula 2";
        public static IDbConnection GetConexao()
        {
            return new NpgsqlConnection(conexaodb);
        }
    }
}