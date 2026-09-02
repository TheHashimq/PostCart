namespace PostCart.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; init; }
        public Guid BuyerId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public OrderStatus Status { get; set; }
        public Guid SellerId { get; set; } // Added SellerId property
        public Money TotalPrice { get; set; } // Added TotalPrice property
        public DateTime CreatedAt { get; init; } 


        private Order(Guid buyerId, Guid productId, int quantity, Guid sellerId, Money totalPrice)
        {
            Id = Guid.NewGuid();
            BuyerId = buyerId;
            ProductId = productId;
            Quantity = quantity;
            SellerId = sellerId;
            TotalPrice = totalPrice;    
            CreatedAt = DateTime.UtcNow;
            Status = OrderStatus.Pending;   
        }

        public static Order Create(Guid buyerId, Guid productId, int quantity, Guid sellerId, Money totalPrice)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero");
            return new Order(buyerId, productId, quantity, sellerId, totalPrice);
        }

        public override string ToString()
        {
            return $"Order: {Id}, BuyerId: {BuyerId}, ProductId: {ProductId}, Quantity: {Quantity}, CreatedAt: {CreatedAt}, Status: {Status}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Order otherOrder)
            {
                return Id == otherOrder.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}