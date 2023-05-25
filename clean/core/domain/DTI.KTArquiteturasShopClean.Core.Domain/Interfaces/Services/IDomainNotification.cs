using DTI.KTArquiteturasShopClean.Core.Domain.Services.DomainNotifications;

namespace DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Services
{
    public interface IDomainNotificationSerivce
    {
        IReadOnlyCollection<DomainNotification> GetNotifications();
        void AddNotification(DomainNotification notification);
    }
}
