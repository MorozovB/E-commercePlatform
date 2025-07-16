using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Domain.ValueObjects
{
    public class Address
    {
        public Address(string country, string city, string street, string postalCode, string houseNumber)
        {
            if (string.IsNullOrWhiteSpace(country))
            {
                throw new ArgumentException("Country cannot be null or empty.", nameof(country));
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentException("City cannot be null or empty.", nameof(city));
            }
            if (string.IsNullOrWhiteSpace(street))
            {
                throw new ArgumentException("Street cannot be null or empty.", nameof(street));
            }
            if (string.IsNullOrWhiteSpace(postalCode))
            {
                throw new ArgumentException("Postal code cannot be null or empty.", nameof(postalCode));
            }
            if (string.IsNullOrWhiteSpace(houseNumber))
            {
                throw new ArgumentException("House number cannot be null or empty.", nameof(houseNumber));
            }
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.PostalCode = postalCode;
            this.HouseNumber = houseNumber;
        }

        public string Country { get; }

        public string City { get; }

        public string Street { get; }

        public string PostalCode { get; }

        public string HouseNumber { get; }

        public override string ToString()
        {
            return $"{Street} {HouseNumber}, {PostalCode} {City}, {Country}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Address otherAddress)
            {
                return Country.Equals(otherAddress.Country, StringComparison.OrdinalIgnoreCase) &&
                       City.Equals(otherAddress.City, StringComparison.OrdinalIgnoreCase) &&
                       Street.Equals(otherAddress.Street, StringComparison.OrdinalIgnoreCase) &&
                       PostalCode.Equals(otherAddress.PostalCode, StringComparison.OrdinalIgnoreCase) &&
                       HouseNumber.Equals(otherAddress.HouseNumber, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Country.ToLowerInvariant(), City.ToLowerInvariant(), Street.ToLowerInvariant(), PostalCode.ToLowerInvariant(), HouseNumber.ToLowerInvariant());
        }
    }

}
