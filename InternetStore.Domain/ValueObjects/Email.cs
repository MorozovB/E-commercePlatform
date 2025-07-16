using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Domain.ValueObjects
{
    public class Email
    {
        public Email(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException("Email address cannot be null or empty.", nameof(address));
            }
            // Basic email validation
            if (!address.Contains('@') || !address.Contains('.'))
            {
                throw new ArgumentException("Invalid email address format.", nameof(address));
            }
            this.Address = address;
        }

        public string Address { get; }

        public override string ToString()
        {
            return Address;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Email otherEmail)
            {
                return Address.Equals(otherEmail.Address, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Address.ToLowerInvariant().GetHashCode();
        }
    }
}
