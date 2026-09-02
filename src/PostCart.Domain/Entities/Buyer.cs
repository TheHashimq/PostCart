namespace PostCart.Domain
{
    public class Buyer : Person
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public Email Email { get; set; }
        public Phone Phone { get; set; }
        public DateTime CreatedAt { get; init; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        private Buyer(string name, Email email, Phone phone, string username, string password, string address)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Phone = phone;
            CreatedAt = DateTime.UtcNow;
            Username = username;
            Password = password;
            Address = address;
        }

        public static Buyer Create(string name, Email email, Phone phone, string username, string password, string address)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username required");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password required");
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name required");
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Address required");
            return new Buyer(name, email, phone, username, password, address);
        }

        public override string ToString()
        {
            return $"Buyer: {Name}, Email: {Email}, Phone: {Phone}, Username: {Username}, Address: {Address}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Buyer otherBuyer)
            {
                return Id == otherBuyer.Id;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}