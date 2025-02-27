﻿
namespace Catalog.API.Products.GetProductById
{
    public record GetProductByIdReponse(Product Product);

    public class GetProductByIdEndPoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/products/{id}", async (Guid id, ISender sender) =>
            {
                var result = await sender.Send(new GetProductByIdQuery(id));

                var response = result.Adapt<GetProductByIdReponse>();

                return Results.Ok(response);
            })
                .WithName("GetProductById")
                .Produces<GetProductByIdReponse>(StatusCodes.Status200OK)
                .ProducesProblem(StatusCodes.Status400BadRequest)
                .WithSummary("Get product by Id")
                .WithDescription("Get product by Id");
        }
    }
}
