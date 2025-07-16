using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Domain.Interfaces
{
    public interface IStockService
    {
        /// <summary>
        /// Checks if the specified product is in stock.
        /// </summary>
        /// <param name="productId">The ID of the product to check.</param>
        /// <returns>True if the product is in stock, otherwise false.</returns>
        Task<bool> IsProductInStockAsynk(Guid productId);

        /// <summary>
        /// Reserves a specified quantity of a product.
        /// </summary>
        /// <param name="productId">The ID of the product to reserve.</param>
        /// <param name="quantity">The quantity to reserve.</param>
        Task ReserveProductAsync(Guid productId, int quantity);

        /// <summary>
        /// Releases a specified quantity of a reserved product.
        /// </summary>
        /// <param name="productId">The ID of the product to release.</param>
        /// <param name="quantity">The quantity to release.</param>
        Task ReleaseProductAsync(Guid productId, int quantity);

        /// <summary>
        /// Decreases the stock quantity for a specified product.
        /// </summary>
        /// <param name="productId">The product ID.</param>
        /// <param name="quantity">The number of units to subtract from the product's stock. Must be greater than zero.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task DecreaseStockAsync(Guid productId, int quantity);

        /// <summary>
        /// Curent stock level for a specified product.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns>Current stock level</returns>
        Task<int> GetStockLevelAsync(Guid productId);
    }
}
