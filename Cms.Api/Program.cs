using System.Reflection;
using Cms.ECommerce;
using Cms.EducationPortal;
using Cms.Shared;
using Cms.Shared.Shared;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var eCommerce = ECommerce.GetECommerceAssembly();
var education = EducationPortal.GetEducationPortalAssembly();


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