// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_06_12_2024
// {
//     public class Secretaria : Funcionario
//     {
//         // Atributos globais de Secretaria
//         public string Ramal;

//         // O base é utilizado para chamar o construtor da classe pai
//         public Secretaria(string nome, string cpf, double salario, string setor) : base (nome, cpf, salario)
//         {
//             Ramal = Ramal;
//         }


//         public override double getBonificacao() // Override é utilizado para sobrescrever a função da classe pai
//         {
//             return Salario * 0.05;
//         }

//         public override void Imprimir() // Override é utilizado para sobrescrever a função da classe pai
//         {
//             System.Console.WriteLine("Nome: " + Nome);
//             System.Console.WriteLine("CPF: " + CPF);
//             System.Console.WriteLine("Salario: " + Salario);
//             System.Console.WriteLine("Ramal: " + Ramal);
//             System.Console.WriteLine("Bonificação: " + getBonificacao());
//         }

//         public void atenderTelefone()
//         {
//             System.Console.WriteLine("Atendendo telefone . . .\n");
//         }
//     }
// }