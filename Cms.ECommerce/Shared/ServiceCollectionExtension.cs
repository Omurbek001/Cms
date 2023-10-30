using Cms.ECommerce.Modules.Cart.Services;
using Cms.ECommerce.Modules.Order.Services;
using Cms.Shared.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Cms.ECommerce.Shared;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddEcommerceServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<CartService>();
        serviceCollection.AddScoped<OrderService>();
        serviceCollection.AddScoped<IInitializer, ECommerceInitializer>();
        return serviceCollection;
    }
}