using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetStore.Domain.Entities;

namespace InternetStore.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        /// <summary>
        /// Retrieves a customer by its unique identifier.
        /// </summary>
        /// <param name="customerId">The unique identifier of the customer.</param>
        /// <returns>The customer if found; otherwise, null.</returns>
        Task<Customer?> GetCustomerByIdAsync(Guid customerId);

        /// <summary>
        /// Retrieves customers by email.
        /// </summary>
        /// <returns>The customer if found; otherwise, null</returns>
        Task<Customer?> GetCustomerByEmailAsync(string email);

        /// <summary>
        /// Retrieves all customers.
        /// </summary>
        /// <returns>List of all customers</returns>
        Task<List<Customer>> GetAllCustomersAsync();

        /// <summary>
        /// Check if a customer exists by its email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>True if email is uniqe</returns>
        Task<bool> ExistCustomerByEmailAsync(string email);

        /// <summary>
        /// Adds a new customer.
        /// </summary>
        /// <param name="customer">The customer to add.</param>
        Task AddCustomerAsync(Customer customer);

        /// <summary>
        /// Updates an existing customer.
        /// </summary>
        /// <param name="customer">The customer to update.</param>
        Task UpdateCustomerAsync(Customer customer);

        /// <summary>
        /// Deletes a customer by its unique identifier.
        /// </summary>
        /// <param name="customerId">The unique identifier of the customer to delete.</param>
        Task DeleteCustomerAsync(Guid customerId);
    }
}
