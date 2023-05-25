using System;

namespace DTI.KTArquiteturasShopClean.Core.Domain.Interfaces.Services
{
    public interface ICommandLogService
    {
        public void SavaCommand(object command);
        public void SavaCommand(object command, Exception excption);
    }
}
