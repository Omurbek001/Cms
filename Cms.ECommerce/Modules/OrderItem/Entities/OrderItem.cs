using Cms.Shared.Shared;
using Cms.Shared.Shared.Entities;

namespace Cms.ECommerce.Modules.OrderItem.Entities;

public class OrderItem:Entity
{
    public long OrderId { get; set; }
    public Order.Entities.Order? Order { get; set; }
    public long CommodityId { get; set; }
    public Commodity.Entities.Commodity? Commodity { get; set; }
    public int Count { get; set; }
    protected override int GetClassId() => ClassNames.OrderItem;
}