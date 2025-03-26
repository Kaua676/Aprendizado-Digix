using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_08_01_2025.Exercicio_1
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}