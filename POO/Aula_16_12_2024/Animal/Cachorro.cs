using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_12_2024.Animal
{
    public class Cachorro : Animal, IAnimalDeEstimacao
    {
        private string _Nome = "";

        public Cachorro(int pernas) : base(pernas)
        {

        }

        public Cachorro(string nome) : base(4)
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
            Console.WriteLine($"{_Nome} está brincando na terra.");
        }
        public override void Come()
        {
            Console.WriteLine($"{_Nome} está comendo ração da Max.(boy)");
        }
    }
}