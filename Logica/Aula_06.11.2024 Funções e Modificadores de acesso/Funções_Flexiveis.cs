using System;

namespace Funções_Flexiveis
{
    public class Program
    {
        //Eles permitem que uma funcao receba um numero variavel de argumentos
        //Eles podem ser usados para passar argumentos de uma funcao para outra

        //Declaração de um delegate
        public delegate int Operacao(int a, int b);
        
        //Expressao lambda
        static int Soma(int a, int b) => a + b;

        //Juntar 2 funções no delegate
        public delegate void Notificar();
        public static void EnvioEmail() => System.Console.WriteLine("Enviando email...");

        public static void EnvioSMS() => System.Console.WriteLine("Enviando SMS..."); 

        static void Main(string[] args)
        {
            Operacao op = Soma;
            System.Console.WriteLine(op(3,2));

            //Atribuir diretamente a expressão lambda
            Operacao op2 = (int a, int b) => a - b;
            System.Console.WriteLine(op2(3,2));
        
            //Metodo anonimo
            Func<int, int, int> op3 = delegate(int a, int b) { return a * b; };
            System.Console.WriteLine(op3(3,2));

            //Delegade Multicast
            Notificar notificar = EnvioEmail;
            notificar += EnvioSMS;
            notificar();
        }
    }
}