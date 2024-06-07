namespace Catalog.Api.Products.CreateProduct;

public record CreateProductRequest(string Name, List<string> Category, string Description, decimal Price, string ImagemFile);

public record CreateProductResponse(Guid Id);
public class CreateProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/products", async (CreateProductRequest request, ISender sender, CancellationToken cancellation) =>
        {
            var command = request.Adapt<CreateProductCommand>();

            var result = await sender.Send(command, cancellation);

            var response = result.Adapt<CreateProductResult>();

            return Results.Created($"/products/{response.Id}", response);
        })
          .WithName("CreateProduct")
          .Produces<CreateProductResponse>(StatusCodes.Status201Created)
          .ProducesProblem(StatusCodes.Status400BadRequest)
          .WithSummary("Create Product")
          .WithDescription("Create Product");
    }
}
