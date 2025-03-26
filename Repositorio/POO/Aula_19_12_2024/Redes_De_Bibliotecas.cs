using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_12_2024
{
    public class RedeDeBibliotecas
    {
        public List<Biblioteca> Bibliotecas { get; set; }

        public RedeDeBibliotecas()
        {
            Bibliotecas = new List<Biblioteca>();
        }

        public void AdicionarBiblioteca(Biblioteca biblioteca)
        {
            Bibliotecas.Add(biblioteca);
        }

        public void RemoverBiblioteca(Biblioteca biblioteca)
        {
            Bibliotecas.Remove(biblioteca);
        }
    }
}