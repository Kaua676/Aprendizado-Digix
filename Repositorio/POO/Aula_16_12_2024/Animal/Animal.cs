using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_12_2024.Animal
{
    public class Animal
    {
        protected int Pernas = 0;

        public Animal(int pernas)
        {
            Pernas = pernas;
        }

        public void Caminha()
        {
            Console.WriteLine("O animal está caminhando.");
        }

        public virtual void Come()
        {
            System.Console.WriteLine("O animal esá comendo");
        }
    }
}