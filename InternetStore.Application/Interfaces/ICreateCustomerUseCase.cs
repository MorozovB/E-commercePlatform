using InternetStore.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InternetStore.Application.Interfaces
{
    internal interface ICreateCustomerUseCase
    {
        /// <summary>
        /// Creates a new customer based on the provided DTO.
        /// </summary>
        /// <param name="customerDto">Data for the new customer.</param>
        /// <returns>The identifier of the created customer.</returns>
        Task<Guid> ExecuteAsync(CustomerDto customerDto);
    }
}
