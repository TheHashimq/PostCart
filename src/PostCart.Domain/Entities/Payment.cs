namespace PostCart.Domain.Entities
{
    public class Payment
    {
        public Guid Id { get; init; }
        public Money Amount { get; set; }
        public PaymentStatus Status { get; set; }
        public Guid OrderId { get; set; }
        public DateTime CreatedAt { get; init; }

        private Payment(Money amount, Guid orderId)
        {
            Id = Guid.NewGuid();
            Amount = amount;
            OrderId = orderId;
            CreatedAt = DateTime.UtcNow;
            Status = PaymentStatus.Pending;
        }
        public static Payment Create(Money amount, Guid orderId)
        {
            if (amount == null)
                throw new ArgumentNullException(nameof(amount), "Amount cannot be null.");
            if (amount.Value <= 0)
                throw new ArgumentException("Amount must be greater than zero");
            if (orderId == Guid.Empty)
                throw new ArgumentException("OrderId cannot be empty");

            return new Payment(amount, orderId);
        }
        public override string ToString()
        {
            return $"Payment: {Id}, Amount: {Amount.Value}, Status: {Status}, OrderId: {OrderId}, CreatedAt: {CreatedAt}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Payment otherPayment)
            {
                return Id == otherPayment.Id;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }


    }
}