namespace PostCart.Application.DTOs.Requests
{
    public record CreateBuyerRequest(
        string Email, 
        string Username, 
        string Password
        );
    public record UpdateBuyerRequest(
        string Name, 
        string Email, 
        string Phone, 
        string Username, 
        string Password, 
        string Address
        );
}