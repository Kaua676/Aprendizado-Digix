using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_12_2024.Relacoes.Composicao
{
    public class Computador
    {
        private Processador processador;

        public Computador()
        {
            processador = new Processador();
        }

        void Iniciar()
        {
            System.Console.WriteLine("Iniciando . . .");
            processador.Processar();
        }
    }
}

// A composição é quando a classe principal contem partes essenciais que não existem sem ela. EX.: 