using DTI.KTArquiteturasShop.Hexagonal.Infra.Out.FakeAccessData;
using DTI.KTArquiteturasShop.Hexagonal.Infra.Out.SqlAccessData;
using Microsoft.Extensions.DependencyInjection;

namespace DTI.KTArquiteturasShop.Hexagonal.Infra.InversionOfControl
{
    public static class ApplicationAllModules
    {
        public static IServiceCollection AddApplicationWithFakeAccessData(this IServiceCollection services)
        {
            services.AddFakeAccessDataModule();

            return services;
        }

        public static IServiceCollection AddApplicationWithSqlAccessData(this IServiceCollection services)
        {
            services.AddSqlAccessDataModule();

            return services;
        }
    }
}
