namespace PostCart.Application.DTOs.Requests
{
    public record CreateSellerRequest(
        string Email, 
        string Username, 
        string Password
        );
    public record UpdateSellerRequest(
        string Name, 
        string Email, 
        string Phone, 
        string Username, 
        string Password, 
        string ShopName, 
        string ShopDescription,
        string Address
        );   
}