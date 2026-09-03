namespace PostCart.Domain.Events
{
    public class SelllerCreatedEvent : DomainEvent
    {
        public Guid SellerId { get; }

        public SelllerCreatedEvent(Guid sellerId)
        {
            SellerId = sellerId;
        }
    }
}