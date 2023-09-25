
using System.Reflection;
using Cms.ECommerce;
using Cms.EducationPortal;
using Cms.Shared.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", true, true)
    .Build();

var eCommerce = ECommerce.GetECommerceAssembly();
var education = EducationPortal.GetEducationPortalAssembly(); 

var serviceCollection = new ServiceCollection();
serviceCollection.AddLogging();
serviceCollection.AddServices(configuration, new List<Assembly>{eCommerce, education});
var serviceProvider = serviceCollection.BuildServiceProvider();

var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
var dataContext = serviceProvider.GetRequiredService<DataContext>();

var roles = new List<IdentityRole>()
{
    new()
    {
        Name = "Administrator",
        ConcurrencyStamp = Guid.NewGuid().ToString()
    }
};

foreach (var role in roles)
{
    await roleManager.CreateAsync(role);
}

await dataContext.SaveChangesAsync();
