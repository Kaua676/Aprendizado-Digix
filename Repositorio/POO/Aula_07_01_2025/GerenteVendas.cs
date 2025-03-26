using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_07_01_2025
{
    public class GerenteVendas : Vendedor, IGerente
    {
        protected string SRegiao { get; set; }

        public GerenteVendas(string name, double salario, string regiao) : base(name, salario)
        {
            SRegiao = regiao;
        }
        public void Autorizar()
        {
            Console.WriteLine($"Gerente de vendas autorizado para a região: {SRegiao}");
        }
        public bool ConcedeAumento()
        {
            Console.WriteLine("Aumento concedido pelo gerente de vendas.");
            return true;
        }
        public bool AutorizaLicenca(Empregado empregado)
        {
            Console.WriteLine($"Licença do empregado {empregado.GetName()} autorizada.");
            return true;
        }
        public override double GetSalario()
        {
            return dSalario * 1.2;
        }
    }
}