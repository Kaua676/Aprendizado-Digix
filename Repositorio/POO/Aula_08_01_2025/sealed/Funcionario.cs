using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_08_01_2025
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public virtual void Salario(int salario)
        {
            System.Console.WriteLine("Salario base: " + salario);
        }

        public virtual void Trabalhar()
        {
            System.Console.WriteLine("Trabalhando...");
        }
        
    }
}