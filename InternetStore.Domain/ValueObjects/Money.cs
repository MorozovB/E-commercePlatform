using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.Domain.ValueObjects
{
    public class Money
    {
        public Money(decimal amount, string currency)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount cannot be negative.", nameof(amount));
            }
            if (string.IsNullOrWhiteSpace(currency) || currency.Length < 3)
            {
                throw new ArgumentException("Currency cannot be null or empty.", nameof(currency));
            }

            this.Amount = amount;
            this.Currency = currency.ToUpperInvariant();
        }

        public decimal Amount { get; }
        public string Currency { get; }

        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Money otherMoney)
            {
                return Amount == otherMoney.Amount && Currency.Equals(otherMoney.Currency, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Amount, Currency.ToUpperInvariant());
        }

    }
}
