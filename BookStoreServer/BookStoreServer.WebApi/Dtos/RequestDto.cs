namespace BookStoreServer.WebApi.Dtos;

public sealed record RequestDto(
    int PageSize,
    int? CategoryId,
    string Search);
