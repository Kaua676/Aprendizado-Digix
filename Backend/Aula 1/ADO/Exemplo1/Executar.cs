using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetEnv;


// Para utilizar a conexão com o banco de dados, precisamos instalar o pacote Npgsql
using Npgsql;

namespace Exemplo1
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Env.Load();

            // Configurações de conexão com o banco de dados
            string conexao = "Host=localhost;Username=postgres;Password=root;Database=Aula 1;";

            // Cria uma conexão com o banco de dados
            using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
            {
                try
                {
                    // Abre a conexão com o banco de dados
                    conn.Open();
                    System.Console.WriteLine("Conectado ao banco de dados com sucesso!");

                    // Imprimir informações sobre o banco de dados
                    string query = "SELECT * from public.pessoa";

                    // Inserindo os dados
                    // Inserir dados na tabela pessoa
                    string insert_query = "Insert into public.pessoa(id, nome, email) values (8, 'Kaua Vicente', 'kaua@gmail.com')";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(insert_query, conn))
                    {
                        int row = cmd.ExecuteNonQuery(); // ExecuteNonQuery executa um comando que não retorna dados, como insert, update, delete
                        System.Console.WriteLine("Linhas afetadas: " + row);
                    }

                    // Deletando os dados
                    // Deletando os dados na tabela pessoa
                    string delete_query = "delete from public.pessoa WHERE id=1";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(delete_query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Update dos dados
                    // Dando update nos dados na tabela pessoa
                    string update_query = "update pessoa set nome = 'Arthur das calabresas' where id = 2";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(update_query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Imprimindo os dados
                    // NpgsqlCommand permite executar comandos SQL
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Npgsql representa um leitor de dados do banco de dados
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            System.Console.WriteLine("Tabelas do banco de dados: ");
                            while (reader.Read())
                            {
                                System.Console.WriteLine($"Id: {reader["id"]}\nNome: {reader["nome"]}\nEmail: {reader["email"]}");

                                // System.Console.WriteLine($"Id: {reader.GetInt32(0)}\n Nome: {reader.GetString(1)}\n Email: {reader.GetString(2)}");
                            }
                        }
                    }
                }
                catch (NpgsqlException e)
                {
                    // Exibe uma mensagem de erro caso a conexão falhe
                    Console.WriteLine("Erro ao conectar ao banco de dados: " + e.Message);
                }
            }
        }
    }
}