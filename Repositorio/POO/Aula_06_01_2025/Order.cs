using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_06_01_2025
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }
        public double Total()
        {
            foreach (OrderItem item in OrderItems)
            {
                return item.SubTotal();
            }
            return 0;
        }
    }
}