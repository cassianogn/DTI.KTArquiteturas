using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Policies;

namespace DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Entities
{
    public interface IEntity
    {
        Guid Id { get; }

        void Inativate();
        public IReadOnlyCollection<IValidationPolicy> GetValidationPolicies();
    }
}
