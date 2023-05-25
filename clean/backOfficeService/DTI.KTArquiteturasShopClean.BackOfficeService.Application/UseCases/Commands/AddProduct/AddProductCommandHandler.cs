using DTI.KTArquiteturasShopClean.BackOfficeService.Domain.Products;
using DTI.KTArquiteturasShopClean.BackOfficeService.Domain.Products.Interfaces;
using DTI.KTArquiteturasShopClean.Core.Application.UseCases.Commands.AddEntity;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Repositories;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Services;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Validation;
using MediatR;

namespace DTI.KTArquiteturasShopClean.BackOfficeService.Application.UseCases.Commands.AddProduct
{
    public class AddProductCommandHandler : AddEntityCommandHandler<Product, AddProductCommand>, IRequestHandler<AddProductCommand, Guid>
    {
        public AddProductCommandHandler(IProductRepository repository, ICommandLogService commandLogService, IValidationService validationService) : base(repository, commandLogService, validationService)
        {
        }

        public async Task<Guid> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            return await Execute(request);
        }

        public override Product MapCommandToEntity(AddProductCommand command)
        {
            return new Product(Guid.NewGuid(), command.Name, command.Price);
        }
    }
}
