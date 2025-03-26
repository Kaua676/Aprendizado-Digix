using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_01_2025
{
    public class Transacao
    {
        public string IdTransacao { get; set; }
        public DateTime Data { get; set; }
        public TipoTransacao Tipo { get; set; }
        public double Valor { get; set; }
        public double SaldoPosterior { get; set; }

        public override string ToString()
        {
            return $"\nID: {IdTransacao}\nData: {Data}\nTipo: {Tipo}\nValor: {Valor}\nSaldo Posterior: {SaldoPosterior}";
        }
    }
}