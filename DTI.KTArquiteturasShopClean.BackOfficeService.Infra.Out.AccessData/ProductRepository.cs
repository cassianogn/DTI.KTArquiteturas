using DTI.Core.Infrastructure.Repositories;
using DTI.KTArquiteturasShopClean.BackOfficeService.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace DTI.KTArquiteturasShopClean.BackOfficeService.Infra.Out.SqlAccessData
{
    internal class ProductRepository : EntityRepository<Product>
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
