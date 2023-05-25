using MediatR;

namespace DTI.KTArquiteturasShopClean.Core.Domain.Events.DomainNotifications
{
    public class DomainNotificationEvent : INotification
    {
        public DomainNotificationEvent(string code, string description)
        {
            Code = code;
            Description = description;
        }

        public string Code { get; private set; }
        public string Description { get; private set; }
    }
}
