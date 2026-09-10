namespace PostCart.Application.DTOs.Responses
{
    public record BuyerResponse(
        Guid Id,
        string Name,
        string Email,
        string Phone,
        DateTime CreatedAt,
        string Username,
        string Address
    );
}