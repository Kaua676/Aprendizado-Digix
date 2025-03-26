using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_16_12_2024.Animal;

namespace Aula_16_12_2024.Animal
{
    public class Peixe : Animal, IAnimalDeEstimacao
    {
        private string _Nome = "";

        public Peixe(int pernas) : base(pernas)
        {

        }

        public Peixe(string nome) : base(0)
        {
            _Nome = nome;
        }

        public string getNome()
        {
            return _Nome;
        }
        public void setNome(string nome)
        {
            _Nome = nome;
        }
        public void Brinca()
        {
            Console.WriteLine($"{_Nome} está brincando nas profudenzas do rio Aquidauana");
        }
        public override void Come()
        {
            Console.WriteLine($"{_Nome} está comendo Lambari.");
        }

    }
}