using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_07_01_2025
{
    public class Pessoa
    {
        protected string SName;

        public Pessoa(string name)
        {
            SName = name;
        }
        public Pessoa() { }

        public void SetName(string name)
        {
            SName = name;
        }

        public string GetName()
        {
            return SName;
        }
    }
}