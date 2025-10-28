using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBanking.Domain.ValueObjects
{
    public record AccountNumber
    {
        public string Value { get; }

        public AccountNumber(string value) {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 10)
                throw new ArgumentException("Account number must be 10 digits");

            if (!value.All(char.IsDigit))
                throw new ArgumentException("Account number must only contain didgits");

            Value = value;
        }

        //no casting needed when you need to convert to string
        public static implicit operator string(AccountNumber number) => number.Value;

        //ensures validation happens when converting from string to number
        public static explicit operator AccountNumber(string value) => new(value);

        public override string ToString() => Value;
    }
}
