using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.QueryResults;

namespace DTI.KTArquiteturasShopClean.Core.Domain.GenericsDTOs.QueryResults
{
    public class NamedEntityQueryResult : INamedEntityQueryResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
