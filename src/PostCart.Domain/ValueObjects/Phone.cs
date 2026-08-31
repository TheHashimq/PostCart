using System.Text.RegularExpressions;
namespace PostCart.Domain
{
    public class Phone
    {
        public string Value{ get; private set; }
        private Phone(string phone)
        {
            
                Value = phone;
            
        }
        private static bool IsValidFormat(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;
            return Regex.IsMatch(phone, @"^\+?[1-9]\d{1,14}$");
        }
        public static Phone Create(string phone)
        {
            if (!IsValidFormat(phone))
                throw new ArgumentException("Invalid phone format.", nameof(phone));

            return new Phone(phone);
        }
        public override bool Equals(object obj)
        {
            if (obj is not Phone other)
                return false;

            return Value.Equals(other.Value, StringComparison.OrdinalIgnoreCase);
        }
        public override int GetHashCode()
        {
            return Value.ToLower().GetHashCode();
        }
    }
}