using Cms.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Cms.ECommerce.Shared;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddEcommerceServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IInitializer, ECommerceInitializer>();
        return serviceCollection;
    }
}