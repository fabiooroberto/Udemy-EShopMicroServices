
using Catalog.Api.Products.CreateProduct;

namespace Catalog.Api.Products.GetProductById;

//public record GetProductByIdRequest();
public record GetProductByIdResponse(Product Product);
public class GetProductByIdEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products/{id}", async (Guid id, ISender sender, CancellationToken cancellation) =>
        {
            var result = await sender.Send(new GetProductByIdQuery(id), cancellation);

            var response = result.Adapt<GetProductByIdResponse>();

            return Results.Ok(response);
        })
          .WithName("CreateProductById")
          .Produces<GetProductByIdResponse>(StatusCodes.Status200OK)
          .ProducesProblem(StatusCodes.Status400BadRequest)
          .WithSummary("Create Product By Id")
          .WithDescription("Create Product By Id"); ;
    }
}
