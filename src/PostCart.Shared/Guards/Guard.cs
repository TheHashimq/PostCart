namespace PostCart.Shared.Guards
{
    public static class Guard
    {
        public static void AgainstNull<T>(T? value , string paramName) where T : class
        {
            if(value is null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static void AgainstNullOrEmpty(string? value , string paramName)
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"Parameter {paramName} cannot be null or empty.");
            }
        
        }
        public static void AgainstNullOrWhiteSpace(string? value , string paramName)
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"Parameter {paramName} cannot be null or whitespace.");
            }
        
        }
    }
}