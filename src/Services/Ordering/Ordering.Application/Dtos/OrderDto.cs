namespace Ordering.Application.Dtos;

public record OrderDto(
    Guid Id,
    Guid CustomerId,
    string OrderName,
    AddressDto ShippingAddress,
    AddressDto BillingAddress,
    PaymentDto Payment,
    OrderStatus Status,
    List<OrderItemDto> OrderItems)
{
    internal static OrderDto ToDto(Order order)
    {
        return new OrderDto(
                Id: order.Id.Value,
                CustomerId: order.CustomerId.Value,
                OrderName: order.OrderName.Value,
                ShippingAddress: AddressDto.ToDto(order.ShippingAddress),
                BillingAddress: AddressDto.ToDto(order.BillingAddress),
                Payment: PaymentDto.ToDto(order.Payment),
                Status: order.Status,
                OrderItems: order.OrderItems.Select(oi => OrderItemDto.ToDto(oi)).ToList()
              );
    }
}
