using System;

namespace Aula_2
{
    class Exemplos_de_Operadores
    {
        static void Exemplos()
        {
            //Operadores Aritméticos
            int a = 20;
            int b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            System.Console.WriteLine("----------------------------------------");

            //Atribuição Aritmética
            int c = 10;
            int d = 5;
            c += d;
            Console.WriteLine(c);
            c -= d;
            Console.WriteLine(c);
            c *= d;
            Console.WriteLine(c);
            c /= d;
            Console.WriteLine(c);
            c %= d;
            Console.WriteLine(c);

            System.Console.WriteLine("----------------------------------------");

            //Operadores de Comparação
            int x = 10;
            int y = 5;
            Console.WriteLine(x == y); //False
            Console.WriteLine(x != y); //True
            Console.WriteLine(x >= y); //True
            Console.WriteLine(x <= y); //False
            Console.WriteLine(x > y);  //True
            Console.WriteLine(x < y);  //False

            System.Console.WriteLine("----------------------------------------");

            //Operadores Logicos
            bool w = true;
            bool z = false;
            Console.WriteLine(w && z);  //False
            Console.WriteLine(w || z);  //True
            Console.WriteLine(!w);      //False
            Console.WriteLine(!z);      //True
            Console.WriteLine(w && !z); //False
            Console.WriteLine(!w && z); //False
            Console.WriteLine(w || !z); //True
            Console.WriteLine(!w || z); //True

            System.Console.WriteLine("----------------------------------------");

            //Operadores de Incremento e Decremento
            int f = 10;
            Console.WriteLine(f++); //f = f + 1
            Console.WriteLine(++f); //f = f + 1
            Console.WriteLine(f--); //f = f - 1
            Console.WriteLine(--f); //f = f - 1

            System.Console.WriteLine("----------------------------------------");

            //Operadores Bitwise
            int g = 10;
            int h = 5;
            Console.WriteLine(g & h); //0000 1010
            Console.WriteLine(g | h); //0000 1011
            Console.WriteLine(g ^ h); //0000 1101
            Console.WriteLine(~g); //1111 0100
            Console.WriteLine(g << 1);
            Console.WriteLine(g >> 1);

            System.Console.WriteLine("----------------------------------------");
        }
    }
}