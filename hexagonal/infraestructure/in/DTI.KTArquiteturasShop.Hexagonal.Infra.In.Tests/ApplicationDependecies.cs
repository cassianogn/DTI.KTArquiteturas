using DTI.KTArquiteturasShop.Hexagonal.Infra.InversionOfControl;
using DTI.KTArquiteturasShop.Hexagonal.Infra.Out.SqlAccessData;
using Microsoft.Extensions.DependencyInjection;

namespace DTI.KTArquiteturasShop.Hexagonal.Infra.In.Tests
{
    internal static class ApplicationDependecies
    {
        public static TResource GetFakeService<TResource>()
        {
            var providers = new ServiceCollection()
                .AddApplicationWithFakeAccessData()
                .BuildServiceProvider();

            var resource = providers.GetService<TResource>();
            return resource!;
        }
        public static TResource GetProductionService<TResource>()
        {
            var providers = new ServiceCollection()
                .AddSqlAccessDataModule()
                .BuildServiceProvider();

            var resource = providers.GetService<TResource>();
            return resource!;
        }
    }
}
