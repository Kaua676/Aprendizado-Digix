using System;

namespace Sobrecarga
{
    class Program
    {
        //Sobrecarga de métodos/funções

        static int ParOuImpar(int num)
        {
            if (num % 2 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        static void Pi();
        {
            // return 3.14;
            System.Console.WriteLine("3.14");
        }

        static int ParOuImpar(double num)
        {
            if (num % 2 == 0)
            {
                return 24;
            }
            else
            {
                return 25;
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um numero: ");
            double num = double.Parse(Console.ReadLine());

            //Chamando a função ParOuImpar
            System.Console.WriteLine("Numero é: " + ParOuImpar((int)num));

            System.Console.WriteLine(Pi());
        }
    }
}