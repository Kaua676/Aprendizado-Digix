using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_12_2024.Animal
{
    public class Formiga : Animal
    {
        public Formiga() : base(6)
        {
        }
        public override void Come()
        {
            System.Console.WriteLine("A formiga come folha");
        }
    }
}