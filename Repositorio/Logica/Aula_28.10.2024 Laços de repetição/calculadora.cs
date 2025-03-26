using System;

namespace Aula_4
{

    class Calculadora
    {
        public static void Main(string[] args)
        {
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine($"Tabuada do {j}: ");
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{j} x {i} = {j * i}");
                }
            }
            Console.Clear();

            int x = 0;
            while (x <= 10)
            {
                Console.WriteLine($"Tabuada do {x}: ");
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{x} x {i} = {x * i}");
                }
                x++;
            }

            Console.Clear();

            int y = 0;
            do
            {
                Console.WriteLine($"Tabuada do {y}: ");
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{y} x {i} = {y * i}");
                }
                y++;
            } while (y <= 10);
        }

    }


}