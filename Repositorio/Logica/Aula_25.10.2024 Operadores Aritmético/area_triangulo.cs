using System;

namespace Area_Triangulo
{
    class Area_Triangulo
    {
        static void triangulo()
        {
            System.Console.WriteLine("Digite o valor da base do triangulo: ");
            int x = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor da altura do triangulo: ");
            int y = int.Parse(Console.ReadLine());
            double area = (x * y) / 2;
            System.Console.WriteLine("Area do triangulo = " + area);
        }
    }

}