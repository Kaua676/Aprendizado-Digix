using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_08_01_2025
{
    // Sealed é quando não pode ser herdado
    public sealed class Gerente : Funcionario
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine("Salario base: " + salario * 2);
        }

        public override void Trabalhar()
        {
            System.Console.WriteLine("Gerenciando...");
        }
    }
}