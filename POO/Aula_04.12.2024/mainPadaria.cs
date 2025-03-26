// using System;
// using Padaria;

// namespace Padaria
// {
//     public class Executar
//     {
//         static void Main(string[] args)
//         {
//             Padaria padaria = new Padaria();
//             padaria.nomeAlimento = "Pastel de carne";
//             padaria.Preco = 10.99;
//             padaria.Bebidas = "Suco de Laranja";
//             padaria.Preco = 5.99;
//             padaria.Doces = "Chocolate";
//             padaria.Preco = 4.99;
//             padaria.dataValidade = DateTime.Now.AddDays(3);

//             //Exibindo os detalhes da encomenda
//             System.Console.WriteLine(padaria.Encomenda());

//             //Criando uma lista de compras com nome e preço
//             List<(string nomeAlimento, double Preco)> listasCompras = new List<(string nomeAlimento, double Preco)>
//             {
//             ("Pao de Queijo", 5.99),
//             ("Bolo de Chocolate", 9.99),
//             ("Suco de Laranja", 3.99)
//             };

//             //Calculando o total da cesta de compras
//             double total = padaria.cestaCompras(listasCompras);
//             System.Console.WriteLine($"Total da cesta de compras: R${total}");
//         }
//     }
// }
