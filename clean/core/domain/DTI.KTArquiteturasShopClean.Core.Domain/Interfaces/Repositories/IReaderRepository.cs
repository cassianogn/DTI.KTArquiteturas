using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Entities;

namespace DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Repositories
{
    public interface IReaderRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> GetEntityByIdAsync(Guid id);

    }
}
