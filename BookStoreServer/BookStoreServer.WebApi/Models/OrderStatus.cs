using BookStoreServer.WebApi.Enums;
using static BookStoreServer.WebApi.Models.Order;

namespace BookStoreServer.WebApi.Models;

public sealed class OrderStatus
{
    public int Id { get; set; }
    public string OrderNumber { get; set; }
    public OrderStatusEnum Status { get; set; }
    public DateTime StatusDate { get; set; }
}
