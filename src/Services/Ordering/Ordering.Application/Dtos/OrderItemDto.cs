namespace Ordering.Application.Dtos;

public record OrderItemDto(Guid OrderId, Guid ProductId, int Quantity, decimal Price)
{
    internal static OrderItemDto ToDto(OrderItem oi)
    {
        return new OrderItemDto(OrderId: oi.OrderId.Value, ProductId: oi.ProductId.Value, Quantity: oi.Quantity, Price: oi.Price);
    }
}
