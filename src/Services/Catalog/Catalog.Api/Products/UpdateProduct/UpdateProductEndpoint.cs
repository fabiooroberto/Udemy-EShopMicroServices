namespace Catalog.Api.Products.UpdateProduct;

public record UpdateProductRequest(Guid Id, string Name, List<string> Category, string Description, decimal Price, string ImagemFile);

public record UpdateProductResponse(bool IsSuccess);
public class UpdateProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPut("/products", async (UpdateProductRequest request, ISender sender, CancellationToken cancellation) =>
        {
            var command = request.Adapt<UpdateProductCommand>();

            var result = await sender.Send(command, cancellation);

            var response = result.Adapt<UpdateProductResult>();

            return Results.NoContent();
        })
          .WithName("UpdateProduct")
          .Produces<UpdateProductResponse>(StatusCodes.Status204NoContent)
          .ProducesProblem(StatusCodes.Status400BadRequest)
          .WithSummary("Update Product")
          .WithDescription("Update Product");
    }
}
