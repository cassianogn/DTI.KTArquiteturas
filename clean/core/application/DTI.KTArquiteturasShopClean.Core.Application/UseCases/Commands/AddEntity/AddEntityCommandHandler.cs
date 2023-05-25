using DTI.KTArquiteturasShopClean.Core.Application.UseCases.Commands.Core;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Entities;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Repositories;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Services;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Validation;

namespace DTI.KTArquiteturasShopClean.Core.Application.UseCases.Commands.AddEntity
{
    public abstract class AddEntityCommandHandler<TEntity, TAddCommand> : CoreEntityCommandHandler<TEntity, TAddCommand>
        where TEntity : IEntity
        where TAddCommand : class
    {
        private readonly IValidationService _validationService;

        protected AddEntityCommandHandler(IWriterRepository<TEntity> writerRepository, ICommandLogService commandLogService, IValidationService validationService) : base(writerRepository, commandLogService)
        {
            _validationService = validationService;
        }

        public virtual async Task<Guid> Execute(TAddCommand command)
        {
            try
            {
                var entity = MapCommandToEntity(command);

                if (!_validationService.IsValid(entity.GetValidationPolicies()))
                    return Guid.Empty;

                await _writerRepository.AddAsync(entity);
                
                _commandLogService.SavaCommand(command);
                
                return entity.Id;
            }
            catch (Exception exception)
            {
                _commandLogService.SavaCommand(command, exception);

                throw;
            }
           
        }
        public abstract TEntity MapCommandToEntity(TAddCommand command);

    }
}
