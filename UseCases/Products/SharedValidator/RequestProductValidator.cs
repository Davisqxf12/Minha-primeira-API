using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Products.SharedValidator
{
    public class RequestProductValidator : AbstractValidator<RequestProductJson>
    {
        public RequestProductValidator()
        {
            RuleFor(product => product.Name).NotEmpty().WithMessage("Nome do Produto inválido.");
            RuleFor(product => product.Brand).NotEmpty().WithMessage("Marca do Produto inválida.");
            RuleFor(product => product.Price).GreaterThan(0).WithMessage("Preço para o Produto inválido.");
        }
    }
}
