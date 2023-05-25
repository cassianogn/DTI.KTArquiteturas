using DTI.KTArquiteturasShopClean.BackOfficeService.Domain.Products.Policies;
using DTI.KTArquiteturasShopClean.Core.Domain.Entities;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Policies;

namespace DTI.KTArquiteturasShopClean.BackOfficeService.Domain.Products
{
    public class Product : NamedEntity
    {
        public Product(Guid id, string name, double price) : base(id, name)
        {
            Price = price;
        }

        public double Price { get; private set; }

        public override IReadOnlyCollection<IValidationPolicy> GetValidationPolicies()
        {
            return new List<IValidationPolicy>
            {
                new ValidateProductPolicy()
            };
        }
    }
}
