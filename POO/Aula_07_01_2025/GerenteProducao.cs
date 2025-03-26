using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_07_01_2025
{
    public class GerenteProducao : Empregado, IGerente
    {
        public RegiaoAtuacao Regiao { get; set; }

        public GerenteProducao(string name, RegiaoAtuacao regiao)
            : base(name, TipoEmpregado.GerenteProducao)
        {
            Regiao = regiao;
        }

        public void Autorizar()
        {
            Console.WriteLine("Gerente de Produção autorizado.");
        }

        public bool ConcedeAumento()
        {
            Console.WriteLine("Aumento concedido pelo gerente de produção.");
            return true;
        }

        public bool AutorizaLicenca(Empregado empregado)
        {
            Console.WriteLine($"Licença do empregado {empregado.GetName()} Aprovada.");
            empregado.StatusLicencaAtual = StatusLicenca.Aprovada;
            return true;
        }

        public override double GetSalario()
        {
            return dSalario * 1.2;
        }
    }
}