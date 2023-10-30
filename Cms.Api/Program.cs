using System.Reflection;
using Cms.ECommerce;
using Cms.ECommerce.Shared;
using Cms.EducationPortal;
using Cms.EducationPortal.Shared;
using Cms.Shared;
using Cms.Shared.Shared;

var builder = WebApplication.CreateBuilder(args);
var eCommerce = ECommerce.GetECommerceAssembly();
var education = EducationPortal.GetEducationPortalAssembly();
var shared = SharedAssembly.GetSharedAssembly();
builder.Services.AddControllers()
    .AddApplicationPart(shared)
    .AddApplicationPart(education)
    .AddApplicationPart(eCommerce);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEcommerceServices();
builder.Services.AddEducationPortalServices();


builder.Services.AddServices(builder.Configuration, new List<Assembly>{education,eCommerce});
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();