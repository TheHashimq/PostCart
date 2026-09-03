namespace PostCart.Domain.Events
            {
                public class OrderPlacedEvent : DomainEvent
    {
        public Guid OrderId { get; }

        public OrderPlacedEvent(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}