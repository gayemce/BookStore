namespace BookStoreServer.WebApi.Dtos;

public sealed record RequestDto(
    int PageNumber,
    int PageSize,
    int? CategoryId,
    string Search);
