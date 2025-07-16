using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetStore.Domain.Entities;

namespace InternetStore.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// Retrieves a category by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the category.</param>
        /// <returns>The category with the specified identifier, or null if not found.</returns>
        Task<Category> GetCategoryByIdAsync(Guid id);

        /// <summary>
        /// Retrieves all categories.
        /// </summary>
        /// <returns>A list of all categories.</returns>
        Task<List<Category>> GetAllCategoriesAsync();

        /// <summary>
        /// Adds a new category to the repository.
        /// </summary>
        /// <param name="category">The category to add.</param>
        Task AddCategoryAsync(Category category);

        /// <summary>
        /// Updates an existing category in the repository.
        /// </summary>
        /// <param name="category">The category to update.</param>
        Task UpdateCategoryAsync(Category category);

        /// <summary>
        /// Deletes a category from the repository.
        /// </summary>
        /// <param name="id">The unique identifier of the category to delete.</param>
        Task DeleteCategoryAsync(Guid id);
    }
}
