using System.Reflection;
using Cms.ECommerce;
using Cms.ECommerce.Shared;
using Cms.EducationPortal;
using Cms.EducationPortal.Shared;
using Cms.Setup;
using Cms.Shared.Shared;
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
serviceCollection.AddEcommerceServices();
serviceCollection.AddEducationPortalServices();
serviceCollection.AddScoped<InitializeProvider>();
var serviceProvider = serviceCollection.BuildServiceProvider();
var provider = serviceProvider.GetRequiredService<InitializeProvider>();
await provider.Initialize();

