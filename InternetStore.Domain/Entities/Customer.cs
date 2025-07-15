using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Domain.Entities
{
    internal abstract class Customer
    {
        public Customer(FullName fullName, Email email)
        {
            if (fullName == null)
            {
                throw new ArgumentNullException(nameof(fullName), "Full name cannot be null.");
            }

            if (email == null)
            {
                throw new ArgumentNullException(nameof(email), "Email cannot be null.");
            }

            this.Id = Guid.NewGuid();
            this.FullName = fullName;
            this.Email = email;
        }

        public Guid Id { get; private set; }

        public Email Email { get; private set; }

        public string? PhoneNumber { get; private set; }

        public List<Order> Orders { get; private set; } = new List<Order>();

        public DateTime Registered { get; private set; } = DateTime.UtcNow;

        public DateTime LastLogin { get; private set; } = DateTime.UtcNow;

        public void UpdateName(FullName fullName)
        {
            if (fullName == null)
            {
                throw new ArgumentNullException(nameof(fullName), "Full name cannot be null.");
            }
            this.FullName = fullName;
        }

        public void UpdateEmail(Email email)
        {
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email), "Email cannot be null.");
            }
            this.Email = email;
        }
    }
}
