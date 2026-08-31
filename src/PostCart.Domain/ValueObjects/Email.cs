using System.Text.RegularExpressions;

namespace PostCart.Domain
{
	public class Email
	{
		public string Value{ get; private set; }
		private Email(string email)
		{
			
				Value = email;
			
		}
		private static bool IsValidFormat(string email)
		{
			if (string.IsNullOrWhiteSpace(email))
				return false;
			return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", RegexOptions.IgnoreCase);
		}


		public override bool Equals(object obj)
		{
			if (obj is not Email other)
				return false;

			return Value.Equals(other.Value, StringComparison.OrdinalIgnoreCase);
		}
		public override int GetHashCode()
		{
			return Value.ToLower().GetHashCode();
		}
		public static Email Create(string email)
		{
			if (!IsValidFormat(email))
				throw new ArgumentException("Invalid email format.", nameof(email));

			return new Email(email);
		}

	}
}
