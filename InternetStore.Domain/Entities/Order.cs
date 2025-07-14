using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetStore.Domain.Enums;

namespace InternetStore.Domain.Entities
{
    public class Order
    {
        public Order(Guid customerId, List<OrderItem> items)
        {
            this.Id = Guid.NewGuid();
            this.CustomerId = customerId;
            this.Items = items ?? throw new ArgumentNullException(nameof(items), "Items cannot be null.");
            this.CreatedAt = DateTime.UtcNow;
            this.Status = OrderStatus.Draft;
        }
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderStatus Status { get; set; }

        public Guid CustomerId { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public decimal TotalAmount
        {
            get
            {
                return Items.Sum(item => item.ItemPrice * item.Quantity);
            }
        }

        public void AddItem(Product product, int quantity)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            }

            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.", nameof(quantity));
            }

            var orderItem = new OrderItem(this.Id, product.Title, product.Price, quantity);

            Items.Add(orderItem);
        }
    }
}
