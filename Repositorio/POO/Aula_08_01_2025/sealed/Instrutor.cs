using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_08_01_2025
{
    public class Instrutor : Coordenador
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine("Salario base: " + salario * 4);
        }

    }
}