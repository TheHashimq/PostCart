namespace PostCart.Domain.Events
{
    public abstract class DomainEvent
    {
        public DateTime OccurredAt { get; } = DateTime.UtcNow;
    }
}