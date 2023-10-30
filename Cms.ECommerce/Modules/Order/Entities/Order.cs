using Cms.Shared.Shared;
using Cms.Shared.Shared.Entities;

namespace Cms.ECommerce.Modules.Order.Entities;
 
public class Order : Entity
{
    public string FullName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Comment { get; set; }
    public List<OrderItem.Entities.OrderItem> Items { get; set; } = new();
    protected override int GetClassId() => ClassNames.Order;
}