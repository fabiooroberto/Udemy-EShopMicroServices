namespace Ordering.Application.Extensions;
public static class OrderExtensions
{
    public static IEnumerable<OrderDto> ToOrderDtoList(this List<Order> orders)
    {
        List<OrderDto> result = new();
        foreach (var order in orders)
        {
            var orderDto = OrderDto.ToDto(order);
            result.Add(orderDto);
        }

        return result;
    }
}
