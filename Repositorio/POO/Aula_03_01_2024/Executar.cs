using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_03_01_2024
{
    public class Executar
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();
            List<Venda> vendas = new List<Venda>();
            Estoque estoque = new Estoque();

            int opcao;

            do
            {
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Produto");
                Console.WriteLine("3 - Cadastrar Venda");
                Console.WriteLine("4 - Consultar Estoque");
                Console.WriteLine("5 - Gerar Relatório de Vendas");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarCliente(clientes);
                        break;
                    case 2:
                        CadastrarProduto(produtos, estoque);
                        break;
                    case 3:
                        CadastrarVenda(vendas, clientes, produtos, estoque);
                        break;
                    case 4:
                        ConsultarEstoque(estoque);
                        break;
                    case 5:
                        GerarRelatorioVendas(vendas);
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }
            } while (opcao != 0);
        }

        static void CadastrarCliente(List<Cliente> clientes)
        {
            // Código para cadastrar clientes
            System.Console.WriteLine("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();
            System.Console.WriteLine("Digite o telefone do cliente: ");
            string telefone = Console.ReadLine();
            System.Console.WriteLine("Digite o endereço do cliente: (Rua, Cidade, Estado, CEP) ");
            string endereco = Console.ReadLine();

            System.Console.WriteLine("Digite seu estado (sigla, ex: SP, MS ...): ");
            string estado = Console.ReadLine();
            if (!Enum.TryParse(estado, out Estado estadoEnum))
            {
                System.Console.WriteLine("Estado inválido.");
                return;
            }

            Cliente cliente = new ClienteGold
            {
                Nome = nome,
                CPF = cpf,
                Telefone = telefone,
                Endereco = new Endereco()
                {
                    Rua = endereco.Split(",")[0],
                    Cidade = endereco.Split(",")[1],
                    Estado = estadoEnum,
                    CEP = endereco.Split(",")[2]
                }
            };
            System.Console.WriteLine("Cliente cadastrado com sucesso!");
        }

        private static void CadastrarProduto(List<Produto> produtos, Estoque estoque)
        {

            System.Console.WriteLine("===== Cadastro de Produto =====");
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o preço de custo: ");
            double precoCusto = double.Parse(Console.ReadLine());

            // System.Console.WriteLine("Digite o Apelido: ");
            // string apelido = Console.ReadLine();

            System.Console.WriteLine("Digite se o produto é perecivel ou nao: ");
            bool perecivel = bool.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a data de validade: ");
            DateTime dataValidade = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o preço final: ");
            double precoFinal = double.Parse(Console.ReadLine());

            // Cadastro do fornecedor
            System.Console.WriteLine("===== Cadastro de Fornecedor =====");
            System.Console.WriteLine("Digite o nome do fornecedor: ");
            string nomeFornecedor = Console.ReadLine();

            System.Console.WriteLine("Digite o endereço do fornecedor: (Rua, Cidade, Estado, CEP) ");
            string endereco = Console.ReadLine();

            System.Console.WriteLine("Digite o CNPJ do fornecedor: ");
            int cnpj = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite se o fornecedor é recorrente ou nao: ");
            bool recorrente = bool.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o desconto: ");
            double desconto = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite seu estado (sigla, ex: SP, MS ...): ");
            string estado = Console.ReadLine();

            if (!Enum.TryParse(estado, out Estado estadoEnum))
            {
                System.Console.WriteLine("Estado inválido.");
                return;
            }

            string apelido = ApelidosPorEstado[estadoEnum];

            Fornecedor fornecedor = new Fornecedor
            {
                Nome = nomeFornecedor,
                Endereco = new Endereco
                {
                    Rua = endereco.Split(",")[0],
                    Cidade = endereco.Split(",")[1],
                    Estado = estadoEnum,
                    CEP = endereco.Split(",")[2]
                },
                CNPJ = cnpj,
                Recorrente = recorrente,
                Desconto = desconto
            };

            Produto produto = new Produto
            {
                Nome = nome,
                Codigo = codigo,
                PrecoCusto = precoCusto,
                Apelido = apelido,
                Perecivel = perecivel,
                DataValidade = dataValidade,
                PrecoFinal = precoFinal,
                Fornecedor = fornecedor
            };

            produtos.Add(produto);
            estoque.Produtos = produtos.ToArray();
            System.Console.WriteLine("Produto cadastrado com sucesso!");
        }

        private static void CadastrarVenda(List<Venda> vendas, List<Cliente> clientes, List<Produto> produtos, Estoque estoque)
        {

            System.Console.WriteLine("===== Cadastro de Venda =====");
            System.Console.WriteLine("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();
            Cliente cliente = clientes.Find(c => c.CPF == cpf); //Find é um metodo que procura o elemento dentro de uma lista
            if (cliente == null)
            {
                System.Console.WriteLine("Cliente nao encontrado!");
                return;
            }

            List<Produto> produtosVenda = new List<Produto>();
            while (true)
            {
                System.Console.WriteLine("Digite o código do produto (0 para finalizar): ");
                int codigo = int.Parse(Console.ReadLine());
                if (codigo == 0) break;

                Produto produto = produtos.Find(p => p.Codigo == codigo);
                if (produto != null)
                {
                    produtosVenda.Add(produto);
                }
                else
                {
                    System.Console.WriteLine("Produto nao encontrado!");
                }
            }

            Venda venda = new Venda
            {
                Produtos = produtosVenda.ToArray(),
                Data = DateTime.Now,
                Cliente = cliente,
                FormaPagamento = "Picsi",
                Parcelas = 1
            };

            venda.ValorTotal = venda.CalcularValorFinal(); // Aqui eu estou utilizando o metodo CalcularValorFinal da classe Venda

            vendas.Add(venda);
            System.Console.WriteLine("Venda cadastrada com sucesso!");
        }

        private static void ConsultarEstoque(Estoque estoque)
        {

            System.Console.WriteLine("===== Consulta de Estoque =====");
            if (estoque.Produtos != null)
            {
                for (int i = 0; i < estoque.Produtos.Length; i++)
                {
                    System.Console.WriteLine("Produto: " + estoque.Produtos[i].Nome);
                    System.Console.WriteLine("Quantidade: " + estoque.Quantidades[i]);
                    System.Console.WriteLine("Preço de Custo: " + estoque.Produtos[i].PrecoCusto);
                    System.Console.WriteLine("Preço Final: " + estoque.Produtos[i].PrecoFinal);
                    System.Console.WriteLine("Fornecedor: " + estoque.Produtos[i].Fornecedor.Nome);
                }
            }
            else
            {
                System.Console.WriteLine("Estoque vazio!");
            }
        }

        private static void GerarRelatorioVendas(List<Venda> vendas)
        {

            System.Console.WriteLine("===== Relatório de Vendas =====");
            if (vendas != null)
            {
                foreach (var venda in vendas)
                {
                    System.Console.WriteLine("Data: " + venda.Data);
                    System.Console.WriteLine("Cliente: " + venda.Cliente.Nome);
                    System.Console.WriteLine("Forma de Pagamento: " + venda.FormaPagamento);
                    System.Console.WriteLine("Parcelas: " + venda.Parcelas);
                    System.Console.WriteLine("Valor Total: " + venda.ValorTotal);
                }
            }
            else
            {
                System.Console.WriteLine("Vendas vazias!");
            }
        }

        private static Dictionary<Estado, string> ApelidosPorEstado = new Dictionary<Estado, string>(){
            { Estado.SP, "Chevete" },
            { Estado.RS, "Guaravita" },
            { Estado.MS, "Tereré" },
            { Estado.SC, "é us guri" },
            { Estado.PR, "Parana" },
            { Estado.RJ, "Rio de Janeiro" },
            { Estado.RN, "Rio Grande do Norte" },
            { Estado.PI, "Piaui" },
            { Estado.PE, "Pernambuco" },
            { Estado.PB, "Paraiba" },
            { Estado.PA, "Para" },
            { Estado.MT, "Mato Grosso" },
            { Estado.MG, "Minas Gerais" },
            { Estado.MS, "Mato Grosso do Sul" },
            { Estado.MA, "Maranhao" },
            { Estado.GO, "Goias" },
        };
    }
}

