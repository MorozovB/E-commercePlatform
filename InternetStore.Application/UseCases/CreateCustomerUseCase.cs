using InternetStore.Application.DTOs;
using InternetStore.Application.Interfaces;
using InternetStore.Domain.Entities;
using InternetStore.Domain.Interfaces;
using InternetStore.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace InternetStore.Application.UseCases
{
    public class CreateCustomerUseCase : ICreateCustomerUseCase
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IValidator<CustomerDto> _validator;

        public CreateCustomerUseCase(
            ICustomerRepository customerRepository,
            IValidator<CustomerDto> validator)
        {
            _customerRepository = customerRepository;
            _validator = validator;
        }

        public async Task<Guid> ExecuteAsync(CustomerDto customerDto)
        {
            // Validate the incoming DTO
            var validationResult = await _validator.ValidateAsync(customerDto);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            // Map DTO fields to domain value objects
            var fullName = FullName.Create(customerDto.FullName!);
            var email = Email.Create(customerDto.Email!);

            // Assume a concrete Customer type, e.g., IndividualCustomer
            var customer = new IndividualCustomer(fullName, email)
            {
                PhoneNumber = customerDto.PhoneNumber,
                // You can map Address into a Value Object if required
            };

            await _customerRepository.AddAsync(customer);
            return customer.Id;
        }
    }

    }
}
