using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_16_12_2024.Animal;

namespace Aula_16_12_2024
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // CartaoCredito cartao = new CartaoCredito("1234 5678 9511 5489", DateTime.Now, 100);
            // cartao.RealizarPagamento(500);
            // cartao.ExibirComprovante();

            // Pix pix = new Pix("054.486.161-27", "Kaua", "05448616127", 800, DateTime.Now);
            // pix.RealizarPagamento(300);
            // pix.ExibirComprovante();

            Cachorro cachorro = new Cachorro("Billy");
            cachorro.Brinca();
            cachorro.Come();

            Formiga formiga = new Formiga();
            formiga.Come();

            Peixe peixe = new Peixe("Douradão");
            peixe.Brinca();
            peixe.Come();
        }
    }
}