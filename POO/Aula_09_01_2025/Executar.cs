using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_09_01_2025
{
    public class Executar
    {

        class Program
        {
            static void Main(string[] args)
            {
                Banco banco = new Banco("Banco do Kauã", "001", "Av. Principal, 123");
                bool executando = true;

                while (executando)
                {
                    System.Console.WriteLine("===========================");
                    System.Console.WriteLine("=      Banco do Kauã      =");
                    System.Console.WriteLine("===========================");
                    Console.WriteLine("1. Criar Conta");
                    Console.WriteLine("2. Login e Acessar Conta");
                    Console.WriteLine("3. Listar Clientes e Contas");
                    Console.WriteLine("4. Sair");
                    Console.Write("Escolha uma opção: ");
                    string opcao = Console.ReadLine();

                    try
                    {
                        switch (opcao)
                        {
                            case "1":
                                CriarConta(banco);
                                break;
                            case "2":
                                LoginEOperacoes(banco);
                                break;
                            case "3":
                                ListarClientesEContas(banco);
                                break;
                            case "4":
                                executando = false;
                                Console.WriteLine("Encerrando o sistema...");
                                break;
                            default:
                                Console.WriteLine("Opção inválida. Tente novamente.");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                }
            }

            static void CriarConta(Banco banco)
            {
                System.Console.WriteLine("===========================");
                System.Console.WriteLine("=       Criar Conta       =");
                System.Console.WriteLine("===========================");
                Console.Write("Nome do Cliente: ");
                string nome = Console.ReadLine();
                Console.Write("Endereço do Cliente: ");
                string endereco = Console.ReadLine();
                Console.Write("Data de Nascimento (dd-MM-yyyy): ");
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
                Console.Write("Número do Cartão: ");
                string numeroCartao = Console.ReadLine();
                Console.Write("Senha: ");
                string senha = Console.ReadLine();

                Cliente cliente = new Cliente(nome, endereco, dataNascimento, numeroCartao, senha);
                banco.AdicionarCliente(cliente);

                Console.Write("Tipo de Conta (1-Corrente, 2-Poupança): ");
                string tipoConta = Console.ReadLine();

                Conta conta;
                if (tipoConta == "1")
                {
                    conta = new ContaCorrente(banco.ObterTodasContas().Count + 1, 0, cliente);
                }
                else if (tipoConta == "2")
                {
                    conta = new ContaPoupanca(banco.ObterTodasContas().Count +f 1, 0, cliente);
                }
                else
                {
                    throw new ArgumentException("Tipo de conta inválido.");
                }

                banco.AdicionarConta(conta);
                cliente.AdicionarConta(conta);

                Console.WriteLine($"Conta criada com sucesso! Número da Conta: {conta.NumeroConta}");
                Console.WriteLine("Por favor, faça login para acessar sua conta.");
            }

            static void LoginEOperacoes(Banco banco)
            {
                System.Console.WriteLine("===========================");
                System.Console.WriteLine("=          Login          =");
                System.Console.WriteLine("===========================");
                Console.Write("Número do Cartão: ");
                string numeroCartao = Console.ReadLine();
                Console.Write("Senha: ");
                string senha = Console.ReadLine();

                Cliente cliente = banco.BuscarClientePorCartao(numeroCartao);

                if (cliente.VerificarSenha(senha))
                {
                    Console.WriteLine($"Bem-vindo, {cliente.Nome}!");
                    MenuConta(banco, cliente);
                }
                else
                {
                    throw new UnauthorizedAccessException("Senha incorreta.");
                }
            }

            static void MenuConta(Banco banco, Cliente cliente)
            {
                bool acessando = true;

                while (acessando)
                {
                    System.Console.WriteLine("===========================");
                    System.Console.WriteLine("=        Menu Conta       =");
                    System.Console.WriteLine("===========================");
                    Console.WriteLine("1. Depositar");
                    Console.WriteLine("2. Sacar");
                    Console.WriteLine("3. Exibir Saldo");
                    Console.WriteLine("4. Histórico de Transações");
                    Console.WriteLine("5. Voltar ao Menu Principal");
                    Console.Write("Escolha uma opção: ");
                    string opcao = Console.ReadLine();

                    try
                    {
                        switch (opcao)
                        {
                            case "1":
                                RealizarDeposito(cliente);
                                break;
                            case "2":
                                RealizarSaque(cliente);
                                break;
                            case "3":
                                ExibirSaldo(cliente);
                                break;
                            case "4":
                                ExibirHistorico(cliente);
                                break;
                            case "5":
                                acessando = false;
                                break;
                            default:
                                Console.WriteLine("Opção inválida. Tente novamente.");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                }
            }

            static void RealizarDeposito(Cliente cliente)
            {
                System.Console.WriteLine("===========================");
                System.Console.WriteLine("=    Realizar Depósito    =");
                System.Console.WriteLine("===========================");
                Console.Write("Número da Conta: ");
                int numeroConta = int.Parse(Console.ReadLine());
                Console.Write("Valor do Depósito: ");
                double valor = double.Parse(Console.ReadLine());

                Conta conta = cliente.Contas.Find(c => c.NumeroConta == numeroConta)
                            ?? throw new KeyNotFoundException("Conta não encontrada.");
                conta.Depositar(valor);

                Console.WriteLine("Depósito realizado com sucesso!");
            }

            static void RealizarSaque(Cliente cliente)
            {
                System.Console.WriteLine("===========================");
                System.Console.WriteLine("=      Realizar Saque     =");
                System.Console.WriteLine("===========================");
                Console.Write("Número da Conta: ");
                int numeroConta = int.Parse(Console.ReadLine());
                Console.Write("Valor do Saque: ");
                double valor = double.Parse(Console.ReadLine());

                Conta conta = cliente.Contas.Find(c => c.NumeroConta == numeroConta)
                            ?? throw new KeyNotFoundException("Conta não encontrada.");
                conta.Sacar(valor);

                Console.WriteLine("Saque realizado com sucesso!");
            }

            static void ExibirSaldo(Cliente cliente)
            {
                System.Console.WriteLine("===========================");
                System.Console.WriteLine("=       Exibir Saldo      =");
                System.Console.WriteLine("===========================");
                Console.Write("Número da Conta: ");
                int numeroConta = int.Parse(Console.ReadLine());

                Conta conta = cliente.Contas.Find(c => c.NumeroConta == numeroConta)
                            ?? throw new KeyNotFoundException("Conta não encontrada.");
                Console.WriteLine($"Saldo Atual: {conta.Saldo:C}");
            }

            static void ExibirHistorico(Cliente cliente)
            {
                System.Console.WriteLine("===========================");
                System.Console.WriteLine("= Histórico de Transações =");
                System.Console.WriteLine("===========================");
                Console.Write("Número da Conta: ");
                int numeroConta = int.Parse(Console.ReadLine());

                Conta conta = cliente.Contas.Find(c => c.NumeroConta == numeroConta)
                            ?? throw new KeyNotFoundException("Conta não encontrada.");
                var historico = conta.ObterHistoricoTransacoes();

                if (historico.Count == 0)
                {
                    Console.WriteLine("Nenhuma transação encontrada.");
                }
                else
                {
                    foreach (var transacao in historico)
                    {
                        Console.WriteLine(transacao);
                    }
                    // Cria um txt com o histórico de transações
                    string caminhoArquivo = @"C:\Users\kauavicente\Desktop\aa.txt";
                    using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                    {
                        foreach (var transacao in historico)
                        {
                            writer.WriteLine(transacao.ToString());
                        }
                        Console.WriteLine($"Histórico de transações salvo em: {caminhoArquivo}");
                    }
                }
            }

            static void ListarClientesEContas(Banco banco)
            {
                Console.WriteLine("\n=== Lista de Clientes e Contas ===");

                if (banco.Clientes.Count == 0)
                {
                    Console.WriteLine("Nenhum cliente cadastrado.");
                }
                else
                {
                    foreach (var cliente in banco.Clientes)
                    {
                        Console.WriteLine($"Nome: {cliente.Nome}");
                        Console.WriteLine($"Endereço: {cliente.Endereco}");
                        Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");
                        Console.WriteLine($"Cartão: {cliente.NumeroCartao}");
                        Console.WriteLine("Contas:");
                        foreach (var conta in cliente.Contas)
                        {
                            Console.WriteLine($"Número da Conta: {conta.NumeroConta}");
                            Console.WriteLine($"Saldo: {conta.Saldo:C}");
                            Console.WriteLine($"Tipo de Conta: {conta.GetType().Name}");
                        }
                    }
                }
            }
        }
    }
}


