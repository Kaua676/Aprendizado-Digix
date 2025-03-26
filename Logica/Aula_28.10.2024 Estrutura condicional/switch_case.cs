using System;

namespace Aula_Switch
{
    class Aula_Switch
    {

        static void Switch()
        {
            int idade = 49;
            switch(idade)
            {
                case int n when n >= 18 && n <=50:
                System.Console.WriteLine("Adulto");
                break;
                case int n when n > 50 && n <=100:
                System.Console.WriteLine("Idoso");
                break;
                case int n when n > 100:
                System.Console.WriteLine("Já morreu!");
                break;
                default:
                System.Console.WriteLine("Criança");
                break;
            }
        }
    }
}
