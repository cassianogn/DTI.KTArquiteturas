namespace DTI.KTArquiteturasShopClean.Core.Domain.Services.DomainNotifications
{
    public class DomainNotification
    {
        public string Code { get; private set; }
        public string Description { get; private set; }
        internal DomainNotification(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}
