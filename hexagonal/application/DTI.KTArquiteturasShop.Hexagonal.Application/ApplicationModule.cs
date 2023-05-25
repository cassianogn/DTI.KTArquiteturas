using DTI.KTArquiteturasShop.Hexagonal.Application.Ports.Out;
using Microsoft.Extensions.DependencyInjection;

namespace DTI.KTArquiteturasShop.Hexagonal.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationRepositories<TProductRepository>(this IServiceCollection services)
            where TProductRepository : class, IProductRepository
        {
            services.AddScoped<IProductRepository, TProductRepository>();
            return services;
        }

    }
}
