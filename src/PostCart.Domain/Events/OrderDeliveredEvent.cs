namespace PostCart.Domain.Events
{
    public class OrderDeliveredEvent : DomainEvent
    {
        public Guid OrderId { get; }

        public OrderDeliveredEvent(Guid orderId)
        {
            OrderId = orderId;
        }
    }
    
}