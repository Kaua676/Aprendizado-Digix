├── Enumeração para Transações:
│       └── Enumeração (TipoTransacao): Um enumerador foi adicionado para representar tipos de transações (Saque, Depósito, Transferência), tornando o sistema mais robusto e evitando erros manuais ao lidar com tipos de transações.
│
├── Mais Métodos:
│       ├── Métodos para adicionar clientes e contas em Banco.
│       └── Métodos para processar transações e buscar contas ou clientes foram incluídos.
│
├── Relacionamentos Claros:
│       ├── Cliente agora possui um relacionamento de composição com Conta, destacando que o cliente é proprietário das contas.
│       └── CaixaEletronico está diretamente associado ao Banco, com um método claro para processar transações.
│
├── Histórico de Transações:
│       └── A classe Conta agora possui uma lista de transações e métodos para adicionar e obter o histórico.
│
├── Implementação de Herança e Abstração:
│       ├── A herança entre Conta, ContaCorrente e ContaPoupança é mantida, mas com uma abordagem mais estruturada.
│       └── A classe abstrata Conta define métodos e propriedades genéricas, como Depositar, Sacar e Historico de Transacoes.
│
├── Validações e Regras de Negócio:
│       └── Regras de negócio, como saldo não negativo e depósitos com valor positivo, estão implementadas na lógica.
│
├── Organização:
│       └── O diagrama reorganizado é mais limpo, com melhor separação das responsabilidades e métodos essenciais claramente definidos.
│
├── Regras de Negócio:
│       ├── As validações para saques (saldo não pode ser negativo) e depósitos (valor deve ser maior que zero) estão implementadas.
│       └── Cada transação tem ID único, data, tipo, valor e saldo final.
│
├── Funcionalidades Adicionais:
│       ├── Login de cliente está implementado com validação de senha.
│       ├── Histórico de transações está disponível na classe Conta.
│       └── O banco pode adicionar contas, listar todas e buscar por número de conta ou cartão.
│
├── Uso de Exceções:
│       └── Exceções personalizadas foram implementadas para regras de negócio (ex.: saldo insuficiente e valores inválidos).
