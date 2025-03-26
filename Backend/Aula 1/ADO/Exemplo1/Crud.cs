using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using System.Diagnostics;

namespace Exemplo1
{
    public class Crud
    {
        // Configurações de conexão com o banco de dados
        string conexao = "Host=localhost;Username=postgres;Password=root;Database=Aula 1";

        void InserirUsuario(int id, string nome, string email)
        {
            string query = $"INSERT INTO pessoa (id, nome, email) VALUES ({id}, '{nome}', '{email}')";
            using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    // Parameters para a query, que são os valores que serão inseridos
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        void LerUsuario()
        {
            string query = "SELECT * from pessoa";

            using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
            {
                conn.Open();
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
                        }
                    }
                }
            }
        }

        void AtualizarUsuario(int id, string nome)
        {
            // Dando update nos dados na tabela pessoa
            string update_query = $"update pessoa set nome = '{nome}' where id = {id}";
            using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(update_query, conn))
                {
                    // Parameters para a query, que são os valores que serão inseridos
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        void DeletarUsuario(int id)
        {
            // Deletando os dados na tabela pessoa
            string delete_query = $"delete from pessoa WHERE id= {id}";
            using (NpgsqlConnection conn = new NpgsqlConnection(conexao))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(delete_query, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void Main(string[] args)
        {
            Crud crud = new Crud();

            Stopwatch sw = new Stopwatch(); // Classe que representa um contador de tempo de execução
            TimeSpan tempo_total; // Variavel que vai armazenar o tempo total de execução


            // Medindo o tempo de Inserção
            sw.Start(); // Inicia o cronometro
            System.Console.WriteLine("---------------------");
            crud.InserirUsuario(1, "Williandantes", "will@gmail.com");
            System.Console.WriteLine("Usuario Inserido!");
            sw.Stop(); // Para o cronometro
            System.Console.WriteLine($"Tempo de inserção: {sw.ElapsedMilliseconds}ms"); // ElapsedMilliseconds é o tempo total em milisegundos que foi decorrido durante a execução do código.
            TimeSpan tempoInsercao = sw.Elapsed; // Armazena o tempo de inserção

            sw.Restart();
            System.Console.WriteLine("---------------------");
            crud.LerUsuario();
            System.Console.WriteLine($"Tempo de Leitura: {sw.ElapsedMilliseconds}ms"); // ElapsedMilliseconds é o tempo total em milisegundos que foi decorrido durante a execução do código.
            TimeSpan tempoLeitura = sw.Elapsed; // Armazena o tempo de inserção

            sw.Restart(); // Reinicia o cronometro
            System.Console.WriteLine("---------------------");
            crud.AtualizarUsuario(1, "Fulano");
            System.Console.WriteLine("Usuario Alterado!");
            System.Console.WriteLine($"Tempo de update: {sw.ElapsedMilliseconds}ms"); // ElapsedMilliseconds é o tempo total em milisegundos que foi decorrido durante a execução do código.
            TimeSpan tempoUpdate = sw.Elapsed; // Armazena o tempo de inserção

            sw.Restart();
            System.Console.WriteLine("---------------------");
            crud.LerUsuario();
            System.Console.WriteLine($"Tempo de Leitura 2: {sw.ElapsedMilliseconds}ms"); // ElapsedMilliseconds é o tempo total em milisegundos que foi decorrido durante a execução do código.
            TimeSpan tempoLeitura2 = sw.Elapsed; // Armazena o tempo de inserção

            sw.Restart();
            System.Console.WriteLine("---------------------");
            crud.DeletarUsuario(1);
            System.Console.WriteLine("Usuario deletado!");
            System.Console.WriteLine($"Tempo de delete: {sw.ElapsedMilliseconds}ms"); // ElapsedMilliseconds é o tempo total em milisegundos que foi decorrido durante a execução do código.
            TimeSpan tempoDelete = sw.Elapsed; // Armazena o tempo de inserção

            // Calculando tempo total de execução
            tempo_total = tempoInsercao + tempoLeitura + tempoUpdate + tempoLeitura2 + tempoDelete;
            System.Console.WriteLine($"Tempo total de execução: {tempo_total}");
        }
    }
}