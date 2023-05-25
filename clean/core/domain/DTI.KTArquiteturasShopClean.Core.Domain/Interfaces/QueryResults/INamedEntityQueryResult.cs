namespace DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.QueryResults
{
    public interface INamedEntityQueryResult
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}
