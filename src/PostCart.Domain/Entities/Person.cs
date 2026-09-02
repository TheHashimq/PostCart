namespace PostCart.Domain.Entities
{
	public interface Person
	{
		Guid Id { get; init; }
		string Name { get; set; }
		Email Email { get; set; }
		Phone Phone { get; set; }
		DateTime CreatedAt { get; init; }
		string Username { get; set; }
		string Password { get; set; }
	}
}
