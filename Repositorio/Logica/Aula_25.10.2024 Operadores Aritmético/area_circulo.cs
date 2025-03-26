using System;

namespace Area_Circulo
{
    class Area_Circulo
    {
        static void Circulo()
        {
            Console.WriteLine("Digite o raio do círculo:");
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;

            double area = pi * (raio * raio);

            Console.WriteLine("A área do círculo é: " + area);
        }
    }

}