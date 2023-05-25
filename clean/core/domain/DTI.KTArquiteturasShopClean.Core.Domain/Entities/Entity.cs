using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Entities;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Policies;

namespace DTI.KTArquiteturasShopClean.Core.Domain.Entities
{
    public abstract class Entity : IEntity
    {
        protected Entity(Guid id)
        {
            Id = id;
            IsActive = true;
            CreationTime = DateTime.Now;
        }
        public Guid Id { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreationTime { get; private set; }
        public DateTime? InativatedDate { get; private set; }

        public void Inativate()
        {
            IsActive = false;
            InativatedDate = DateTime.Now;
        }

        public abstract IReadOnlyCollection<IValidationPolicy> GetValidationPolicies();
    }
}
