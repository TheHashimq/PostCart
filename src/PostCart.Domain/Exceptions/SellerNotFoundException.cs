namespace PostCart.Domain.Exceptions
{
    public class SellerNotFoundException : Exception
    {
        public SellerNotFoundException(string message) : base(message)
        {
        }
    }
}