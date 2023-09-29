using Cms.Shared;
using Cms.Shared.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Cms.EducationPortal.Shared;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddEducationPortalServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IInitializer, EducationPortalInitializer>();
        return serviceCollection;
    }
}