using System;

namespace Funcoes_Avançadas
{
    public class Variaveis_Implicitas
    {
        static int Quadrado(int x){
            return x * x;
        }

        //Usando ref
        static void QuadradoRef(ref int x){
            x = x * x;
        }

        //Out
        static int QuadradoOut(out int x){
            x = 6;
            return x * x;
        }

        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(Quadrado(a));
            System.Console.WriteLine(a);
            QuadradoRef(ref a);
            System.Console.WriteLine(a);
            QuadradoOut(out x);
            System.Console.WriteLine(x);
        }
    }
}