namespace PostCart.Application.DTOs.Responses
{
    public record SellerResponse(
        Guid Id,
        string Name,
        string Email,
        string Phone,
        DateTime CreatedAt,
        string Username,
        string ShopName,
        string ShopDescription,
        int AverageRating,
        bool IsVerified,
        string Address
    );
}