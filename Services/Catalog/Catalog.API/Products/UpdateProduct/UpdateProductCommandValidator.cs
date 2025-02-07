namespace Catalog.API.Products.UpdateProduct
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required")
                .Length(2,150).WithMessage("Name should be between 2 and 150 charactors");
            RuleFor(x => x.Category).NotEmpty().WithMessage("Category is required");
            RuleFor(x => x.ImageFile).NotEmpty().WithMessage("ImageFile is required");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price is required");
        }
    }
}