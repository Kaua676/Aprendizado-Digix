// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Padaria
// {
//     public class Padaria
//     {
//         public string nomeAlimento;
//         public double Preco;
//         public string Bebidas;
//         public string Doces;
//         public DateTime dataValidade;


//         public string Encomenda()
//         {
//             return $"Encomenda de {nomeAlimento} : {Preco}, {Bebidas} : {Preco}, {Doces} : {Preco}";
//         }

//         // public double cestaCompras(string nomeAlimento, double Preco)
//         // {
//         //     return Preco;
//         // }

//         public double cestaCompras(List<(string nomeAlimento, double Preco)> produtos)
//         {
//             double total = 0;
//             foreach (var produto in produtos)
//             {
//                 System.Console.WriteLine($"Item: {produto.nomeAlimento}, Preço: {produto.Preco}");
//                 total += produto.Preco;
//             }

//             return total;
//         }
//     }
// }
