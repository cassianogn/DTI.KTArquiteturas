using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Entities;

namespace DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Repositories
{
    public interface IWriterRepository<in TEntity> where TEntity : IEntity
    {
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
