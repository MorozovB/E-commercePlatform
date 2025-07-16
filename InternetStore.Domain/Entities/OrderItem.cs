using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Domain.Entities
{
    public class OrderItem
    {
        public OrderItem(Guid itemId, string itemName, decimal price, int quantity, Guid orderId)
        {
            if (itemId == Guid.Empty)
            {
                throw new ArgumentException("Item ID cannot be empty.", nameof(itemId));
            }

            ArgumentException.ThrowIfNullOrEmpty(nameof(itemName));
            if (quantity > 0 && price > 0)
            {
                this.Id = Guid.NewGuid();
                this.ItemId = itemId;
                this.ItemName = itemName;
                this.ItemPrice = price;
                this.Quantity = quantity;
                this.OrderId = orderId;
            }
        }

        public Guid Id { get; private set; }

        public Guid ItemId { get; private set; }

        public string? ItemName { get; private set; }

        public decimal ItemPrice { get; set; }

        public int Quantity { get; private set; }

        public decimal TotalPrice
        {
            get
            {
                if (this.Quantity <= 0 || this.ItemPrice <= 0)
                {
                    throw new InvalidOperationException("Quantity and Price must be greater than zero to calculate total price.");
                }
                return this.ItemPrice * this.Quantity;
            }
        }

        public Guid OrderId { get; private set; }

        public Order? Order { get; set; }

        public void ChangeQuantity(int newQuantity)
        {
            if (newQuantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.", nameof(newQuantity));
            }
            this.Quantity = newQuantity;
        }
    }
}
