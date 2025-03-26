using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_18_12_2024.Exercicio2
{
public class EquipeVenda
{
    public string Nome { get; set; }

    public EquipeVenda(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return Nome;
    }
}

}