using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Entities;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DTI.Core.Infrastructure.Repositories
{
    public abstract class EntityRepository<TEntity> : 
        IReaderRepository<TEntity>,  
        IWriterRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly DbSet<TEntity> _dbSet;
        private readonly DbContext _dbContext;
        protected EntityRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        public async Task<TEntity> GetEntityByIdAsync(Guid id)
        {
            var entity = await _dbSet.FirstAsync(entity => entity.Id == id);
            return entity;
        }
        public async Task AddAsync(TEntity entity)
        {
            _dbSet.Add(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();

        }

    }
}
