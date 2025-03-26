using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_12_2024
{
    public record class Cobra : Animal
    {
        public bool Venenosa = true;

        public Cobra(bool venenosa, bool Vivo) : base(Vivo)
        {
            this.Venenosa = venenosa;
        }
        public void Alimento(string a)
        {
            System.Console.WriteLine($"A cobra se alimenta de {a}");
        }
        public bool SetVenenosa(bool v)
        {
            return v;
        }
    }
}