using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_12_2024
{
    public interface IAnuidade
    {
        // Função para calcular data do vencimento
        DateTime CalcularDataVencimento();

        double CalcularValorAnuidade();
    }
}