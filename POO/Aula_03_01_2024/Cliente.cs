using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Aula_03_01_2024
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        // Para ocorrer composição o Endereco deve ser instanciado no construtor
        public Cliente()
        {
            Endereco = new Endereco();
        }

        public Cliente(string nome, string rua, string cidade, Estado estado, string cep, string telefone, string cpf)
        {
            Nome = nome;
            Endereco = new Endereco(rua, cidade, estado, cep);
            Telefone = telefone;
            CPF = cpf;
        }
        public abstract string ConsultarFidelidade();
    }

    public class ClienteGold : Cliente
    {
        public double Desconto { get; set; }
        public override string ConsultarFidelidade()
        {
            return "Cliente Gold";
        }
    }

    public class ClientePlatinum : Cliente
    {
        public double Desconto { get; set; }
        public override string ConsultarFidelidade()
        {
            return "Cliente Platinum";
        }
    }
}
