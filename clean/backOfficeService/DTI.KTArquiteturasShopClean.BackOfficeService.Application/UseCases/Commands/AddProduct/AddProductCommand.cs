using DTI.KTArquiteturasShopClean.Core.Domain.GenericsDTOs.Commands;
using MediatR;

namespace DTI.KTArquiteturasShopClean.BackOfficeService.Application.UseCases.Commands.AddProduct
{
    public class AddProductCommand : NamedEntityCommand, IRequest<Guid>
    {
        public double Price { get; set; }

    }
}
