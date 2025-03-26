using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_01_2025
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Client client = new Client("Matheus", "matheus@matheus.com", new DateTime(2001, 03, 12));
            Console.WriteLine(client.Name);
            Console.WriteLine(client.Email);
            Console.WriteLine(client.BirthDate.ToString("dd/MM/yyyy"));

            Product product = new Product("TV", 500.00);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);

            Order order = new Order(DateTime.Now, OrderStatus.PendingPayment);
            System.Console.WriteLine(order.Status);
            OrderItem item = new OrderItem(2, 10.00);
            order.AddItem(item);

            Console.WriteLine(order.Moment);
        }
    }
}