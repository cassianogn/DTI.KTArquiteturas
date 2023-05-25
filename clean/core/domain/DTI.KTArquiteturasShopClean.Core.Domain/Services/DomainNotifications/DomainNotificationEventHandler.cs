using DTI.KTArquiteturasShopClean.Core.Domain.Events.DomainNotifications;
using DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Services;
using MediatR;

namespace DTI.KTArquiteturasShopClean.Core.Domain.Services.DomainNotifications
{
    internal class DomainNotificationEventHandler : INotificationHandler<DomainNotificationEvent>
    {
        private readonly IDomainNotificationSerivce _domainNotificationSerivce;
        public DomainNotificationEventHandler(IDomainNotificationSerivce domainNotificationSerivce)
        {
            _domainNotificationSerivce = domainNotificationSerivce;
        }

        public Task Handle(DomainNotificationEvent notification, CancellationToken cancellationToken)
        {
            _domainNotificationSerivce.AddNotification(new DomainNotification(notification.Code, notification.Description));
            return Task.CompletedTask;
        }
    }
}
