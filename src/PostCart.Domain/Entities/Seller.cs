namespace PostCart.Domain.Entities
{
   public class Seller : Person
   {
      public Guid Id { get; init; }
      public string Name { get; set; }
      public Email Email { get; set; }
      public Phone Phone { get; set; }
      public DateTime CreatedAt { get; init; }
      public string Username { get; set; }
      public string Password { get; set; }
      public string ShopName { get; set; }
      public string ShopDescription { get; set; }
      public int AverageRating { get; set; }
      public bool IsVerified { get; set; }
      public ICollection<Product> Products { get; set; }
      public string Address { get; set; }

      private Seller(string name, Email email, Phone phone, string username, string password, string shopName, string shopDescription)
      {
         Id = Guid.NewGuid();
         Name = name;
         Email = email;
         Phone = phone;
         CreatedAt = DateTime.UtcNow;
         Username = username;
         Password = password;
         ShopName = shopName;
         ShopDescription = shopDescription;
         AverageRating = 0;
         IsVerified = false;
         Products = new List<Product>();
      }

      public static Seller Create(string name, Email email, Phone phone, string username, string password, string shopName, string shopDescription)
      {
         if (string.IsNullOrWhiteSpace(username))
            throw new ArgumentException("Username required");
         if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Password required");
         if (string.IsNullOrWhiteSpace(shopDescription))
            throw new ArgumentException("Shop description required");
         if (string.IsNullOrWhiteSpace(shopName))
            throw new ArgumentException("Shop name required");
         if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name required");
         if (shopName.Length < 3)
            throw new ArgumentException("Shop name must be at least 3 characters long");
         return new Seller(name, email, phone, username, password, shopName, shopDescription);
      }

      public override string ToString()
      {
         return $"Seller: {Name}, Email: {Email}, Phone: {Phone}, Username: {Username}, Shop Name: {ShopName}, Shop Description: {ShopDescription}, Average Rating: {AverageRating}, Verified: {IsVerified}";
      }
      public override bool Equals(object obj)
      {
         if (obj is Seller otherSeller)
         {
            return Id == otherSeller.Id;
         }
         return false;
      }
      public override int GetHashCode()
      {
         return Id.GetHashCode();
      }
   }
}
