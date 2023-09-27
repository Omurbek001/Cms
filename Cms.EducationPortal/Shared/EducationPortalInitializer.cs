using Cms.EducationPortal.Modules.University.Entities;
using Cms.Shared;
using Cms.Shared.Shared;
using Cms.Shared.Shared.Services;
using Microsoft.EntityFrameworkCore;

namespace Cms.EducationPortal.Shared;

public class EducationPortalInitializer : IInitializer
{
    private readonly InitializerService _initializerService;
    
    public EducationPortalInitializer(InitializerService initializerService)
    {
        _initializerService = initializerService;
    }

    public async Task Initialize()
    {
        await _initializerService.AddTestData(new List<University>()
        {
            new()
            {
                ObjectName = "Test1",
                Name = "Тестовый заказ",
            },
            new()
            {
                ObjectName = "Test2",
                Name = "Тестовый университет",
            }
        });
    }
}