using Marten.Schema;
using System.Security.Cryptography.Xml;

namespace Catalog.Api.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        using var session = store.LightweightSession();

        if (await session.Query<Product>().AnyAsync())
            return;

        session.Store<Product>(GetPreconfiguredProducts());
        await session.SaveChangesAsync();
    }

    private static IEnumerable<Product> GetPreconfiguredProducts() => new List<Product>()
    {
        new Product()
        {
            Id = new Guid("f223b3d8-2385-482b-95e4-f95ee865b8d7"),
            Name = "IPhone XI",
            Description = "This phone is the company's biggest",
            ImagemFile = "product1.png",
            Price = 950.00M,
            Category = new List<string> { "Smart Phone"}
        },
        new Product()
        {
            Id = new Guid("f9831b92-aa74-4aa4-b08d-db9977c008be"),
            Name = "IPhone XII",
            Description = "This phone is the company's biggest",
            ImagemFile = "product1.png",
            Price = 950.00M,
            Category = new List<string> { "Smart Phone"}
        },
        new Product()
        {
            Id = new Guid("4f0ccc51-90e4-4100-a75c-71a34dfc03c1"),
            Name = "IPhone XII",
            Description = "This phone is the company's biggest",
            ImagemFile = "product1.png",
            Price = 950.00M,
            Category = new List<string> { "Smart Phone"}
        },
        new Product()
        {
            Id = new Guid("1453f3ff-328e-4c6c-b41e-492d5e10848a"),
            Name = "IPhone XIV",
            Description = "This phone is the company's biggest",
            ImagemFile = "product1.png",
            Price = 950.00M,
            Category = new List<string> { "Smart Phone"}
        },
        new Product()
        {
            Id = new Guid("7a528059-60a5-4b58-9a9c-f8de0216b9bc"),
            Name = "IPhone XV",
            Description = "This phone is the company's biggest",
            ImagemFile = "product1.png",
            Price = 950.00M,
            Category = new List<string> { "Smart Phone"}
        }
    };
}
