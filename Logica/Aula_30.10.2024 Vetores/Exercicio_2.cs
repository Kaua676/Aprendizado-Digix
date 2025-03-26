using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "Digix";
            System.Console.WriteLine("Digite uma palavra: ");
            senha = Console.ReadLine();

            while (senha != "Digix")
            {
                System.Console.WriteLine("Senha inválida. Tente novamente: ");
                senha = Console.ReadLine();

                if(senha == "Digix"){
                    System.Console.WriteLine("Senha correta!");
                }
            }

        }
    }
}