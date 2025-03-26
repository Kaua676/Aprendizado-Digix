using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_08_01_2025.Resolucao_3
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { 
            System.Console.WriteLine("Erro");
        }
    }
}