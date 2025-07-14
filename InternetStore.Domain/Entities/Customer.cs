using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Domain.Entities
{
    internal abstract class Customer
    {
        Guid Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string Email { get; set; }

        string PhoneNumber { get; set; }

        List<Order> Orders { get; set; } = new List<Order>();

        DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
