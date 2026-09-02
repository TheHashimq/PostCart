namespace PostCart.Domain.ValueObjects
{
    public class Rating
    {
        public int Value { get; private set; }

        private Rating(int value)
        {
            
            Value = value;
        }

        public static Rating Create(int value)
        {
            if (value < 1 || value > 5)
                throw new ArgumentOutOfRangeException(nameof(value), "Rating must be between 1 and 5.");
            return new Rating(value);
        }
        public override bool Equals(object obj)
        {
            if (obj is not Rating other)
                return false;

            return Value.Equals(other.Value);
        }
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

    }
}