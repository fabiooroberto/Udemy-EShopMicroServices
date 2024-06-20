namespace Ordering.Application.Dtos;

public record AddressDto(string FirstName, string LastName, string EmailAddress, string AddressLine, string Country, string State, string ZipCode)
{
    public static AddressDto ToDto(Address address)
    {
        var result = new AddressDto(
                    FirstName: address.FirstName,
                    LastName: address.LastName,
                    EmailAddress: address.EmailAddress,
                    AddressLine: address.AddressLine,
                    Country: address.Country,
                    State: address.State,
                    ZipCode: address.ZipCode);
        return result;
    }
}
