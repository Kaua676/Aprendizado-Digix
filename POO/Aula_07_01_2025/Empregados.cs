using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_07_01_2025
{
    public class Empregados
    {
        private int iNumeroMaximo = 50;
        public Empregado[] empregados { get; set; }
        public int iNumeroEmpregados { get; set; }

        public Empregados()
        {
            empregados = new Empregado[iNumeroMaximo];
            iNumeroEmpregados = 0;
        }

        public void Insere(Empregado empregado)
        {
            if (iNumeroEmpregados < iNumeroMaximo)
            {
                empregados[iNumeroEmpregados++] = empregado;
            }
            else
            {
                Console.WriteLine("Limite de empregados atingido.");
            }
        }

        public void Imprime()
        {
            if (iNumeroEmpregados == 0)
            {
                Console.WriteLine("Nenhum empregado cadastrado.");
                return;
            }

            Console.WriteLine("Exibindo todos os empregados:");
            foreach (var empregado in empregados)
            {
                if (empregado != null)
                {
                    Console.WriteLine($"Nome: {empregado.GetName()}, Tipo: {empregado.Tipo}, Salário: {empregado.GetSalario()}, Status Licença: {empregado.StatusLicencaAtual}");
                }
            }
        }

        public void Write(string v)
        {
            Console.WriteLine($"Buscando empregado com o nome: {v}");
            foreach (var empregado in empregados)
            {
                if (empregado != null && empregado.GetName() == v)
                {
                    Console.WriteLine($"ACHOUUUUUUUUUUUU! Nome: {empregado.GetName()}, Tipo: {empregado.Tipo}, Salário: {empregado.GetSalario()}, Status Licença: {empregado.StatusLicencaAtual}");
                    return;
                }
            }
            Console.WriteLine("Empregado não encontrado.");
        }

        public void Read(string v)
        {
            Console.WriteLine($"Buscando empregados do tipo: {v}");
            foreach (var empregado in empregados)
            {
                if (empregado != null && empregado.GetName() == "Paulo")
                {
                    Console.WriteLine($"Nome: {empregado.GetName()}, Tipo: {empregado.Tipo}, Salário: {empregado.GetSalario()}, Status Licença: {empregado.StatusLicencaAtual}");
                }
            }
            Console.WriteLine("Empregado não encontrado.");
        }

        public double doFolhaPagamento()
        {
            double salarioTotal = 0.0;
            foreach (var empregado in empregados)
            {
                if (empregado != null)
                {
                    salarioTotal += empregado.GetSalario();
                }
            }
            return salarioTotal;
        }
    }
}