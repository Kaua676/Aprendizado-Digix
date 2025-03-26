// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_17_01_2025
// {
//     public class ClasseTask
//     {
//         // O ascync é quando a função é assincrona e o await e quando a função é sincrona
//         // É executada de forma que o programa não fica travado esperando o resultado 
//         static async Task Main(string[] args)
//         {
//             Console.WriteLine("Iniciando o programa...");
//             int resultado = await Somar(10, 5);

//             Console.WriteLine($"Resultado: {resultado}");
//             Console.WriteLine("Fim do programa.");
//         }

//         static Task<int> Somar(int a, int b)
//         {
//             return Task.Run(() =>
//             {
//                 Task.Delay(1000000).Wait();
//                 return a + b;
//             });
//         }
//     }
// }