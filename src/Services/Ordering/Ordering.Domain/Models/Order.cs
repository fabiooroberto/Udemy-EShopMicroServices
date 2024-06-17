namespace Ordering.Domain.Models;

public class Order : Aggretate<Guid>
{
    private readonly List<OrderItem> _orderItems = new();
    public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();

    public Guid Customerid { get; private set; } = default!;
    public string OrderName { get; private set; } = default!;
    public Address ShippingAdress { get; private set; } = default!;
    public Address BillingAdress { get; private set; } = default!;
    public Payment Payment { get; private set; } = default!;
    public OrderStatus Status { get; private set; } = OrderStatus.Pending;
    public decimal TotalPrice
    {
        get => OrderItems.Sum(oi => oi.Price * oi.Quantity);
        private set { }
    }
}
