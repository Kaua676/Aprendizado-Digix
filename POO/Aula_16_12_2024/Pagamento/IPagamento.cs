using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_12_2024
{
    public interface IPagamento
    {
        void RealizarPagamento(double valor); // Isso é implicitamente um método publico e abstrato.
        void ExibirComprovante(); // Isso é implicitamente um método público e abstrato

    }
}