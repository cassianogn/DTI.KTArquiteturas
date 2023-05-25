using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Policies;

namespace DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Validation
{
    public interface IValidationService
    {
        public bool IsValid(IEnumerable<IPolicy> policies);
    }
}
