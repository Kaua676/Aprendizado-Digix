using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_08_01_2025.Resolucao_2
{
    public class Reservation2
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation2(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return $"Quarto: {RoomNumber}\nEntrada: {CheckIn:dd/MM/yyyy}\nSaida: {CheckOut:dd/MM/yyyy}\nDuracao: {Duration()} dias";
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn < DateTime.Now || checkOut < DateTime.Now)
            {
                return "Data inválida!";
            }
            if (checkIn > checkOut)
            {
                return "Entrada maior que a saida!";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

            return null;
        }
    }
}