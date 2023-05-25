using DTI.KTArquiteturasShopClean.Core.Application.UseCases.Commands.Core;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Entities;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Repositories;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Services;

namespace DTI.KTArquiteturasShopClean.Core.Application.UseCases.Commands.DeleteEntity
{
    public abstract class DeleteEntityCommandHandler<TEntity, TDeleteCommand> : CoreEntityCommandHandler<TEntity, TDeleteCommand>
        where TEntity : IEntity
        where TDeleteCommand : class, IEntityDTO
    {
        protected readonly IReaderRepository<TEntity> _readerRepository;

        protected DeleteEntityCommandHandler(IWriterRepository<TEntity> writerRepository, ICommandLogService commandLogService) : base(writerRepository, commandLogService)
        {
        }

        public async Task Execute(TDeleteCommand command)
        {
            var entity = await _readerRepository.GetEntityByIdAsync(command.Id);
            entity.Inativate();
            await _writerRepository.UpdateAsync(entity);
        }
    }
}
