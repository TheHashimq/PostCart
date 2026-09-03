namespace PostCart.Domain.Events
{
    public class PaymentProcessedEvent : DomainEvent
    {
        public Guid PaymentId { get; }

        public PaymentProcessedEvent(Guid paymentId)
        {
            PaymentId = paymentId;
        }
    }
}