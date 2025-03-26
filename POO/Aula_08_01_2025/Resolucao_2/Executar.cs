// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Aula_08_01_2025.Resolucao_2;

// namespace Aula_08_01_2025.Resolucao_2
// {
//     public class Executar
//     {
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Digite o numero do quarto: ");
//             int roomNumber = int.Parse(Console.ReadLine());

//             System.Console.WriteLine("Digite a data de entrada (dd/MM/yyyy): ");
//             DateTime checkIn = DateTime.Parse(Console.ReadLine());

//             System.Console.WriteLine("Digite a data de saida (dd/MM/yyyy: ");
//             DateTime checkOut = DateTime.Parse(Console.ReadLine());

//             Reservation2 reservation2 = new Reservation2(roomNumber, checkIn, checkOut);
//             string error = reservation2.UpdateDates(checkIn, checkOut);

//             if (error != null)
//             {
//                 System.Console.WriteLine(error);
//             }
//             else
//             {
//                 System.Console.WriteLine("Reserva: " + reservation2);
//             }
//         }
//     }
// }