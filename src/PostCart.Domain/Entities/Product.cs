namespace PostCart.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public Money Price { get; set; }
        public int Stock { get; set; }
        public Guid SellerId { get; set; }
        public bool IsActive { get; set; }
        public string imageUrl { get; set; }

        private Product(string name, string description, Money price, int stock, Guid sellerId , string imageUrl = "https://via.placeholder.com/150")
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            SellerId = sellerId;
            IsActive = true;
            imageUrl = imageUrl; // Use the provided image URL or the default
        }
        public static Product Create(string name, string description, Money price, int stock, Guid sellerId, string imageUrl = "https://via.placeholder.com/150")
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Product name required");
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Product description required");
            if (price == null || price.Value <= 0)
                throw new ArgumentException("Product price must be greater than zero");
            if (stock < 0)
                throw new ArgumentException("Product stock cannot be negative");
            if (string.IsNullOrWhiteSpace(imageUrl))
                throw new ArgumentException("Product image URL required");
            return new Product(name, description, price, stock, sellerId, imageUrl );
        }
        public override string ToString()
        {
            return $"Product: {Name}, Description: {Description}, Price: {Price.Value}, Stock: {Stock}, SellerId: {SellerId}, IsActive: {IsActive}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Product otherProduct)
            {
                return Id == otherProduct.Id;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
       
    }
}