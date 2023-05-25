namespace DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Policies
{
    public interface IValidationPolicy : IPolicy
    {
        bool IsValid();
    }
}
