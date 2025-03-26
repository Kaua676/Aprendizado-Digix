using System;

namespace Area_Quadrado
{
    class Area_Quadrado
    {
        static void Quadrado()
        {
            System.Console.WriteLine("Digite o valor da base do quadrado: ");
            int x = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor da altura do quadrado: ");
            int y = int.Parse(Console.ReadLine());
            double area = (x * y);
            System.Console.WriteLine("Area do quadrado = " + area);
        }
    }

}