namespace PostCart.Domain.Exceptions 
{
    public class BuyerNotFoundException : Exception
    {
        public BuyerNotFoundException(string message) : base(message)
        {
        }
    }
}