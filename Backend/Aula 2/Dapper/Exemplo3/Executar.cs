// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using System.Diagnostics;

// namespace Exemplo_Dapper
// {
//     public class Executar
//     {
//         static void Main(string[] args)
//         {
//             CRUD crud = new CRUD();

//             Stopwatch sw = new Stopwatch(); // Classe que representa um contador de tempo de execução
//             TimeSpan tempo_total; // Variavel que vai armazenar o tempo total de execução

//             sw.Start(); // Inicia o cronometro
//             crud.ListarUsuario();
//             sw.Stop(); // Para o cronometro
//             System.Console.WriteLine($"Tempo de inserção: {sw.ElapsedMilliseconds}ms");
//             TimeSpan tempoInsercao = sw.Elapsed;
//             System.Console.WriteLine("------------------");

//             sw.Restart();
//             System.Console.WriteLine("Inserindo um novo usuário");
//             crud.InserirUsuario(7, "Fulnao", "fulano@gmail.com");
//             crud.ListarUsuario();
//             System.Console.WriteLine($"Tempo de Leitura: {sw.ElapsedMilliseconds}ms");
//             TimeSpan tempoLeitura = sw.Elapsed;
//             System.Console.WriteLine("-------------------");

//             System.Console.WriteLine("Atualizando um usuário");
//             crud.AtualizarUsuario(7, "Fulano da Silva");
//             crud.ListarUsuario();
//             System.Console.WriteLine($"Tempo de Atualização: {sw.ElapsedMilliseconds}ms");
//             TimeSpan tempoUpdate = sw.Elapsed;
//             System.Console.WriteLine("-------------------");

//             System.Console.WriteLine("Deletando um usuário");
//             crud.DeletarUsuario(7);
//             crud.ListarUsuario();
//             System.Console.WriteLine($"Tempo de Delete: {sw.ElapsedMilliseconds}ms");
//             TimeSpan tempoDelete = sw.Elapsed;
//             System.Console.WriteLine("-------------------");

//             tempo_total = tempoInsercao + tempoLeitura + tempoUpdate + tempoDelete;
//             System.Console.WriteLine($"Tempo total de execução: {tempo_total}");
//         }
//     }
// }