namespace Ordering.Application.Dtos;

public record PaymentDto(string CardName, string CardNumber, string Expiration, string Cvv, int PaymentMethod)
{
    internal static PaymentDto ToDto(Payment payment)
    {
        var result = new PaymentDto(
                    CardName: payment.CardName,
                    CardNumber: payment.CardNumber,
                    Expiration: payment.Expiration,
                    Cvv: payment.CVV,
                    PaymentMethod: payment.PaymentMethod);
        return result;
    }
}
