using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_08_01_2025
{
    public class Coordenador : Funcionario
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine("Salario base: " + salario * 3);
        }

        public sealed override void Trabalhar()
        {
            System.Console.WriteLine("Coordenando...");	
        }
    }
}