// using System;
// using System.Collections.Generic;
// using System.Data;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_08_01_2025.Resolucao_3
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

//             Reservation_3 reservation = new Reservation_3(roomNumber, checkIn, checkOut);
//             System.Console.WriteLine(reservation);

//             System.Console.WriteLine("Escreva os dados para atualizar a reserva: ");

//             System.Console.WriteLine("Digite a data de entrada (dd/MM/yyyy): ");
//             checkIn = DateTime.Parse(Console.ReadLine());

//             System.Console.WriteLine("Digite a data de saida (dd/MM/yyyy: ");
//             checkOut = DateTime.Parse(Console.ReadLine());

//             reservation.UpdateDates(checkIn, checkOut);
//             System.Console.WriteLine(reservation.ToString());
//         }
//     }
// }