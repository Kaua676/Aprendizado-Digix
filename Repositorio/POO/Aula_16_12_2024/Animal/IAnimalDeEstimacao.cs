using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_12_2024.Animal
{
    public interface IAnimalDeEstimacao
    {
        string getNome();
        void setNome(string nome);
        void Brinca();
    }
}