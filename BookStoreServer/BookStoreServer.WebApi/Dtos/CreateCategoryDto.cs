namespace BookStoreServer.WebApi.Dtos;

//record classlara göre daha az kod yazmamızı sağlar ve özellikle parametre istenecekse kullanılır.
public sealed record CreateCategoryDto(
    string Name);
