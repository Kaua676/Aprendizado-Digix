using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_12_2024
{
    public record class Animal
    {
        public bool Vivo = true;

        // Metodo Construtor
        public Animal(bool vivo)
        {
            this.Vivo = vivo;
        }
    }

}