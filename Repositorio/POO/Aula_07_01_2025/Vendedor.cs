using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_07_01_2025
{
    public class Vendedor : Empregado
    {
        protected double dComissao;

        public Vendedor(string name, double comissao)
            : base(name, TipoEmpregado.Vendedor)
        {
            dComissao = comissao;
        }

        public override double GetSalario()
        {
            return dSalario + dComissao;
        }
    }
}
