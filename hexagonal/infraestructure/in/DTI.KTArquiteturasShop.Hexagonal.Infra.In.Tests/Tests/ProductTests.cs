using DTI.KTArquiteturasShop.Hexagonal.Application.Ports.In.UseCase.Products;
using DTI.KTArquiteturasShop.Hexagonal.Application.Ports.Out;
using Xunit;

namespace DTI.KTArquiteturasShop.Hexagonal.Infra.In.Tests.Tests
{
    public class ProductTests
    {

        [Fact(DisplayName = "Add Product")]
        public void AddProduct()
        {
            var repository = ApplicationDependecies.GetProductionService<IProductRepository>();
            var useCase = new AddProductUseCase(repository);
            var parameters = new AddProductParameters()
            {
                Name = "book 32",
                Price = 10
            };
            
            Guid newId = useCase.Execute(parameters);

            Assert.NotEqual(Guid.Empty, newId);
        }
    }
}
