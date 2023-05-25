using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Policies;

namespace DTI.KTArquiteturasShopClean.BackOfficeService.Domain.Products.Policies
{
    public class ValidateProductPolicy : IValidationPolicy
    {
        public bool IsValid()
        {
            return true;
        }
    }
}
