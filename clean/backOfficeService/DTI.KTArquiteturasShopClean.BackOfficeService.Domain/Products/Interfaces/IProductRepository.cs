using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Repositories;

namespace DTI.KTArquiteturasShopClean.BackOfficeService.Domain.Products.Interfaces
{
    public interface IProductRepository : IWriterRepository<Product>, IReaderNamedEntityRepository<Product>
    {
    }
}
