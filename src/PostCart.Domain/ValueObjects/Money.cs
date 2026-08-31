namespace PostCart.Domain
{
    public class Money
    {
        public decimal Value { get; private set; }

        private Money(decimal value)
        {
            
            Value = value;
        }

        public static Money Create(decimal value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Money value cannot be negative.");
            return new Money(value);
        }
        public override bool Equals(object obj)
        {
            if (obj is not Money other)
                return false;

            return Value.Equals(other.Value);
        }
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

    }
}
