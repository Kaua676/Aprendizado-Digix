using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_01_2025
{
    public class Banco
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Endereco { get; set; }
        public List<Conta> Contas { get; set; } = new List<Conta>();
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();

        public Banco(string nome, string codigo, string endereco)
        {
            Nome = nome;
            Codigo = codigo;
            Endereco = endereco;
        }

        public void AdicionarConta(Conta conta)
        {
            Contas.Add(conta);
        }

        public void AdicionarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public List<Conta> ObterTodasContas()
        {
            return Contas;
        }

        public Conta BuscarContaPorNumero(int numeroConta)
        {
            return Contas.Find(conta => conta.NumeroConta == numeroConta)
                   ?? throw new KeyNotFoundException("Conta não encontrada.");
        }

        public Cliente BuscarClientePorCartao(string numeroCartao)
        {
            return Clientes.Find(cliente => cliente.NumeroCartao == numeroCartao)
                   ?? throw new KeyNotFoundException("Cliente não encontrado.");
        }
    }
}