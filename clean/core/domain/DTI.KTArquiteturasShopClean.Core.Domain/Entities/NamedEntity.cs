using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Entities;

namespace DTI.KTArquiteturasShopClean.Core.Domain.Entities
{
    public abstract class NamedEntity : Entity, INamedEntity
    {
        protected NamedEntity(Guid id, string name) : base(id)
        {
            Name = name;
        }

        public string Name { get; protected set; }
    }
}
