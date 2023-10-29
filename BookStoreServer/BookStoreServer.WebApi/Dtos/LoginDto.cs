namespace BookStoreServer.WebApi.Dtos;

public sealed record class LoginDto(
    string UsernameOrEmail,
    string Password);
