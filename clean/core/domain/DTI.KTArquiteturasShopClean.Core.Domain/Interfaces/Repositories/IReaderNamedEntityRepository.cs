using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Entities;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.QueryResults;

namespace DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Repositories
{
    public interface IReaderNamedEntityRepository<TNamedEntity> : IReaderRepository<TNamedEntity> where TNamedEntity : INamedEntity
    {
        Task<IReadOnlyCollection<INamedEntityQueryResult>> SearchEntityByName(string name = "");
    }
}
