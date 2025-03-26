// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_08_01_2025.Resolucao_1
// {
//     public class Execucao
//     {
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Digite o numero do quarto: ");
//             int roomNumber = int.Parse(Console.ReadLine());

//             System.Console.WriteLine("Digite a data de entrada (dd/MM/yyyy): ");
//             DateTime checkIn = DateTime.Parse(Console.ReadLine());

//             System.Console.WriteLine("Digite a data de saida (dd/MM/yyyy: ");
//             DateTime checkOut = DateTime.Parse(Console.ReadLine());

//             if (checkIn < DateTime.Now || checkOut < DateTime.Now)
//             {
//                 System.Console.WriteLine("Data inválida!");
//             }
//             else if (checkIn > checkOut)
//             {
//                 System.Console.WriteLine("Entrada maior que a saida!");
//             }
//             else
//             {
//                 Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
//                 System.Console.WriteLine(reservation.ToString());

//                 System.Console.WriteLine("Digite a data de entrada (dd/MM/yyyy): ");
//                 checkIn = DateTime.Parse(Console.ReadLine());

//                 System.Console.WriteLine("Digite a data de saida (dd/MM/yyyy: ");
//                 checkOut = DateTime.Parse(Console.ReadLine());

//                 reservation.UpdateDates(checkIn, checkOut);
//                 System.Console.WriteLine(reservation.ToString());
//             }
//         }
//     }
// }