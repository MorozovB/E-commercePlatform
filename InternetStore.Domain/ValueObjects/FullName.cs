using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Domain.ValueObjects
{
    public class FullName
    {
        public FullName(string fName, string lName)
        {
            if (string.IsNullOrWhiteSpace(fName))
            {
                throw new ArgumentException("First name cannot be null or empty.", nameof(fName));
            }
            if (string.IsNullOrWhiteSpace(lName))
            {
                throw new ArgumentException("Last name cannot be null or empty.", nameof(lName));
            }
            this.FirstName = fName;
            this.LastName = lName;
        }

        public string FirstName { get; init; }
        public string LastName { get; init; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is FullName otherFullName)
            {
                return FirstName.Equals(otherFullName.FirstName, StringComparison.OrdinalIgnoreCase) &&
                       LastName.Equals(otherFullName.LastName, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName.ToLowerInvariant(), LastName.ToLowerInvariant());
        }
    }
}

