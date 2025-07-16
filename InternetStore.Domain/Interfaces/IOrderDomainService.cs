using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetStore.Domain.Entities;

namespace InternetStore.Domain.Interfaces
{
    public interface IOrderDomainService
    {
        /// <summary>
        /// Check whether the order can be placed.
        /// </summary>
        /// <param name="order">Order verification</param>
        /// <returns>Returns true if the order is valid for processing; false if the conditions are violated.</returns>
        Task<bool> CanPlaceOrderAsync(Order order);

        /// <summary>
        /// Validate the order before placing it.
        /// </summary>
        /// <param name="order">Order verification</param>
        /// <returns> Generates exceptions if the order is invalid</returns>
        Task ValidateOrderAsync(Order order);

        /// <summary>
        ///  Calculate the total cost of the order
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Total rprice</returns>
        Task<decimal> CalculateTotalAsync(Order order);

        /// <summary>
        /// method of adding a product to an order with checks
        /// </summary>
        /// <param name="order">Order</param>
        /// <param name="product">Product</param>
        /// <param name="quantity">Quantity of products</param>
        void AddItemToOrder(Order order, Product product, int quantity);

        /// <summary>
        /// Retrieves all orders.
        /// </summary>
        /// <returns>A list of all orders.</returns>
        Task<List<Order>> GetAllOrdersAsync();

        /// <summary>
        /// Updates an existing order.
        /// </summary>
        /// <param name="order">The order to update.</param>
        Task UpdateOrderAsync(Order order);

        /// <summary>
        /// Deletes an order by its unique identifier.
        /// </summary>
        /// <param name="orderId">The unique identifier of the order to delete.</param>
        Task DeleteOrderAsync(Guid orderId);
    }
}
