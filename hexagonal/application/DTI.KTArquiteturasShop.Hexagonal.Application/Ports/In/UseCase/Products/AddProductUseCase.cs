using DTI.KTArquiteturasShop.Hexagonal.Application.Domain.Entities;
using DTI.KTArquiteturasShop.Hexagonal.Application.Domain.Validators;
using DTI.KTArquiteturasShop.Hexagonal.Application.Ports.Out;

namespace DTI.KTArquiteturasShop.Hexagonal.Application.Ports.In.UseCase.Products
{
    public class AddProductUseCase
    {
        private readonly IProductRepository _repository;
        public AddProductUseCase(IProductRepository repository)
        {
            _repository = repository;
        }


        public Guid Execute(AddProductParameters productParameters)
        {
            var product = new Product(Guid.NewGuid(), productParameters.Name, productParameters.Price);
            
            if (!ProductValidator.IsValid(product))
                throw new Exception("Product invalid");

            _repository.Add(product);

            return product.Id;
        }
    }}
