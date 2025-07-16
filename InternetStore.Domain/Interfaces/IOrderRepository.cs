using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetStore.Domain.Entities;

namespace InternetStore.Domain.Interfaces
{
    public interface IOrderRepository
    {
        /// <summary>
        /// Retrieves a order by its unique identifier.
        /// </summary>
        /// <param name="orderId">The unique identifier of the order.</param>
        /// <returns>The order if found; otherwise, null.</returns>
        Task<Order?> GetOrderByIdAsync(Guid orderId);

        /// <summary>
        /// Retrieves a order by custumer specific.
        /// </summary>
        /// <param name="customerId">The unique identifier of the order.</param>
        /// <returns>All products for a specific ccustomer.</returns>
        Task<List<Order>> GetOrdersByCustomerIdAsync(Guid customerId);

        /// <summary>
        /// Adds a new oreder.
        /// </summary>
        /// <param name="order">The order to add.</param>
        Task AddOrderAsync(Order order);

        /// <summary>
        /// Adds a new oreder.
        /// </summary>
        /// <param name="order">The order to update.</param>
        Task UpdateOrderAsync(Order order);

        /// <summary>
        /// Delete a new oreder.
        /// </summary>
        /// <param name="order">The order to delete.</param>
        Task DeleteOrderAsync(Guid orderId);

    }
}
