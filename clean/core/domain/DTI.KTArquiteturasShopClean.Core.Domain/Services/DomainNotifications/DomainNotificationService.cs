using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Services;

namespace DTI.KTArquiteturasShopClean.Core.Domain.Services.DomainNotifications
{
    internal class DomainNotificationService : IDomainNotificationSerivce
    {
        private readonly IList<DomainNotification> _domainNotifications;

        public DomainNotificationService()
        {
            _domainNotifications = new List<DomainNotification>();
        }

        public IReadOnlyCollection<DomainNotification> GetNotifications() => _domainNotifications.ToList();
        public void AddNotification(DomainNotification notification) => _domainNotifications.Add(notification);
    }
}
