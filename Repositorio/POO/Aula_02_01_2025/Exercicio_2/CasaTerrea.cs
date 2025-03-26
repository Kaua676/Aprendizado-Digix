using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_02_01_2025.Exercicio_2
{
    public class CasaTerrea : Casa
    {
        public CasaTerrea(bool condominio, float metragemTotal, string endereco, Engenheiro responsavel)
            : base(condominio, metragemTotal, endereco, responsavel) { }
    }
}