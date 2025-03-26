using System;

namespace Modificadores
{
    public class Modificadores
    {
        //Função publica
        public int soma(int a, int b)
        {
            return a + b;
        }

        //Função estática
        static int subtracao(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            //Chamar a função soma
            Modificadores m = new Modificadores();
            System.Console.WriteLine(m.soma(10, 20));

            //Chamar a função subtracao
            System.Console.WriteLine(subtracao(10, 20));
        }
    }
}