using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Entities;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Repositories;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Services;

namespace DTI.KTArquiteturasShopClean.Core.Application.UseCases.Commands.Core
{
    public abstract class CoreEntityCommandHandler<TEntity, TCommand>
        where TEntity : IEntity
        where TCommand : class
    {
        protected readonly IWriterRepository<TEntity> _writerRepository;
        protected readonly ICommandLogService _commandLogService;

        protected CoreEntityCommandHandler(IWriterRepository<TEntity> writerRepository, ICommandLogService commandLogService)
        {
            _writerRepository = writerRepository;
            _commandLogService = commandLogService;
        }

        
    }
}
