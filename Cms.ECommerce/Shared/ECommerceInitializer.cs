using Cms.ECommerce.Modules.Order.Entities;
using Cms.Shared;
using Cms.Shared.Shared;
using Cms.Shared.Shared.Services;

namespace Cms.ECommerce.Shared;

public class ECommerceInitializer : IInitializer
{
    private readonly InitializerService _initializerService;

    public ECommerceInitializer(InitializerService initializerService)
    {
        _initializerService = initializerService;
    }

    public async Task Initialize()
    {
        await _initializerService.AddTestData(new List<Order>()
        {
            new()
            {
                ObjectName = "Test1",
                Caption = "Тестовый заказ",
                Description = "Описание тестового заказа"
            },
            new()
            {
                ObjectName = "Test2",
                Caption = "Тестовый заказ 1 ",
                Description = "Описание тестового заказа 1"
            }
        });
    }
}