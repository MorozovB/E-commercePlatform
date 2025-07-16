using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetStore.Domain.Entities;

namespace InternetStore.Domain.Interfaces
{
    public interface IProductRepository
    {
        /// <summary>
        /// Retrieves a product by its unique identifier.
        /// </summary>
        /// <param name="productId">The unique identifier of the product.</param>
        /// <returns>The product if found; otherwise, null.</returns>
        Task<Product?> GetProductByIdAsync(Guid productId);

        /// <summary>
        /// Retrieves all products in the repository.
        /// </summary>
        /// <returns>A list of all products.</returns>
        Task<List<Product>> GetAllProductsAsync();

        /// <summary>
        /// Retrieves all products from a specific category.
        /// </summary>
        /// <param name="categoryId">The unique identifier of the product.</param>
        /// <returns>All products from a specific category</returns>
        Task<List<Product>> FindByCategoryIdAsync(Guid categoryId);

        /// <summary>
        /// Adds a new product.
        /// </summary>
        /// <param name="product">The product to add.</param>
        Task AddProductAsync(Product product);

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="product">The product with updated information.</param>
        Task UpdateProductAsync(Product product);

        /// <summary>
        /// Deletes a product.
        /// </summary>
        /// <param name="productId">The unique identifier of the product to delete.</param>
        Task DeleteProductAsync(Guid productId);
    }
}
