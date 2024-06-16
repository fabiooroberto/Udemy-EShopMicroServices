namespace Discount.Grpc.Models;

public class Coupon
{
    public int Id { get; set; }
    public string ProductName { get; set; } = default!;
    public string Description { get; set; } = default!;
    public int Amount { get; set; }

    public static Coupon NoDiscount()
    {
        return new Coupon
        {
            Id = 0,
            ProductName = "No Discount",
            Amount= 0,
            Description = "No Discount"
        };
    }

}
