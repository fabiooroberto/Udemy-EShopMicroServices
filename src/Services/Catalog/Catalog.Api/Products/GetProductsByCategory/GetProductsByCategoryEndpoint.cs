namespace Catalog.Api.Products.GetProductsByCategory;

//public record GetProductsByCategoryRequest(string Category);
public record GetProductsByCategoryResult(IEnumerable<Product> Products);
public class GetProductsByCategoryEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.Map("/products/category/{category}", async (string category, ISender sender, CancellationToken cancellation) =>
        {
            var result = await sender.Send(new GetProductsByCategoryQuery(category), cancellation);

            var response = result.Adapt<GetProductsByCategoryResult>();

            return Results.Ok(response);
        })
          .WithName("GetProductsByCategory")
          .Produces<GetProductsByCategoryResult>(StatusCodes.Status200OK)
          .ProducesProblem(StatusCodes.Status400BadRequest)
          .WithSummary("Get Products By Category")
          .WithDescription("Get Products By Category");
    }
}
