using DTI.KTArquiteturasShopClean.Core.Application.UseCases.Commands.Core;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Entities;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Repositories;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Services;

namespace DTI.KTArquiteturasShopClean.Core.Application.UseCases.Commands.UpdateEntity
{
    public abstract class UpdateEntityCommandHandler<TEntity, TUpdateCommand> : CoreEntityCommandHandler<TEntity, TUpdateCommand>
        where TEntity : IEntity
        where TUpdateCommand : class, IEntityDTO
    {
        protected readonly IReaderRepository<TEntity> _readerRepository;

        protected UpdateEntityCommandHandler(IWriterRepository<TEntity> writerRepository, ICommandLogService commandLogService) : base(writerRepository, commandLogService)
        {
        }

        public async Task Execute(TUpdateCommand command)
        {
            var entity = await _readerRepository.GetEntityByIdAsync(command.Id);

            entity = UpdateEntity(entity, command);

            await _writerRepository.UpdateAsync(entity);

        }

        protected abstract TEntity UpdateEntity(TEntity entity, TUpdateCommand command);
    }
}
